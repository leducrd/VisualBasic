<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.txtMayorName = New System.Windows.Forms.TextBox()
        Me.lblMayorName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTownName = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblMayorProgress = New System.Windows.Forms.Label()
        Me.gbxCollections = New System.Windows.Forms.GroupBox()
        Me.picNextCatBadge = New System.Windows.Forms.PictureBox()
        Me.picNextSeaBadge = New System.Windows.Forms.PictureBox()
        Me.picCurCatBadge = New System.Windows.Forms.PictureBox()
        Me.picCurSeaBadge = New System.Windows.Forms.PictureBox()
        Me.lblCatalogueNext = New System.Windows.Forms.Label()
        Me.lblCatalogueCurrent = New System.Windows.Forms.Label()
        Me.lblSeafoodNext = New System.Windows.Forms.Label()
        Me.lblSeafoodCurrent = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picNextInsectBadge = New System.Windows.Forms.PictureBox()
        Me.picCurInsectBadge = New System.Windows.Forms.PictureBox()
        Me.lblInsectNext = New System.Windows.Forms.Label()
        Me.lblInsectCurrent = New System.Windows.Forms.Label()
        Me.lblInsect = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFishNext = New System.Windows.Forms.Label()
        Me.picNextFishBadge = New System.Windows.Forms.PictureBox()
        Me.picCurFishBadge = New System.Windows.Forms.PictureBox()
        Me.lblFishCurrent = New System.Windows.Forms.Label()
        Me.lblFish = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblCatalogue = New System.Windows.Forms.Label()
        Me.lblSeafood = New System.Windows.Forms.Label()
        Me.btnEnterStats = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.gpbDescription = New System.Windows.Forms.GroupBox()
        Me.pnlBadgeDescr = New System.Windows.Forms.Panel()
        Me.lblGoldName = New System.Windows.Forms.Label()
        Me.lblBadgeName = New System.Windows.Forms.Label()
        Me.lblSilverName = New System.Windows.Forms.Label()
        Me.lblBadgeDescr = New System.Windows.Forms.Label()
        Me.lblBronzeName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblGoldLevel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSilverLevel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBronzeLevel = New System.Windows.Forms.Label()
        Me.gbxCollections.SuspendLayout()
        CType(Me.picNextCatBadge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNextSeaBadge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCurCatBadge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCurSeaBadge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.picNextInsectBadge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCurInsectBadge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picNextFishBadge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCurFishBadge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDescription.SuspendLayout()
        Me.pnlBadgeDescr.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(21, 296)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(172, 23)
        Me.btnExit.TabIndex = 35
        Me.btnExit.Text = "Exit Application"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label2.Font = New System.Drawing.Font("Eras Demi ITC", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Select User Collection"
        '
        'lstUsers
        '
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Location = New System.Drawing.Point(12, 159)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(189, 108)
        Me.lstUsers.TabIndex = 37
        '
        'lblNew
        '
        Me.lblNew.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.lblNew.Font = New System.Drawing.Font("Eras Demi ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(12, 9)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(189, 23)
        Me.lblNew.TabIndex = 38
        Me.lblNew.Text = "Create New Mayor"
        '
        'txtMayorName
        '
        Me.txtMayorName.Location = New System.Drawing.Point(89, 42)
        Me.txtMayorName.Name = "txtMayorName"
        Me.txtMayorName.Size = New System.Drawing.Size(100, 20)
        Me.txtMayorName.TabIndex = 39
        '
        'lblMayorName
        '
        Me.lblMayorName.AutoSize = True
        Me.lblMayorName.Location = New System.Drawing.Point(14, 45)
        Me.lblMayorName.Name = "lblMayorName"
        Me.lblMayorName.Size = New System.Drawing.Size(70, 13)
        Me.lblMayorName.TabIndex = 40
        Me.lblMayorName.Text = "Mayor Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Town Name:"
        '
        'txtTownName
        '
        Me.txtTownName.Location = New System.Drawing.Point(89, 68)
        Me.txtTownName.Name = "txtTownName"
        Me.txtTownName.Size = New System.Drawing.Size(100, 20)
        Me.txtTownName.TabIndex = 42
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(72, 94)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 43
        Me.btnCreate.Text = "Create!"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblMayorProgress
        '
        Me.lblMayorProgress.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.lblMayorProgress.Font = New System.Drawing.Font("Eras Demi ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMayorProgress.Location = New System.Drawing.Point(212, 9)
        Me.lblMayorProgress.Name = "lblMayorProgress"
        Me.lblMayorProgress.Size = New System.Drawing.Size(383, 23)
        Me.lblMayorProgress.TabIndex = 45
        Me.lblMayorProgress.Text = "Badge Progress"
        '
        'gbxCollections
        '
        Me.gbxCollections.Controls.Add(Me.picNextCatBadge)
        Me.gbxCollections.Controls.Add(Me.picNextSeaBadge)
        Me.gbxCollections.Controls.Add(Me.picCurCatBadge)
        Me.gbxCollections.Controls.Add(Me.picCurSeaBadge)
        Me.gbxCollections.Controls.Add(Me.lblCatalogueNext)
        Me.gbxCollections.Controls.Add(Me.lblCatalogueCurrent)
        Me.gbxCollections.Controls.Add(Me.lblSeafoodNext)
        Me.gbxCollections.Controls.Add(Me.lblSeafoodCurrent)
        Me.gbxCollections.Controls.Add(Me.Panel3)
        Me.gbxCollections.Controls.Add(Me.Panel1)
        Me.gbxCollections.Controls.Add(Me.Label28)
        Me.gbxCollections.Controls.Add(Me.Label27)
        Me.gbxCollections.Controls.Add(Me.lblCatalogue)
        Me.gbxCollections.Controls.Add(Me.lblSeafood)
        Me.gbxCollections.Location = New System.Drawing.Point(211, 35)
        Me.gbxCollections.Name = "gbxCollections"
        Me.gbxCollections.Size = New System.Drawing.Size(236, 123)
        Me.gbxCollections.TabIndex = 46
        Me.gbxCollections.TabStop = False
        Me.gbxCollections.Text = "Collections"
        '
        'picNextCatBadge
        '
        Me.picNextCatBadge.Image = Global.rleduc6_finalProject.My.Resources.Resources.BronzeCatalogueBadge
        Me.picNextCatBadge.Location = New System.Drawing.Point(207, 99)
        Me.picNextCatBadge.Name = "picNextCatBadge"
        Me.picNextCatBadge.Size = New System.Drawing.Size(20, 20)
        Me.picNextCatBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picNextCatBadge.TabIndex = 66
        Me.picNextCatBadge.TabStop = False
        Me.picNextCatBadge.Visible = False
        '
        'picNextSeaBadge
        '
        Me.picNextSeaBadge.Image = Global.rleduc6_finalProject.My.Resources.Resources.BronzeSeafoodBadge
        Me.picNextSeaBadge.Location = New System.Drawing.Point(206, 51)
        Me.picNextSeaBadge.Name = "picNextSeaBadge"
        Me.picNextSeaBadge.Size = New System.Drawing.Size(20, 20)
        Me.picNextSeaBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picNextSeaBadge.TabIndex = 62
        Me.picNextSeaBadge.TabStop = False
        Me.picNextSeaBadge.Visible = False
        '
        'picCurCatBadge
        '
        Me.picCurCatBadge.Image = Global.rleduc6_finalProject.My.Resources.Resources.BronzeCatalogueBadge
        Me.picCurCatBadge.Location = New System.Drawing.Point(131, 99)
        Me.picCurCatBadge.Name = "picCurCatBadge"
        Me.picCurCatBadge.Size = New System.Drawing.Size(20, 20)
        Me.picCurCatBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCurCatBadge.TabIndex = 65
        Me.picCurCatBadge.TabStop = False
        Me.picCurCatBadge.Visible = False
        '
        'picCurSeaBadge
        '
        Me.picCurSeaBadge.Image = Global.rleduc6_finalProject.My.Resources.Resources.BronzeSeafoodBadge
        Me.picCurSeaBadge.Location = New System.Drawing.Point(131, 51)
        Me.picCurSeaBadge.Name = "picCurSeaBadge"
        Me.picCurSeaBadge.Size = New System.Drawing.Size(20, 20)
        Me.picCurSeaBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCurSeaBadge.TabIndex = 54
        Me.picCurSeaBadge.TabStop = False
        Me.picCurSeaBadge.Visible = False
        '
        'lblCatalogueNext
        '
        Me.lblCatalogueNext.AutoSize = True
        Me.lblCatalogueNext.Location = New System.Drawing.Point(171, 102)
        Me.lblCatalogueNext.Name = "lblCatalogueNext"
        Me.lblCatalogueNext.Size = New System.Drawing.Size(33, 13)
        Me.lblCatalogueNext.TabIndex = 61
        Me.lblCatalogueNext.Text = "100%"
        '
        'lblCatalogueCurrent
        '
        Me.lblCatalogueCurrent.AutoSize = True
        Me.lblCatalogueCurrent.Location = New System.Drawing.Point(96, 102)
        Me.lblCatalogueCurrent.Name = "lblCatalogueCurrent"
        Me.lblCatalogueCurrent.Size = New System.Drawing.Size(33, 13)
        Me.lblCatalogueCurrent.TabIndex = 60
        Me.lblCatalogueCurrent.Text = "100%"
        '
        'lblSeafoodNext
        '
        Me.lblSeafoodNext.AutoSize = True
        Me.lblSeafoodNext.Location = New System.Drawing.Point(171, 55)
        Me.lblSeafoodNext.Name = "lblSeafoodNext"
        Me.lblSeafoodNext.Size = New System.Drawing.Size(33, 13)
        Me.lblSeafoodNext.TabIndex = 54
        Me.lblSeafoodNext.Text = "100%"
        '
        'lblSeafoodCurrent
        '
        Me.lblSeafoodCurrent.AutoSize = True
        Me.lblSeafoodCurrent.Location = New System.Drawing.Point(96, 55)
        Me.lblSeafoodCurrent.Name = "lblSeafoodCurrent"
        Me.lblSeafoodCurrent.Size = New System.Drawing.Size(33, 13)
        Me.lblSeafoodCurrent.TabIndex = 54
        Me.lblSeafoodCurrent.Text = "100%"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.picNextInsectBadge)
        Me.Panel3.Controls.Add(Me.picCurInsectBadge)
        Me.Panel3.Controls.Add(Me.lblInsectNext)
        Me.Panel3.Controls.Add(Me.lblInsectCurrent)
        Me.Panel3.Controls.Add(Me.lblInsect)
        Me.Panel3.Location = New System.Drawing.Point(1, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(234, 24)
        Me.Panel3.TabIndex = 56
        '
        'picNextInsectBadge
        '
        Me.picNextInsectBadge.Image = Global.rleduc6_finalProject.My.Resources.Resources.BronzeInsectBadge
        Me.picNextInsectBadge.Location = New System.Drawing.Point(205, 2)
        Me.picNextInsectBadge.Name = "picNextInsectBadge"
        Me.picNextInsectBadge.Size = New System.Drawing.Size(20, 20)
        Me.picNextInsectBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picNextInsectBadge.TabIndex = 64
        Me.picNextInsectBadge.TabStop = False
        Me.picNextInsectBadge.Visible = False
        '
        'picCurInsectBadge
        '
        Me.picCurInsectBadge.Image = Global.rleduc6_finalProject.My.Resources.Resources.BronzeInsectBadge
        Me.picCurInsectBadge.Location = New System.Drawing.Point(130, 2)
        Me.picCurInsectBadge.Name = "picCurInsectBadge"
        Me.picCurInsectBadge.Size = New System.Drawing.Size(20, 20)
        Me.picCurInsectBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCurInsectBadge.TabIndex = 63
        Me.picCurInsectBadge.TabStop = False
        Me.picCurInsectBadge.Visible = False
        '
        'lblInsectNext
        '
        Me.lblInsectNext.AutoSize = True
        Me.lblInsectNext.Location = New System.Drawing.Point(170, 5)
        Me.lblInsectNext.Name = "lblInsectNext"
        Me.lblInsectNext.Size = New System.Drawing.Size(33, 13)
        Me.lblInsectNext.TabIndex = 59
        Me.lblInsectNext.Text = "100%"
        '
        'lblInsectCurrent
        '
        Me.lblInsectCurrent.AutoSize = True
        Me.lblInsectCurrent.Location = New System.Drawing.Point(95, 5)
        Me.lblInsectCurrent.Name = "lblInsectCurrent"
        Me.lblInsectCurrent.Size = New System.Drawing.Size(33, 13)
        Me.lblInsectCurrent.TabIndex = 59
        Me.lblInsectCurrent.Text = "100%"
        '
        'lblInsect
        '
        Me.lblInsect.Location = New System.Drawing.Point(3, 2)
        Me.lblInsect.Name = "lblInsect"
        Me.lblInsect.Size = New System.Drawing.Size(96, 20)
        Me.lblInsect.TabIndex = 47
        Me.lblInsect.Text = "Insect"
        Me.lblInsect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.lblFishNext)
        Me.Panel1.Controls.Add(Me.picNextFishBadge)
        Me.Panel1.Controls.Add(Me.picCurFishBadge)
        Me.Panel1.Controls.Add(Me.lblFishCurrent)
        Me.Panel1.Controls.Add(Me.lblFish)
        Me.Panel1.Location = New System.Drawing.Point(1, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 24)
        Me.Panel1.TabIndex = 54
        '
        'lblFishNext
        '
        Me.lblFishNext.AutoSize = True
        Me.lblFishNext.Location = New System.Drawing.Point(170, 6)
        Me.lblFishNext.Name = "lblFishNext"
        Me.lblFishNext.Size = New System.Drawing.Size(33, 13)
        Me.lblFishNext.TabIndex = 53
        Me.lblFishNext.Text = "100%"
        '
        'picNextFishBadge
        '
        Me.picNextFishBadge.Image = Global.rleduc6_finalProject.My.Resources.Resources.BronzeFishBadge
        Me.picNextFishBadge.Location = New System.Drawing.Point(204, 1)
        Me.picNextFishBadge.Name = "picNextFishBadge"
        Me.picNextFishBadge.Size = New System.Drawing.Size(22, 22)
        Me.picNextFishBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picNextFishBadge.TabIndex = 52
        Me.picNextFishBadge.TabStop = False
        Me.picNextFishBadge.Visible = False
        '
        'picCurFishBadge
        '
        Me.picCurFishBadge.Image = Global.rleduc6_finalProject.My.Resources.Resources.BronzeFishBadge
        Me.picCurFishBadge.Location = New System.Drawing.Point(129, 1)
        Me.picCurFishBadge.Name = "picCurFishBadge"
        Me.picCurFishBadge.Size = New System.Drawing.Size(22, 22)
        Me.picCurFishBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCurFishBadge.TabIndex = 49
        Me.picCurFishBadge.TabStop = False
        Me.picCurFishBadge.Visible = False
        '
        'lblFishCurrent
        '
        Me.lblFishCurrent.AutoSize = True
        Me.lblFishCurrent.Location = New System.Drawing.Point(95, 6)
        Me.lblFishCurrent.Name = "lblFishCurrent"
        Me.lblFishCurrent.Size = New System.Drawing.Size(33, 13)
        Me.lblFishCurrent.TabIndex = 50
        Me.lblFishCurrent.Text = "100%"
        '
        'lblFish
        '
        Me.lblFish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFish.Location = New System.Drawing.Point(3, 1)
        Me.lblFish.Name = "lblFish"
        Me.lblFish.Size = New System.Drawing.Size(96, 20)
        Me.lblFish.TabIndex = 0
        Me.lblFish.Text = "Fish"
        Me.lblFish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(171, 10)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(29, 13)
        Me.Label28.TabIndex = 53
        Me.Label28.Text = "Next"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(93, 10)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 13)
        Me.Label27.TabIndex = 51
        Me.Label27.Text = "Current"
        '
        'lblCatalogue
        '
        Me.lblCatalogue.Location = New System.Drawing.Point(4, 100)
        Me.lblCatalogue.Name = "lblCatalogue"
        Me.lblCatalogue.Size = New System.Drawing.Size(96, 20)
        Me.lblCatalogue.TabIndex = 48
        Me.lblCatalogue.Text = "Catalogue"
        Me.lblCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSeafood
        '
        Me.lblSeafood.Location = New System.Drawing.Point(4, 51)
        Me.lblSeafood.Name = "lblSeafood"
        Me.lblSeafood.Size = New System.Drawing.Size(96, 20)
        Me.lblSeafood.TabIndex = 1
        Me.lblSeafood.Text = "Seafood"
        Me.lblSeafood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEnterStats
        '
        Me.btnEnterStats.Location = New System.Drawing.Point(21, 270)
        Me.btnEnterStats.Name = "btnEnterStats"
        Me.btnEnterStats.Size = New System.Drawing.Size(83, 23)
        Me.btnEnterStats.TabIndex = 52
        Me.btnEnterStats.Text = "Enter Stats"
        Me.btnEnterStats.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(110, 270)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(83, 23)
        Me.btnDelete.TabIndex = 53
        Me.btnDelete.Text = "Delete Mayor"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'gpbDescription
        '
        Me.gpbDescription.Controls.Add(Me.pnlBadgeDescr)
        Me.gpbDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbDescription.Location = New System.Drawing.Point(212, 164)
        Me.gpbDescription.Name = "gpbDescription"
        Me.gpbDescription.Size = New System.Drawing.Size(383, 134)
        Me.gpbDescription.TabIndex = 54
        Me.gpbDescription.TabStop = False
        Me.gpbDescription.Text = "Badge Description"
        '
        'pnlBadgeDescr
        '
        Me.pnlBadgeDescr.Controls.Add(Me.lblGoldName)
        Me.pnlBadgeDescr.Controls.Add(Me.lblBadgeName)
        Me.pnlBadgeDescr.Controls.Add(Me.lblSilverName)
        Me.pnlBadgeDescr.Controls.Add(Me.lblBadgeDescr)
        Me.pnlBadgeDescr.Controls.Add(Me.lblBronzeName)
        Me.pnlBadgeDescr.Controls.Add(Me.Label3)
        Me.pnlBadgeDescr.Controls.Add(Me.lblGoldLevel)
        Me.pnlBadgeDescr.Controls.Add(Me.Label4)
        Me.pnlBadgeDescr.Controls.Add(Me.lblSilverLevel)
        Me.pnlBadgeDescr.Controls.Add(Me.Label5)
        Me.pnlBadgeDescr.Controls.Add(Me.lblBronzeLevel)
        Me.pnlBadgeDescr.Location = New System.Drawing.Point(3, 19)
        Me.pnlBadgeDescr.Name = "pnlBadgeDescr"
        Me.pnlBadgeDescr.Size = New System.Drawing.Size(378, 113)
        Me.pnlBadgeDescr.TabIndex = 11
        Me.pnlBadgeDescr.Visible = False
        '
        'lblGoldName
        '
        Me.lblGoldName.AutoSize = True
        Me.lblGoldName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoldName.Location = New System.Drawing.Point(158, 92)
        Me.lblGoldName.Name = "lblGoldName"
        Me.lblGoldName.Size = New System.Drawing.Size(115, 15)
        Me.lblGoldName.TabIndex = 10
        Me.lblGoldName.Text = "- Prof. of Ichthyology"
        '
        'lblBadgeName
        '
        Me.lblBadgeName.AutoSize = True
        Me.lblBadgeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBadgeName.Location = New System.Drawing.Point(3, 2)
        Me.lblBadgeName.Name = "lblBadgeName"
        Me.lblBadgeName.Size = New System.Drawing.Size(55, 16)
        Me.lblBadgeName.TabIndex = 0
        Me.lblBadgeName.Text = "Label3"
        '
        'lblSilverName
        '
        Me.lblSilverName.AutoSize = True
        Me.lblSilverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilverName.Location = New System.Drawing.Point(158, 74)
        Me.lblSilverName.Name = "lblSilverName"
        Me.lblSilverName.Size = New System.Drawing.Size(113, 15)
        Me.lblSilverName.TabIndex = 9
        Me.lblSilverName.Text = "- Fish Encyclopedia"
        '
        'lblBadgeDescr
        '
        Me.lblBadgeDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBadgeDescr.Location = New System.Drawing.Point(6, 22)
        Me.lblBadgeDescr.Name = "lblBadgeDescr"
        Me.lblBadgeDescr.Size = New System.Drawing.Size(368, 30)
        Me.lblBadgeDescr.TabIndex = 1
        Me.lblBadgeDescr.Text = "Awarded to players who complete a certain percentage of their Fish Encylopedia."
        '
        'lblBronzeName
        '
        Me.lblBronzeName.AutoSize = True
        Me.lblBronzeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBronzeName.Location = New System.Drawing.Point(158, 56)
        Me.lblBronzeName.Name = "lblBronzeName"
        Me.lblBronzeName.Size = New System.Drawing.Size(81, 15)
        Me.lblBronzeName.TabIndex = 8
        Me.lblBronzeName.Text = "- Fish Maniac"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(9, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bronze Level: "
        '
        'lblGoldLevel
        '
        Me.lblGoldLevel.AutoSize = True
        Me.lblGoldLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoldLevel.Location = New System.Drawing.Point(113, 92)
        Me.lblGoldLevel.Name = "lblGoldLevel"
        Me.lblGoldLevel.Size = New System.Drawing.Size(39, 15)
        Me.lblGoldLevel.TabIndex = 7
        Me.lblGoldLevel.Text = "100%"
        Me.lblGoldLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(9, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Silver Level: "
        '
        'lblSilverLevel
        '
        Me.lblSilverLevel.AutoSize = True
        Me.lblSilverLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilverLevel.Location = New System.Drawing.Point(113, 74)
        Me.lblSilverLevel.Name = "lblSilverLevel"
        Me.lblSilverLevel.Size = New System.Drawing.Size(39, 15)
        Me.lblSilverLevel.TabIndex = 6
        Me.lblSilverLevel.Text = "100%"
        Me.lblSilverLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label5.Location = New System.Drawing.Point(9, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gold Level: "
        '
        'lblBronzeLevel
        '
        Me.lblBronzeLevel.AutoSize = True
        Me.lblBronzeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBronzeLevel.Location = New System.Drawing.Point(113, 56)
        Me.lblBronzeLevel.Name = "lblBronzeLevel"
        Me.lblBronzeLevel.Size = New System.Drawing.Size(39, 15)
        Me.lblBronzeLevel.TabIndex = 5
        Me.lblBronzeLevel.Text = "100%"
        Me.lblBronzeLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 323)
        Me.Controls.Add(Me.gpbDescription)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEnterStats)
        Me.Controls.Add(Me.gbxCollections)
        Me.Controls.Add(Me.lblMayorProgress)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtTownName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMayorName)
        Me.Controls.Add(Me.txtMayorName)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lstUsers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "FormMain"
        Me.Text = "ACNL Record Keeper"
        Me.gbxCollections.ResumeLayout(False)
        Me.gbxCollections.PerformLayout()
        CType(Me.picNextCatBadge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNextSeaBadge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCurCatBadge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCurSeaBadge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.picNextInsectBadge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCurInsectBadge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picNextFishBadge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCurFishBadge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDescription.ResumeLayout(False)
        Me.pnlBadgeDescr.ResumeLayout(False)
        Me.pnlBadgeDescr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lstUsers As ListBox
    Friend WithEvents lblNew As Label
    Friend WithEvents txtMayorName As TextBox
    Friend WithEvents lblMayorName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTownName As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents lblMayorProgress As Label
    Friend WithEvents gbxCollections As GroupBox
    Friend WithEvents lblCatalogue As Label
    Friend WithEvents lblSeafood As Label
    Friend WithEvents lblFish As Label
    Friend WithEvents btnEnterStats As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFishCurrent As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblInsect As Label
    Friend WithEvents lblFishNext As Label
    Friend WithEvents lblCatalogueNext As Label
    Friend WithEvents lblCatalogueCurrent As Label
    Friend WithEvents lblSeafoodNext As Label
    Friend WithEvents lblSeafoodCurrent As Label
    Friend WithEvents lblInsectNext As Label
    Friend WithEvents lblInsectCurrent As Label
    Friend WithEvents picNextFishBadge As PictureBox
    Friend WithEvents picCurFishBadge As PictureBox
    Friend WithEvents gpbDescription As GroupBox
    Friend WithEvents lblBadgeName As Label
    Friend WithEvents lblBadgeDescr As Label
    Friend WithEvents lblBronzeLevel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblGoldLevel As Label
    Friend WithEvents lblSilverLevel As Label
    Friend WithEvents pnlBadgeDescr As Panel
    Friend WithEvents lblGoldName As Label
    Friend WithEvents lblSilverName As Label
    Friend WithEvents lblBronzeName As Label
    Friend WithEvents picNextSeaBadge As PictureBox
    Friend WithEvents picCurSeaBadge As PictureBox
    Friend WithEvents picNextInsectBadge As PictureBox
    Friend WithEvents picCurInsectBadge As PictureBox
    Friend WithEvents picNextCatBadge As PictureBox
    Friend WithEvents picCurCatBadge As PictureBox
End Class
