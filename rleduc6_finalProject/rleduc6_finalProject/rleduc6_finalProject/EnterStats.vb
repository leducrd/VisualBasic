Imports System.Data.SqlClient

Public Class EnterStats
    Dim isLoading As Boolean = True
    Dim seafoodID As Integer
    Private dsSeafoodHave As New DataSet("SeafoodHave")
    'Private dsSeafoodList As New DataSet("SeafoodList")
    Private Sub EnterStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMayorDisp.Text = FormMain.currentMayor.MayorInfo
        txtCatalogueBadge.Text = FormMain.currentMayor.CatalogueBadgeNum.ToString
        txtFishBadge.Text = FormMain.currentMayor.FishBadgeNum.ToString
        txtInsectBadge.Text = FormMain.currentMayor.InsectBadgeNum.ToString
        txtSeafoodBadge.Text = FormMain.currentMayor.SeafoodBadgeNum.ToString

        'to load the Mayor_Seafood and Seafood Tables
        Dim dbConnection As SqlConnection = FormMain.connectToDb()
        'Loads the Seafood Table
        'Dim daSeafood As New SqlDataAdapter("SELECT * FROM Seafood", dbConnection)
        'daSeafood.FillSchema(dsSeafoodList, SchemaType.Source, "Seafood")
        'daSeafood.Fill(dsSeafoodList, "Seafood")
        'Loads the Mayor_Seafood table
        Dim daMayorSea As New SqlDataAdapter("SELECT * FROM Mayor_Seafood", dbConnection)
        daMayorSea.FillSchema(dsSeafoodHave, SchemaType.Source, "Mayor_Seafood")
        daMayorSea.Fill(dsSeafoodHave, "Mayor_Seafood")

        'create shortcuts for the two datasets
        'Dim SeafoodTable As DataTable = dsSeafoodList.Tables("Seafood")
        Dim Mayor_SeafoodTable As DataTable = dsSeafoodHave.Tables("Mayor_Seafood")

        For Each row As DataRow In Mayor_SeafoodTable.Rows
            PopCheckBoxes(row)
            ' Code running after this sub doesn't work
        Next

        dbConnection.Close()
        dbConnection.Dispose()

        isLoading = False
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim dbConnection As SqlConnection = FormMain.connectToDb()
        Dim daMayor As New SqlDataAdapter("SELECT * FROM Mayor", dbConnection)
        Dim builder As New SqlCommandBuilder(daMayor)
        daMayor.UpdateCommand = builder.GetUpdateCommand

        Dim mayorTable As DataTable = FormMain.dsMayor.Tables("Mayor")
        Dim mayorRow As DataRow

        Try
            FormMain.currentMayor.CatalogueBadgeNum = CInt(txtCatalogueBadge.Text)
        Catch ex As Exception
            MessageBox.Show("Please only enter whole, postitive numbers. Please enter your Catalogue number again.")
            Me.Close()
        End Try

        Try
            FormMain.currentMayor.FishBadgeNum = CInt(txtFishBadge.Text)
        Catch ex As Exception
            MessageBox.Show("Please only enter whole, postitive numbers. Please enter your Fish number again.")
            Me.Close()
        End Try

        Try
            FormMain.currentMayor.InsectBadgeNum = CInt(txtInsectBadge.Text)
        Catch ex As Exception
            MessageBox.Show("Please only enter whole, postitive numbers. Please enter your Insect number again.")
            Me.Close()
        End Try

        Try
            FormMain.currentMayor.SeafoodBadgeNum = CInt(txtSeafoodBadge.Text)
        Catch ex As Exception
            MessageBox.Show("Please only enter whole, postitive numbers. Please enter your Seafood number again.")
            Me.Close()
        End Try

        'find the correct row to update
        mayorRow = mayorTable.Rows.Find(FormMain.currentMayor.ID)

        'populate the character table row
        FormMain.populateRow(mayorRow)
        daMayor.Update(FormMain.dsMayor, "Mayor")
        FormMain.DisplayMayorInfo()
        Me.Close()
    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub populateRow(row As DataRow, seafoodID As Integer)
        row.Item("mayorId") = FormMain.currentMayor.ID
        row.Item("seafoodId") = seafoodID
    End Sub

    Private Sub PopCheckBoxes(row As DataRow)

        If CInt(row.Item("mayorId")) = FormMain.currentMayor.ID Then

            If CInt(row.Item("seafoodId")) = 1 Then
                chkSeafood1.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 2 Then
                chkSeafood2.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 3 Then
                chkSeafood3.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 4 Then
                chkSeafood4.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 5 Then
                chkSeafood5.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 6 Then
                chkSeafood6.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 7 Then
                chkSeafood7.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 8 Then
                chkSeafood8.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 9 Then
                chkSeafood9.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 10 Then
                chkSeafood10.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 11 Then
                chkSeafood11.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 12 Then
                chkSeafood12.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 13 Then
                chkSeafood13.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 14 Then
                chkSeafood14.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 15 Then
                chkSeafood15.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 16 Then
                chkSeafood16.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 17 Then
                chkSeafood17.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 18 Then
                chkSeafood18.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 19 Then
                chkSeafood19.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 20 Then
                chkSeafood20.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 21 Then
                chkSeafood21.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 22 Then
                chkSeafood22.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 23 Then
                chkSeafood23.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 24 Then
                chkSeafood24.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 25 Then
                chkSeafood25.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 26 Then
                chkSeafood26.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 27 Then
                chkSeafood27.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 28 Then
                chkSeafood28.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 29 Then
                chkSeafood29.Checked = True
            ElseIf CInt(row.Item("seafoodId")) = 30 Then
                chkSeafood30.Checked = True
            End If

        End If

    End Sub

    Private Sub CheckBoxDbCon(ByRef checkBox As Object, ByVal seafoodID As Integer)
        Dim dbConnection As SqlConnection = FormMain.connectToDb()
        Dim daMayorSea As New SqlDataAdapter("SELECT * FROM Mayor_Seafood", dbConnection)
        'daMayorSea.FillSchema(dsSeafoodHave, SchemaType.Source, "Mayor_Seafood")
        'daMayorSea.Fill(dsSeafoodHave, "Mayor_Seafood")
        Dim builder As New SqlCommandBuilder(daMayorSea)
        daMayorSea.InsertCommand = builder.GetInsertCommand
        daMayorSea.DeleteCommand = builder.GetDeleteCommand
        Dim Mayor_SeafoodTable As DataTable = dsSeafoodHave.Tables("Mayor_Seafood")
        Dim mayorSeafoodRow As DataRow

        If checkBox.Checked Then
            'add mayorID, seafoodID row to Mayor_Seafood table
            mayorSeafoodRow = Mayor_SeafoodTable.NewRow
            populateRow(mayorSeafoodRow, seafoodID)
            Mayor_SeafoodTable.Rows.Add(mayorSeafoodRow)
            daMayorSea.Update(dsSeafoodHave, "Mayor_Seafood")
        Else
            'search DB where MayorID = currentMayorID and seafoodId = (seafood number)
            'delete row
            Dim keys As Object() = {FormMain.currentMayor.ID, seafoodID}
            Mayor_SeafoodTable.Rows.Find(keys).Delete()
            daMayorSea.Update(dsSeafoodHave, "Mayor_Seafood")
            'MessageBox.Show(row.Item(0), row.Item(1))
        End If
        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub chkSeafood1_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood1.CheckedChanged
        If isLoading = False Then
            seafoodID = 1
            CheckBoxDbCon(chkSeafood1, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood2_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood2.CheckedChanged
        If isLoading = False Then
            seafoodID = 2
            CheckBoxDbCon(chkSeafood2, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood3_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood3.CheckedChanged
        If isLoading = False Then
            seafoodID = 3
            CheckBoxDbCon(chkSeafood3, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood4_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood4.CheckedChanged
        If isLoading = False Then
            seafoodID = 4
            CheckBoxDbCon(chkSeafood4, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood5_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood5.CheckedChanged
        If isLoading = False Then
            seafoodID = 5
            CheckBoxDbCon(chkSeafood5, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood6_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood6.CheckedChanged
        If isLoading = False Then
            seafoodID = 6
            CheckBoxDbCon(chkSeafood6, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood7_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood7.CheckedChanged
        If isLoading = False Then
            seafoodID = 7
            CheckBoxDbCon(chkSeafood7, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood8_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood8.CheckedChanged
        If isLoading = False Then
            seafoodID = 8
            CheckBoxDbCon(chkSeafood8, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood9_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood9.CheckedChanged
        If isLoading = False Then
            seafoodID = 9
            CheckBoxDbCon(chkSeafood9, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood10_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood10.CheckedChanged
        If isLoading = False Then
            seafoodID = 10
            CheckBoxDbCon(chkSeafood10, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood11_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood11.CheckedChanged
        If isLoading = False Then
            seafoodID = 11
            CheckBoxDbCon(chkSeafood11, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood12_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood12.CheckedChanged
        If isLoading = False Then
            seafoodID = 12
            CheckBoxDbCon(chkSeafood12, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood13_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood13.CheckedChanged
        If isLoading = False Then
            seafoodID = 13
            CheckBoxDbCon(chkSeafood13, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood14_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood14.CheckedChanged
        If isLoading = False Then
            seafoodID = 14
            CheckBoxDbCon(chkSeafood14, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood15_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood15.CheckedChanged
        If isLoading = False Then
            seafoodID = 15
            CheckBoxDbCon(chkSeafood15, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood16_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood16.CheckedChanged
        If isLoading = False Then
            seafoodID = 16
            CheckBoxDbCon(chkSeafood16, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood17_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood17.CheckedChanged
        If isLoading = False Then
            seafoodID = 17
            CheckBoxDbCon(chkSeafood17, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood18_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood18.CheckedChanged
        If isLoading = False Then
            seafoodID = 18
            CheckBoxDbCon(chkSeafood18, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood19_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood19.CheckedChanged
        If isLoading = False Then
            seafoodID = 19
            CheckBoxDbCon(chkSeafood19, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood20_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood20.CheckedChanged
        If isLoading = False Then
            seafoodID = 20
            CheckBoxDbCon(chkSeafood20, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood21_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood21.CheckedChanged
        If isLoading = False Then
            seafoodID = 21
            CheckBoxDbCon(chkSeafood21, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood22_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood22.CheckedChanged
        If isLoading = False Then
            seafoodID = 22
            CheckBoxDbCon(chkSeafood22, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood23_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood23.CheckedChanged
        If isLoading = False Then
            seafoodID = 23
            CheckBoxDbCon(chkSeafood23, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood24_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood24.CheckedChanged
        If isLoading = False Then
            seafoodID = 24
            CheckBoxDbCon(chkSeafood24, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood25_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood25.CheckedChanged
        If isLoading = False Then
            seafoodID = 25
            CheckBoxDbCon(chkSeafood25, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood26_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood26.CheckedChanged
        If isLoading = False Then
            seafoodID = 26
            CheckBoxDbCon(chkSeafood26, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood27_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood27.CheckedChanged
        If isLoading = False Then
            seafoodID = 27
            CheckBoxDbCon(chkSeafood27, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood28_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood28.CheckedChanged
        If isLoading = False Then
            seafoodID = 28
            CheckBoxDbCon(chkSeafood28, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood29_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood29.CheckedChanged
        If isLoading = False Then
            seafoodID = 29
            CheckBoxDbCon(chkSeafood29, seafoodID)
        End If
    End Sub

    Private Sub chkSeafood30_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeafood30.CheckedChanged
        If isLoading = False Then
            seafoodID = 30
            CheckBoxDbCon(chkSeafood30, seafoodID)
        End If
    End Sub
End Class