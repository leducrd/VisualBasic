Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FormMain

    Public Shared currentMayor As New Mayor()
    Dim constant As New Constants()
    Dim mayors As New BindingList(Of Mayor)
    Dim lastID As Integer

    Public Shared dsMayor As New DataSet("ExistingMayors")

    'On Load stuff
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstUsers.DataSource = mayors
        lstUsers.DisplayMember = "MayorInfo"

        ' Clear placeholders so user can start the program with a blank slate
        lblCatalogueCurrent.Text = String.Empty
        lblCatalogueNext.Text = String.Empty
        lblFishCurrent.Text = String.Empty
        lblFishNext.Text = String.Empty
        lblInsectCurrent.Text = String.Empty
        lblInsectNext.Text = String.Empty
        lblSeafoodCurrent.Text = String.Empty
        lblSeafoodNext.Text = String.Empty

        'Code that loads data from database into the program
        Dim dbConnection As SqlConnection = connectToDb()
        Dim daMayor As New SqlDataAdapter("SELECT * FROM Mayor", dbConnection)
        'These two things load the data into our program
        daMayor.FillSchema(dsMayor, SchemaType.Source, "Mayor")
        daMayor.Fill(dsMayor, "Mayor")

        'Not necessary; creates a shortcut variable
        Dim mayorTable As DataTable = dsMayor.Tables("Mayor")

        For Each row As DataRow In mayorTable.Rows
            populateMayor(row)
        Next

        Dim identSql As String = "SELECT IDENT_CURRENT('Mayor') as lastId"
        Dim identCom As New SqlCommand(identSql, dbConnection)

        Dim identReader As SqlDataReader = identCom.ExecuteReader()

        If identReader.HasRows Then
            identReader.Read()
            lastID = CInt(identReader.Item("lastId"))
        End If

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    'Button Mayor Creation events
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim newMayor As New Mayor

        Dim dbConnection As SqlConnection = connectToDb()
        Dim daMayor As New SqlDataAdapter("SELECT * FROM Mayor", dbConnection)
        Dim builder As New SqlCommandBuilder(daMayor)
        daMayor.InsertCommand = builder.GetInsertCommand

        Dim mayorTable As DataTable = dsMayor.Tables("Mayor")
        Dim mayorRow As DataRow

        If txtMayorName.Text = String.Empty Or txtTownName.Text = String.Empty Then
            MessageBox.Show("Please do not leave either Mayor Name or Town Name empty.")
        Else
            newMayor.MayorName = txtMayorName.Text
            newMayor.TownName = txtTownName.Text

            mayors.Add(newMayor)
            currentMayor = newMayor

            'add a new row, but it is added to the dataset table, not the database
            mayorRow = mayorTable.NewRow

            lastID += 1
            currentMayor.ID = lastID

            'populate mayor in DB table
            populateRow(mayorRow)

            mayorTable.Rows.Add(mayorRow)

            daMayor.Update(dsMayor, "Mayor")

            dbConnection.Dispose()
            dbConnection.Close()

            txtMayorName.Clear()
            txtTownName.Clear()
        End If

    End Sub

    'Button Opens the enter stats form
    Private Sub btnEnterStats_Click(sender As Object, e As EventArgs) Handles btnEnterStats.Click
        Dim enterInfo As New EnterStats
        If IsNothing(lstUsers.SelectedItem) Then
            MessageBox.Show("You must create a mayor before entering collection stats.")
        Else
            currentMayor = CType(lstUsers.SelectedItem, Mayor)
            DisplayMayorInfo()
            enterInfo.ShowDialog()
        End If
    End Sub

    'Displays mayor info
    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged
        If IsNothing(lstUsers.SelectedItem) Then
            Dim emptyMayor As New Mayor
            currentMayor = emptyMayor
        Else
            currentMayor = CType(lstUsers.SelectedItem, Mayor)
            DisplayMayorInfo()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dbConnection As SqlConnection = connectToDb()
        Dim daMayor As New SqlDataAdapter("SELECT * FROM Mayor", dbConnection)
        Dim builder As New SqlCommandBuilder(daMayor)
        daMayor.DeleteCommand = builder.GetDeleteCommand
        Dim mayorTable As DataTable = dsMayor.Tables("Mayor")

        If dsMayor.Tables("Mayor").Rows.Contains(currentMayor.ID) Then
            mayorTable.Rows.Find(currentMayor.ID).Delete()
            mayors.Remove(currentMayor)
            If IsNothing(lstUsers.SelectedItem) Then
                Dim emptyMayor As New Mayor
                currentMayor = emptyMayor
            Else
                currentMayor = CType(lstUsers.SelectedItem, Mayor)
                DisplayMayorInfo()
            End If
        End If

        daMayor.Update(dsMayor, "Mayor")
        daMayor.Dispose()
        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    'Button to exit app
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Function that diplays selected mayor's stats
    Public Sub DisplayMayorInfo()
        Dim catalogueCurrent As Double = currentMayor.CalcPercentCompletetion(currentMayor.CatalogueBadgeNum, constant.GetCatalogueComplete)
        Dim catalogueNext As Double = currentMayor.GetNextCatalogueLevel(catalogueCurrent)

        Dim fishCurrent As Double = currentMayor.CalcPercentCompletetion(currentMayor.FishBadgeNum, constant.GetFishComplete)
        Dim fishNext As Double = currentMayor.GetNextFishLevel(fishCurrent)

        Dim insectCurrent As Double = currentMayor.CalcPercentCompletetion(currentMayor.InsectBadgeNum, constant.GetInsectComplete)
        Dim insectNext As Double = currentMayor.GetNextInsectLevel(insectCurrent)

        Dim seafoodCurrent As Double = currentMayor.CalcPercentCompletetion(currentMayor.SeafoodBadgeNum, constant.GetSeafoodComplete)
        Dim seafoodNext As Double = currentMayor.GetNextSeafoodLevel(seafoodCurrent)

        lblMayorProgress.Text = "Badge progress for " & currentMayor.MayorName & " of " & currentMayor.TownName

        lblCatalogueCurrent.Text = catalogueCurrent.ToString("p0")
        lblCatalogueNext.Text = catalogueNext.ToString("p0")

        If currentMayor.CatalogueBadgeNum >= constant.GetCatalogueGold Then
            picCurCatBadge.Visible = True
            picCurCatBadge.Image = My.Resources.GoldCatalogueBadge
            picNextCatBadge.Visible = True
            picNextCatBadge.Image = My.Resources.GoldCatalogueBadge
        ElseIf currentMayor.CatalogueBadgeNum >= constant.GetCatalogueSilver Then
            picCurCatBadge.Visible = True
            picCurCatBadge.Image = My.Resources.SilverCatalogueBadge
            picNextCatBadge.Visible = True
            picNextCatBadge.Image = My.Resources.GoldCatalogueBadge
        ElseIf currentMayor.CatalogueBadgeNum >= constant.GetCatalogueBronze Then
            picCurCatBadge.Visible = True
            picCurCatBadge.Image = My.Resources.BronzeCatalogueBadge
            picNextCatBadge.Visible = True
            picNextCatBadge.Image = My.Resources.SilverCatalogueBadge
        Else
            picCurCatBadge.Visible = False
            picNextCatBadge.Visible = True
            picNextCatBadge.Image = My.Resources.BronzeCatalogueBadge
        End If

        lblFishCurrent.Text = fishCurrent.ToString("p0")
        lblFishNext.Text = fishNext.ToString("p0")

        If currentMayor.FishBadgeNum >= constant.GetFishGold Then
            picCurFishBadge.Visible = True
            picCurFishBadge.Image = My.Resources.GoldFishBadge
            picNextFishBadge.Visible = True
            picNextFishBadge.Image = My.Resources.GoldFishBadge
        ElseIf currentMayor.FishBadgeNum >= constant.GetFishSilver Then
            picCurFishBadge.Visible = True
            picCurFishBadge.Image = My.Resources.SilverFishBadge
            picNextFishBadge.Visible = True
            picNextFishBadge.Image = My.Resources.GoldFishBadge
        ElseIf currentMayor.FishBadgeNum >= constant.GetFishBronze Then
            picCurFishBadge.Visible = True
            picCurFishBadge.Image = My.Resources.BronzeFishBadge
            picNextFishBadge.Visible = True
            picNextFishBadge.Image = My.Resources.SilverFishBadge
        Else
            picCurFishBadge.Visible = False
            picNextFishBadge.Visible = True
            picNextFishBadge.Image = My.Resources.BronzeFishBadge
        End If

        lblInsectCurrent.Text = insectCurrent.ToString("p0")
        lblInsectNext.Text = insectNext.ToString("p0")

        If currentMayor.InsectBadgeNum >= constant.GetInsectGold Then
            picCurInsectBadge.Visible = True
            picCurInsectBadge.Image = rleduc6_finalProject.My.Resources.GoldInsectBadge
            picNextInsectBadge.Visible = True
            picNextInsectBadge.Image = rleduc6_finalProject.My.Resources.GoldInsectBadge
        ElseIf currentMayor.InsectBadgeNum >= constant.GetInsectSilver Then
            picCurInsectBadge.Visible = True
            picCurInsectBadge.Image = rleduc6_finalProject.My.Resources.SilverInsectBadge
            picNextInsectBadge.Visible = True
            picNextInsectBadge.Image = rleduc6_finalProject.My.Resources.GoldInsectBadge
        ElseIf currentMayor.InsectBadgeNum >= constant.GetInsectBronze Then
            picCurInsectBadge.Visible = True
            picCurInsectBadge.Image = rleduc6_finalProject.My.Resources.BronzeInsectBadge
            picNextInsectBadge.Visible = True
            picNextInsectBadge.Image = rleduc6_finalProject.My.Resources.SilverInsectBadge
        Else
            picCurInsectBadge.Visible = False
            picNextInsectBadge.Visible = True
            picNextInsectBadge.Image = rleduc6_finalProject.My.Resources.BronzeInsectBadge
        End If

        lblSeafoodCurrent.Text = seafoodCurrent.ToString("p0")
        lblSeafoodNext.Text = seafoodNext.ToString("p0")

        If currentMayor.SeafoodBadgeNum >= constant.GetSeafoodGold Then
            picCurSeaBadge.Visible = True
            picCurSeaBadge.Image = rleduc6_finalProject.My.Resources.GoldSeafoodBadge
            picNextSeaBadge.Visible = True
            picNextSeaBadge.Image = rleduc6_finalProject.My.Resources.GoldSeafoodBadge
        ElseIf currentMayor.SeafoodBadgeNum >= constant.GetSeafoodSilver Then
            picCurSeaBadge.Visible = True
            picCurSeaBadge.Image = rleduc6_finalProject.My.Resources.SilverSeafoodBadge
            picNextSeaBadge.Visible = True
            picNextSeaBadge.Image = rleduc6_finalProject.My.Resources.GoldSeafoodBadge
        ElseIf currentMayor.SeafoodBadgeNum >= constant.GetSeafoodBronze Then
            picCurSeaBadge.Visible = True
            picCurSeaBadge.Image = rleduc6_finalProject.My.Resources.BronzeSeafoodBadge
            picNextSeaBadge.Visible = True
            picNextSeaBadge.Image = rleduc6_finalProject.My.Resources.SilverSeafoodBadge
        Else
            picCurSeaBadge.Visible = False
            picNextSeaBadge.Visible = True
            picNextSeaBadge.Image = rleduc6_finalProject.My.Resources.BronzeSeafoodBadge
        End If

    End Sub

    'Functions that display badge info when clicking on the badge name
    Private Sub lblFish_Click(sender As Object, e As EventArgs) Handles lblFish.Click
        pnlBadgeDescr.Visible = True
        lblBadgeName.Text = "Fish Badge"
        lblBadgeDescr.Text = "Awarded to players who complete a certain percentage of their Fish Encylopedia."
        lblBronzeLevel.Text = constant.GetFishBronze.ToString()
        lblSilverLevel.Text = constant.GetFishSilver.ToString()
        lblGoldLevel.Text = constant.GetFishGold.ToString()
        lblBronzeName.Text = "- Fish Maniac"
        lblSilverName.Text = "- Fish Encyclopedia"
        lblGoldName.Text = "- Prof. of Ichthyology"
    End Sub

    Private Sub lblSeafood_Click(sender As Object, e As EventArgs) Handles lblSeafood.Click
        pnlBadgeDescr.Visible = True
        lblBadgeName.Text = "Seafood Badge"
        lblBadgeDescr.Text = "Awarded to players who complete a certain percentage of their Seafood Encylopedia."
        lblBronzeLevel.Text = constant.GetSeafoodBronze.ToString()
        lblSilverLevel.Text = constant.GetSeafoodSilver.ToString()
        lblGoldLevel.Text = constant.GetSeafoodGold.ToString()
        lblBronzeName.Text = "- Seafood Maniac"
        lblSilverName.Text = "- Seafood Encyclopedia"
        lblGoldName.Text = "- Prof. of Seafood"
    End Sub

    Private Sub lblInsect_Click(sender As Object, e As EventArgs) Handles lblInsect.Click
        pnlBadgeDescr.Visible = True
        lblBadgeName.Text = "Insect Badge"
        lblBadgeDescr.Text = "Awarded to players who complete a certain percentage of their Insect Encylopedia."
        lblBronzeLevel.Text = constant.GetInsectBronze.ToString()
        lblSilverLevel.Text = constant.GetInsectSilver.ToString()
        lblGoldLevel.Text = constant.GetInsectGold.ToString()
        lblBronzeName.Text = "- Insect Maniac"
        lblSilverName.Text = "- Insect Encyclopedia"
        lblGoldName.Text = "- Prof. of Entomology"
    End Sub

    Private Sub lblCatalogue_Click(sender As Object, e As EventArgs) Handles lblCatalogue.Click
        pnlBadgeDescr.Visible = True
        lblBadgeName.Text = "Catalog Maniac Badge"
        lblBadgeDescr.Text = "Awarded to players who register a certain percentage of items in their Catalog."
        lblBronzeLevel.Text = constant.GetCatalogueBronze.ToString()
        lblSilverLevel.Text = constant.GetCatalogueSilver.ToString()
        lblGoldLevel.Text = constant.GetCatalogueGold.ToString()
        lblBronzeName.Text = "- Catalog Maniac Bronze"
        lblSilverName.Text = "- Catalog Maniac Silver"
        lblGoldName.Text = "- Catalog Maniac Gold"
    End Sub

    'Database functions
    Protected Friend Function connectToDb() As SqlConnection
        Dim connectionString = "Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=D:\Fall 2016\NET\rleduc6_finalProject\rleduc6_finalProject\MayorData2.mdf"
        Dim dbConnection As New SqlConnection(connectionString)
        dbConnection.Open()
        Return dbConnection
    End Function

    Private Sub populateMayor(row As DataRow)
        Dim dbMayor As New Mayor

        dbMayor.ID = CInt(row.Item("Id"))
        dbMayor.MayorName = row.Item("MayorName").ToString
        dbMayor.TownName = row.Item("MayorTown").ToString
        dbMayor.MayorInfo = row.Item("MayorInfo").ToString
        dbMayor.CatalogueBadgeNum = CInt(row.Item("CatalogueNum"))
        dbMayor.FishBadgeNum = CInt(row.Item("FishNum"))
        dbMayor.InsectBadgeNum = CInt(row.Item("InsectNum"))
        dbMayor.SeafoodBadgeNum = CInt(row.Item("SeafoodNum"))

        mayors.Add(dbMayor)
    End Sub

    Public Shared Sub populateRow(row As DataRow)
        row.Item("MayorName") = currentMayor.MayorName
        row.Item("MayorTown") = currentMayor.TownName
        row.Item("MayorInfo") = currentMayor.MayorInfo
        row.Item("CatalogueNum") = currentMayor.CatalogueBadgeNum
        row.Item("FishNum") = currentMayor.FishBadgeNum
        row.Item("InsectNum") = currentMayor.InsectBadgeNum
        row.Item("SeafoodNum") = currentMayor.SeafoodBadgeNum
    End Sub

End Class
