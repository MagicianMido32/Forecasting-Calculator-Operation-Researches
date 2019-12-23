<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.VisualStudioContainer1 = New Forecast.VisualStudioContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLMAD = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New Forecast.VisualStudioButton()
        Me.Tabz = New Forecast.VisualStudioTabControl()
        Me.Tabnaive = New System.Windows.Forms.TabPage()
        Me.Grdnaieve = New System.Windows.Forms.DataGridView()
        Me.clmname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmdemand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmforecast = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAbsError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabmovingAverage = New System.Windows.Forms.TabPage()
        Me.GrdMovingA = New System.Windows.Forms.DataGridView()
        Me.clmNameMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDemandMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPeriodsMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmForecastMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmErrorMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAbsErrorMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabwightedMoving = New System.Windows.Forms.TabPage()
        Me.GrdWightedMovingA = New System.Windows.Forms.DataGridView()
        Me.clmNameWMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDemandWMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPeriodsWMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmForecastWMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmErrorWMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAbsErrorWMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabExponenSmooth = New System.Windows.Forms.TabPage()
        Me.LBLEnterForecast = New System.Windows.Forms.Label()
        Me.LbLEnterA = New System.Windows.Forms.Label()
        Me.TxtAlpha = New Forecast.VisualStudioNormalTextBox()
        Me.GrdExponSmooth = New System.Windows.Forms.DataGridView()
        Me.clmNameEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDemandEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmForecastEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmErrorEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAbsErrorEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabAdjExponSmoth = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbLBetaAdj = New System.Windows.Forms.Label()
        Me.txtBetaAdj = New Forecast.VisualStudioNormalTextBox()
        Me.LbLEnterAdj = New System.Windows.Forms.Label()
        Me.LbLAlphaAdj = New System.Windows.Forms.Label()
        Me.txtAlphaAdj = New Forecast.VisualStudioNormalTextBox()
        Me.GrdAdjExponential = New System.Windows.Forms.DataGridView()
        Me.clmNameAdjEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDemandAdjEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTrendAdjEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmForecastAdjEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAdjForecastAdjEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmErrorAdjEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAbsErrorAdjEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabRegression = New System.Windows.Forms.TabPage()
        Me.GrdRegression = New System.Windows.Forms.DataGridView()
        Me.clmNameRg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDemandRg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPeriodsRg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmForecastRg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmErrorRg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAbsErrorRg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabSeasonAdj = New System.Windows.Forms.TabPage()
        Me.LblFocus = New System.Windows.Forms.Label()
        Me.VisualStudioStatusBar1 = New Forecast.VisualStudioStatusBar()
        Me.BtnForecast = New Forecast.VisualStudioButton()
        Me.VisualStudioContainer1.SuspendLayout()
        Me.Tabz.SuspendLayout()
        Me.Tabnaive.SuspendLayout()
        CType(Me.Grdnaieve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabmovingAverage.SuspendLayout()
        CType(Me.GrdMovingA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabwightedMoving.SuspendLayout()
        CType(Me.GrdWightedMovingA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabExponenSmooth.SuspendLayout()
        CType(Me.GrdExponSmooth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAdjExponSmoth.SuspendLayout()
        CType(Me.GrdAdjExponential, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabRegression.SuspendLayout()
        CType(Me.GrdRegression, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisualStudioContainer1
        '
        Me.VisualStudioContainer1.AllowClose = True
        Me.VisualStudioContainer1.AllowMaximize = False
        Me.VisualStudioContainer1.AllowMinimize = True
        Me.VisualStudioContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.VisualStudioContainer1.Controls.Add(Me.Label4)
        Me.VisualStudioContainer1.Controls.Add(Me.Label3)
        Me.VisualStudioContainer1.Controls.Add(Me.LBLMAD)
        Me.VisualStudioContainer1.Controls.Add(Me.Label2)
        Me.VisualStudioContainer1.Controls.Add(Me.btnClear)
        Me.VisualStudioContainer1.Controls.Add(Me.Tabz)
        Me.VisualStudioContainer1.Controls.Add(Me.LblFocus)
        Me.VisualStudioContainer1.Controls.Add(Me.VisualStudioStatusBar1)
        Me.VisualStudioContainer1.Controls.Add(Me.BtnForecast)
        Me.VisualStudioContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisualStudioContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioContainer1.FontSize = 12
        Me.VisualStudioContainer1.Form = Nothing
        Me.VisualStudioContainer1.FormOrWhole = Forecast.VisualStudioContainer.__FormOrWhole.WholeApplication
        Me.VisualStudioContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.VisualStudioContainer1.IconStyle = Forecast.VisualStudioContainer.__IconStyle.VSIcon
        Me.VisualStudioContainer1.Location = New System.Drawing.Point(0, 0)
        Me.VisualStudioContainer1.Name = "VisualStudioContainer1"
        Me.VisualStudioContainer1.ShowIcon = True
        Me.VisualStudioContainer1.Size = New System.Drawing.Size(718, 561)
        Me.VisualStudioContainer1.TabIndex = 1
        Me.VisualStudioContainer1.Text = "Forecast"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(14, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Avrage Error :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(14, 476)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cumulative Error :"
        '
        'LBLMAD
        '
        Me.LBLMAD.AutoSize = True
        Me.LBLMAD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLMAD.Location = New System.Drawing.Point(14, 452)
        Me.LBLMAD.Name = "LBLMAD"
        Me.LBLMAD.Size = New System.Drawing.Size(36, 13)
        Me.LBLMAD.TabIndex = 7
        Me.LBLMAD.Text = "MAD :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(14, 425)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "MAPD :"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnClear.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnClear.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnClear.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClear.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnClear.ImageAlignment = Forecast.VisualStudioButton.__ImageAlignment.Left
        Me.btnClear.ImageChoice = Nothing
        Me.btnClear.Location = New System.Drawing.Point(309, 476)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShowBorder = True
        Me.btnClear.ShowImage = False
        Me.btnClear.ShowText = True
        Me.btnClear.Size = New System.Drawing.Size(101, 40)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Tabz
        '
        Me.Tabz.ActiveColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Tabz.AllowDrop = True
        Me.Tabz.BackTabColour = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Tabz.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Tabz.BorderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Tabz.Controls.Add(Me.Tabnaive)
        Me.Tabz.Controls.Add(Me.TabmovingAverage)
        Me.Tabz.Controls.Add(Me.TabwightedMoving)
        Me.Tabz.Controls.Add(Me.TabExponenSmooth)
        Me.Tabz.Controls.Add(Me.TabAdjExponSmoth)
        Me.Tabz.Controls.Add(Me.TabRegression)
        Me.Tabz.Controls.Add(Me.TabSeasonAdj)
        Me.Tabz.HorizontalLineColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Tabz.ItemSize = New System.Drawing.Size(240, 20)
        Me.Tabz.Location = New System.Drawing.Point(9, 41)
        Me.Tabz.Name = "Tabz"
        Me.Tabz.SelectedIndex = 0
        Me.Tabz.Size = New System.Drawing.Size(697, 378)
        Me.Tabz.TabIndex = 6
        Me.Tabz.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'Tabnaive
        '
        Me.Tabnaive.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Tabnaive.Controls.Add(Me.Grdnaieve)
        Me.Tabnaive.Location = New System.Drawing.Point(4, 24)
        Me.Tabnaive.Name = "Tabnaive"
        Me.Tabnaive.Padding = New System.Windows.Forms.Padding(3)
        Me.Tabnaive.Size = New System.Drawing.Size(689, 350)
        Me.Tabnaive.TabIndex = 0
        Me.Tabnaive.Text = "Naive method"
        '
        'Grdnaieve
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.Grdnaieve.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grdnaieve.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Grdnaieve.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grdnaieve.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grdnaieve.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grdnaieve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grdnaieve.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmname, Me.clmdemand, Me.clmforecast, Me.clmError, Me.clmAbsError})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grdnaieve.DefaultCellStyle = DataGridViewCellStyle3
        Me.Grdnaieve.EnableHeadersVisualStyles = False
        Me.Grdnaieve.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Grdnaieve.Location = New System.Drawing.Point(4, 8)
        Me.Grdnaieve.Name = "Grdnaieve"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grdnaieve.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Grdnaieve.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.Grdnaieve.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Grdnaieve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grdnaieve.Size = New System.Drawing.Size(679, 339)
        Me.Grdnaieve.TabIndex = 0
        '
        'clmname
        '
        Me.clmname.HeaderText = "Name"
        Me.clmname.Name = "clmname"
        '
        'clmdemand
        '
        Me.clmdemand.HeaderText = "Demand"
        Me.clmdemand.Name = "clmdemand"
        '
        'clmforecast
        '
        Me.clmforecast.HeaderText = "Forecast"
        Me.clmforecast.Name = "clmforecast"
        '
        'clmError
        '
        Me.clmError.HeaderText = "Error"
        Me.clmError.Name = "clmError"
        '
        'clmAbsError
        '
        Me.clmAbsError.HeaderText = "|Error|"
        Me.clmAbsError.Name = "clmAbsError"
        '
        'TabmovingAverage
        '
        Me.TabmovingAverage.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TabmovingAverage.Controls.Add(Me.GrdMovingA)
        Me.TabmovingAverage.Location = New System.Drawing.Point(4, 24)
        Me.TabmovingAverage.Name = "TabmovingAverage"
        Me.TabmovingAverage.Padding = New System.Windows.Forms.Padding(3)
        Me.TabmovingAverage.Size = New System.Drawing.Size(689, 350)
        Me.TabmovingAverage.TabIndex = 1
        Me.TabmovingAverage.Text = "Moving average"
        '
        'GrdMovingA
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.GrdMovingA.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.GrdMovingA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GrdMovingA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrdMovingA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdMovingA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.GrdMovingA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdMovingA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNameMA, Me.clmDemandMA, Me.clmPeriodsMA, Me.clmForecastMA, Me.clmErrorMA, Me.clmAbsErrorMA})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdMovingA.DefaultCellStyle = DataGridViewCellStyle8
        Me.GrdMovingA.EnableHeadersVisualStyles = False
        Me.GrdMovingA.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GrdMovingA.Location = New System.Drawing.Point(4, 8)
        Me.GrdMovingA.Name = "GrdMovingA"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdMovingA.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.GrdMovingA.RowHeadersVisible = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        Me.GrdMovingA.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.GrdMovingA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdMovingA.Size = New System.Drawing.Size(679, 339)
        Me.GrdMovingA.TabIndex = 1
        '
        'clmNameMA
        '
        Me.clmNameMA.HeaderText = "Name"
        Me.clmNameMA.Name = "clmNameMA"
        '
        'clmDemandMA
        '
        Me.clmDemandMA.HeaderText = "Demand"
        Me.clmDemandMA.Name = "clmDemandMA"
        '
        'clmPeriodsMA
        '
        Me.clmPeriodsMA.HeaderText = "Periods"
        Me.clmPeriodsMA.Name = "clmPeriodsMA"
        '
        'clmForecastMA
        '
        Me.clmForecastMA.HeaderText = "Forecast"
        Me.clmForecastMA.Name = "clmForecastMA"
        '
        'clmErrorMA
        '
        Me.clmErrorMA.HeaderText = "Error"
        Me.clmErrorMA.Name = "clmErrorMA"
        '
        'clmAbsErrorMA
        '
        Me.clmAbsErrorMA.HeaderText = "|Error|"
        Me.clmAbsErrorMA.Name = "clmAbsErrorMA"
        '
        'TabwightedMoving
        '
        Me.TabwightedMoving.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TabwightedMoving.Controls.Add(Me.GrdWightedMovingA)
        Me.TabwightedMoving.Location = New System.Drawing.Point(4, 24)
        Me.TabwightedMoving.Name = "TabwightedMoving"
        Me.TabwightedMoving.Size = New System.Drawing.Size(689, 350)
        Me.TabwightedMoving.TabIndex = 2
        Me.TabwightedMoving.Text = "Wighted moving avarage"
        '
        'GrdWightedMovingA
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.GrdWightedMovingA.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.GrdWightedMovingA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GrdWightedMovingA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrdWightedMovingA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdWightedMovingA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.GrdWightedMovingA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdWightedMovingA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNameWMA, Me.clmDemandWMA, Me.clmPeriodsWMA, Me.clmForecastWMA, Me.clmErrorWMA, Me.clmAbsErrorWMA})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdWightedMovingA.DefaultCellStyle = DataGridViewCellStyle13
        Me.GrdWightedMovingA.EnableHeadersVisualStyles = False
        Me.GrdWightedMovingA.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GrdWightedMovingA.Location = New System.Drawing.Point(4, 8)
        Me.GrdWightedMovingA.Name = "GrdWightedMovingA"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdWightedMovingA.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.GrdWightedMovingA.RowHeadersVisible = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        Me.GrdWightedMovingA.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.GrdWightedMovingA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdWightedMovingA.Size = New System.Drawing.Size(679, 339)
        Me.GrdWightedMovingA.TabIndex = 3
        '
        'clmNameWMA
        '
        Me.clmNameWMA.HeaderText = "Name"
        Me.clmNameWMA.Name = "clmNameWMA"
        '
        'clmDemandWMA
        '
        Me.clmDemandWMA.HeaderText = "Demand"
        Me.clmDemandWMA.Name = "clmDemandWMA"
        '
        'clmPeriodsWMA
        '
        Me.clmPeriodsWMA.HeaderText = "Periods"
        Me.clmPeriodsWMA.Name = "clmPeriodsWMA"
        '
        'clmForecastWMA
        '
        Me.clmForecastWMA.HeaderText = "Forecast"
        Me.clmForecastWMA.Name = "clmForecastWMA"
        '
        'clmErrorWMA
        '
        Me.clmErrorWMA.HeaderText = "Error"
        Me.clmErrorWMA.Name = "clmErrorWMA"
        '
        'clmAbsErrorWMA
        '
        Me.clmAbsErrorWMA.HeaderText = "|Error|"
        Me.clmAbsErrorWMA.Name = "clmAbsErrorWMA"
        '
        'TabExponenSmooth
        '
        Me.TabExponenSmooth.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TabExponenSmooth.Controls.Add(Me.LBLEnterForecast)
        Me.TabExponenSmooth.Controls.Add(Me.LbLEnterA)
        Me.TabExponenSmooth.Controls.Add(Me.TxtAlpha)
        Me.TabExponenSmooth.Controls.Add(Me.GrdExponSmooth)
        Me.TabExponenSmooth.Location = New System.Drawing.Point(4, 24)
        Me.TabExponenSmooth.Name = "TabExponenSmooth"
        Me.TabExponenSmooth.Size = New System.Drawing.Size(689, 350)
        Me.TabExponenSmooth.TabIndex = 3
        Me.TabExponenSmooth.Text = "Exponential smoothing"
        '
        'LBLEnterForecast
        '
        Me.LBLEnterForecast.AutoSize = True
        Me.LBLEnterForecast.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LBLEnterForecast.ForeColor = System.Drawing.Color.Snow
        Me.LBLEnterForecast.Location = New System.Drawing.Point(30, 289)
        Me.LBLEnterForecast.Name = "LBLEnterForecast"
        Me.LBLEnterForecast.Size = New System.Drawing.Size(524, 13)
        Me.LBLEnterForecast.TabIndex = 4
        Me.LBLEnterForecast.Text = "Enter the first forecast , otherwise it will be the first demand, also enter any " & _
    "forecasts given in the question"
        '
        'LbLEnterA
        '
        Me.LbLEnterA.AutoSize = True
        Me.LbLEnterA.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LbLEnterA.ForeColor = System.Drawing.Color.Snow
        Me.LbLEnterA.Location = New System.Drawing.Point(30, 314)
        Me.LbLEnterA.Name = "LbLEnterA"
        Me.LbLEnterA.Size = New System.Drawing.Size(171, 13)
        Me.LbLEnterA.TabIndex = 3
        Me.LbLEnterA.Text = "Enter Smoothing Constant (Alpha)"
        '
        'TxtAlpha
        '
        Me.TxtAlpha.BackColor = System.Drawing.Color.Transparent
        Me.TxtAlpha.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TxtAlpha.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TxtAlpha.Location = New System.Drawing.Point(207, 314)
        Me.TxtAlpha.MaxLength = 32767
        Me.TxtAlpha.Multiline = False
        Me.TxtAlpha.Name = "TxtAlpha"
        Me.TxtAlpha.ReadOnly = False
        Me.TxtAlpha.Size = New System.Drawing.Size(62, 25)
        Me.TxtAlpha.Style = Forecast.VisualStudioNormalTextBox.Styles.NotRounded
        Me.TxtAlpha.TabIndex = 2
        Me.TxtAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtAlpha.TextColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtAlpha.UseSystemPasswordChar = False
        '
        'GrdExponSmooth
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.GrdExponSmooth.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.GrdExponSmooth.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GrdExponSmooth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrdExponSmooth.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdExponSmooth.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.GrdExponSmooth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdExponSmooth.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNameEx, Me.clmDemandEx, Me.clmForecastEx, Me.clmErrorEx, Me.clmAbsErrorEx})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdExponSmooth.DefaultCellStyle = DataGridViewCellStyle18
        Me.GrdExponSmooth.EnableHeadersVisualStyles = False
        Me.GrdExponSmooth.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GrdExponSmooth.Location = New System.Drawing.Point(4, 8)
        Me.GrdExponSmooth.Name = "GrdExponSmooth"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdExponSmooth.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.GrdExponSmooth.RowHeadersVisible = False
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        Me.GrdExponSmooth.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.GrdExponSmooth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdExponSmooth.Size = New System.Drawing.Size(679, 278)
        Me.GrdExponSmooth.TabIndex = 1
        '
        'clmNameEx
        '
        Me.clmNameEx.HeaderText = "Name"
        Me.clmNameEx.Name = "clmNameEx"
        '
        'clmDemandEx
        '
        Me.clmDemandEx.HeaderText = "Demand"
        Me.clmDemandEx.Name = "clmDemandEx"
        '
        'clmForecastEx
        '
        Me.clmForecastEx.HeaderText = "Forecast"
        Me.clmForecastEx.Name = "clmForecastEx"
        '
        'clmErrorEx
        '
        Me.clmErrorEx.HeaderText = "Error"
        Me.clmErrorEx.Name = "clmErrorEx"
        '
        'clmAbsErrorEx
        '
        Me.clmAbsErrorEx.HeaderText = "|Error|"
        Me.clmAbsErrorEx.Name = "clmAbsErrorEx"
        '
        'TabAdjExponSmoth
        '
        Me.TabAdjExponSmoth.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TabAdjExponSmoth.Controls.Add(Me.Label1)
        Me.TabAdjExponSmoth.Controls.Add(Me.LbLBetaAdj)
        Me.TabAdjExponSmoth.Controls.Add(Me.txtBetaAdj)
        Me.TabAdjExponSmoth.Controls.Add(Me.LbLEnterAdj)
        Me.TabAdjExponSmoth.Controls.Add(Me.LbLAlphaAdj)
        Me.TabAdjExponSmoth.Controls.Add(Me.txtAlphaAdj)
        Me.TabAdjExponSmoth.Controls.Add(Me.GrdAdjExponential)
        Me.TabAdjExponSmoth.Location = New System.Drawing.Point(4, 24)
        Me.TabAdjExponSmoth.Name = "TabAdjExponSmoth"
        Me.TabAdjExponSmoth.Size = New System.Drawing.Size(689, 350)
        Me.TabAdjExponSmoth.TabIndex = 4
        Me.TabAdjExponSmoth.Text = "Adjusted exponential smoothing"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(16, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter the first trend, otherwise it will be zero, also enter any trends given in " & _
    "the question"
        '
        'LbLBetaAdj
        '
        Me.LbLBetaAdj.AutoSize = True
        Me.LbLBetaAdj.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LbLBetaAdj.ForeColor = System.Drawing.Color.Snow
        Me.LbLBetaAdj.Location = New System.Drawing.Point(277, 323)
        Me.LbLBetaAdj.Name = "LbLBetaAdj"
        Me.LbLBetaAdj.Size = New System.Drawing.Size(158, 13)
        Me.LbLBetaAdj.TabIndex = 9
        Me.LbLBetaAdj.Text = "Enter Trending Constant (Beta)"
        '
        'txtBetaAdj
        '
        Me.txtBetaAdj.BackColor = System.Drawing.Color.Transparent
        Me.txtBetaAdj.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtBetaAdj.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtBetaAdj.Location = New System.Drawing.Point(454, 323)
        Me.txtBetaAdj.MaxLength = 32767
        Me.txtBetaAdj.Multiline = False
        Me.txtBetaAdj.Name = "txtBetaAdj"
        Me.txtBetaAdj.ReadOnly = False
        Me.txtBetaAdj.Size = New System.Drawing.Size(62, 25)
        Me.txtBetaAdj.Style = Forecast.VisualStudioNormalTextBox.Styles.NotRounded
        Me.txtBetaAdj.TabIndex = 8
        Me.txtBetaAdj.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtBetaAdj.TextColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtBetaAdj.UseSystemPasswordChar = False
        '
        'LbLEnterAdj
        '
        Me.LbLEnterAdj.AutoSize = True
        Me.LbLEnterAdj.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LbLEnterAdj.ForeColor = System.Drawing.Color.Snow
        Me.LbLEnterAdj.Location = New System.Drawing.Point(16, 280)
        Me.LbLEnterAdj.Name = "LbLEnterAdj"
        Me.LbLEnterAdj.Size = New System.Drawing.Size(524, 13)
        Me.LbLEnterAdj.TabIndex = 7
        Me.LbLEnterAdj.Text = "Enter the first forecast , otherwise it will be the first demand, also enter any " & _
    "forecasts given in the question"
        '
        'LbLAlphaAdj
        '
        Me.LbLAlphaAdj.AutoSize = True
        Me.LbLAlphaAdj.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LbLAlphaAdj.ForeColor = System.Drawing.Color.Snow
        Me.LbLAlphaAdj.Location = New System.Drawing.Point(16, 323)
        Me.LbLAlphaAdj.Name = "LbLAlphaAdj"
        Me.LbLAlphaAdj.Size = New System.Drawing.Size(171, 13)
        Me.LbLAlphaAdj.TabIndex = 6
        Me.LbLAlphaAdj.Text = "Enter Smoothing Constant (Alpha)"
        '
        'txtAlphaAdj
        '
        Me.txtAlphaAdj.BackColor = System.Drawing.Color.Transparent
        Me.txtAlphaAdj.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtAlphaAdj.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtAlphaAdj.Location = New System.Drawing.Point(193, 323)
        Me.txtAlphaAdj.MaxLength = 32767
        Me.txtAlphaAdj.Multiline = False
        Me.txtAlphaAdj.Name = "txtAlphaAdj"
        Me.txtAlphaAdj.ReadOnly = False
        Me.txtAlphaAdj.Size = New System.Drawing.Size(62, 25)
        Me.txtAlphaAdj.Style = Forecast.VisualStudioNormalTextBox.Styles.NotRounded
        Me.txtAlphaAdj.TabIndex = 5
        Me.txtAlphaAdj.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAlphaAdj.TextColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtAlphaAdj.UseSystemPasswordChar = False
        '
        'GrdAdjExponential
        '
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.GrdAdjExponential.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.GrdAdjExponential.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GrdAdjExponential.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrdAdjExponential.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdAdjExponential.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.GrdAdjExponential.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdAdjExponential.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNameAdjEx, Me.clmDemandAdjEx, Me.clmTrendAdjEx, Me.clmForecastAdjEx, Me.clmAdjForecastAdjEx, Me.clmErrorAdjEx, Me.clmAbsErrorAdjEx})
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdAdjExponential.DefaultCellStyle = DataGridViewCellStyle23
        Me.GrdAdjExponential.EnableHeadersVisualStyles = False
        Me.GrdAdjExponential.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GrdAdjExponential.Location = New System.Drawing.Point(4, 8)
        Me.GrdAdjExponential.Name = "GrdAdjExponential"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdAdjExponential.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.GrdAdjExponential.RowHeadersVisible = False
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.White
        Me.GrdAdjExponential.RowsDefaultCellStyle = DataGridViewCellStyle25
        Me.GrdAdjExponential.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdAdjExponential.Size = New System.Drawing.Size(679, 269)
        Me.GrdAdjExponential.TabIndex = 2
        '
        'clmNameAdjEx
        '
        Me.clmNameAdjEx.HeaderText = "Name"
        Me.clmNameAdjEx.Name = "clmNameAdjEx"
        '
        'clmDemandAdjEx
        '
        Me.clmDemandAdjEx.HeaderText = "Demand"
        Me.clmDemandAdjEx.Name = "clmDemandAdjEx"
        Me.clmDemandAdjEx.Width = 75
        '
        'clmTrendAdjEx
        '
        Me.clmTrendAdjEx.HeaderText = "Trend"
        Me.clmTrendAdjEx.Name = "clmTrendAdjEx"
        Me.clmTrendAdjEx.Width = 75
        '
        'clmForecastAdjEx
        '
        Me.clmForecastAdjEx.HeaderText = "Forecast"
        Me.clmForecastAdjEx.Name = "clmForecastAdjEx"
        '
        'clmAdjForecastAdjEx
        '
        Me.clmAdjForecastAdjEx.HeaderText = "Adjusted forecast"
        Me.clmAdjForecastAdjEx.Name = "clmAdjForecastAdjEx"
        Me.clmAdjForecastAdjEx.Width = 140
        '
        'clmErrorAdjEx
        '
        Me.clmErrorAdjEx.HeaderText = "Error"
        Me.clmErrorAdjEx.Name = "clmErrorAdjEx"
        Me.clmErrorAdjEx.Width = 75
        '
        'clmAbsErrorAdjEx
        '
        Me.clmAbsErrorAdjEx.HeaderText = "|Error|"
        Me.clmAbsErrorAdjEx.Name = "clmAbsErrorAdjEx"
        Me.clmAbsErrorAdjEx.Width = 75
        '
        'TabRegression
        '
        Me.TabRegression.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TabRegression.Controls.Add(Me.GrdRegression)
        Me.TabRegression.Location = New System.Drawing.Point(4, 24)
        Me.TabRegression.Name = "TabRegression"
        Me.TabRegression.Size = New System.Drawing.Size(689, 350)
        Me.TabRegression.TabIndex = 5
        Me.TabRegression.Text = "Linear Regression"
        '
        'GrdRegression
        '
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.GrdRegression.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle26
        Me.GrdRegression.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GrdRegression.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrdRegression.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdRegression.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.GrdRegression.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdRegression.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNameRg, Me.clmDemandRg, Me.clmPeriodsRg, Me.clmForecastRg, Me.clmErrorRg, Me.clmAbsErrorRg})
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdRegression.DefaultCellStyle = DataGridViewCellStyle28
        Me.GrdRegression.EnableHeadersVisualStyles = False
        Me.GrdRegression.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GrdRegression.Location = New System.Drawing.Point(4, 8)
        Me.GrdRegression.Name = "GrdRegression"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdRegression.RowHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.GrdRegression.RowHeadersVisible = False
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.White
        Me.GrdRegression.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.GrdRegression.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdRegression.Size = New System.Drawing.Size(679, 342)
        Me.GrdRegression.TabIndex = 2
        '
        'clmNameRg
        '
        Me.clmNameRg.HeaderText = "ID"
        Me.clmNameRg.Name = "clmNameRg"
        '
        'clmDemandRg
        '
        Me.clmDemandRg.HeaderText = "Demand"
        Me.clmDemandRg.Name = "clmDemandRg"
        '
        'clmPeriodsRg
        '
        Me.clmPeriodsRg.HeaderText = "Periods"
        Me.clmPeriodsRg.Name = "clmPeriodsRg"
        '
        'clmForecastRg
        '
        Me.clmForecastRg.HeaderText = "Forecast"
        Me.clmForecastRg.Name = "clmForecastRg"
        '
        'clmErrorRg
        '
        Me.clmErrorRg.HeaderText = "Error"
        Me.clmErrorRg.Name = "clmErrorRg"
        '
        'clmAbsErrorRg
        '
        Me.clmAbsErrorRg.HeaderText = "|Error|"
        Me.clmAbsErrorRg.Name = "clmAbsErrorRg"
        '
        'TabSeasonAdj
        '
        Me.TabSeasonAdj.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TabSeasonAdj.Location = New System.Drawing.Point(4, 24)
        Me.TabSeasonAdj.Name = "TabSeasonAdj"
        Me.TabSeasonAdj.Size = New System.Drawing.Size(689, 350)
        Me.TabSeasonAdj.TabIndex = 6
        Me.TabSeasonAdj.Text = "Seasonal Adjustment "
        '
        'LblFocus
        '
        Me.LblFocus.AutoSize = True
        Me.LblFocus.Location = New System.Drawing.Point(598, 459)
        Me.LblFocus.Name = "LblFocus"
        Me.LblFocus.Size = New System.Drawing.Size(0, 13)
        Me.LblFocus.TabIndex = 4
        '
        'VisualStudioStatusBar1
        '
        Me.VisualStudioStatusBar1.AmountOfString = Forecast.VisualStudioStatusBar.AmountOfStrings.One
        Me.VisualStudioStatusBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioStatusBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioStatusBar1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.VisualStudioStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VisualStudioStatusBar1.FirstLabelAlignment = Forecast.VisualStudioStatusBar.Alignments.Left
        Me.VisualStudioStatusBar1.FirstLabelText = "Mohammed AL Sayed"
        Me.VisualStudioStatusBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VisualStudioStatusBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.VisualStudioStatusBar1.LinesToShow = Forecast.VisualStudioStatusBar.LinesCount.One
        Me.VisualStudioStatusBar1.Location = New System.Drawing.Point(0, 540)
        Me.VisualStudioStatusBar1.Name = "VisualStudioStatusBar1"
        Me.VisualStudioStatusBar1.RectangleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.VisualStudioStatusBar1.SecondLabelAlignment = Forecast.VisualStudioStatusBar.Alignments.Center
        Me.VisualStudioStatusBar1.SecondLabelText = "Mohammed AL Sayed"
        Me.VisualStudioStatusBar1.ShowBorder = True
        Me.VisualStudioStatusBar1.ShowLine = True
        Me.VisualStudioStatusBar1.Size = New System.Drawing.Size(718, 21)
        Me.VisualStudioStatusBar1.TabIndex = 1
        Me.VisualStudioStatusBar1.Text = "LOl"
        Me.VisualStudioStatusBar1.TextColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioStatusBar1.ThirdLabelAlignment = Forecast.VisualStudioStatusBar.Alignments.Center
        Me.VisualStudioStatusBar1.ThirdLabelText = "ll"
        '
        'BtnForecast
        '
        Me.BtnForecast.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnForecast.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnForecast.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnForecast.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnForecast.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnForecast.ImageAlignment = Forecast.VisualStudioButton.__ImageAlignment.Left
        Me.BtnForecast.ImageChoice = Nothing
        Me.BtnForecast.Location = New System.Drawing.Point(309, 425)
        Me.BtnForecast.Name = "BtnForecast"
        Me.BtnForecast.ShowBorder = True
        Me.BtnForecast.ShowImage = False
        Me.BtnForecast.ShowText = True
        Me.BtnForecast.Size = New System.Drawing.Size(101, 40)
        Me.BtnForecast.TabIndex = 2
        Me.BtnForecast.Text = "Forecast"
        Me.BtnForecast.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 561)
        Me.Controls.Add(Me.VisualStudioContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Forecast"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.VisualStudioContainer1.ResumeLayout(False)
        Me.VisualStudioContainer1.PerformLayout()
        Me.Tabz.ResumeLayout(False)
        Me.Tabnaive.ResumeLayout(False)
        CType(Me.Grdnaieve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabmovingAverage.ResumeLayout(False)
        CType(Me.GrdMovingA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabwightedMoving.ResumeLayout(False)
        CType(Me.GrdWightedMovingA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabExponenSmooth.ResumeLayout(False)
        Me.TabExponenSmooth.PerformLayout()
        CType(Me.GrdExponSmooth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAdjExponSmoth.ResumeLayout(False)
        Me.TabAdjExponSmoth.PerformLayout()
        CType(Me.GrdAdjExponential, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabRegression.ResumeLayout(False)
        CType(Me.GrdRegression, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisualStudioContainer1 As Forecast.VisualStudioContainer
    Friend WithEvents Tabz As Forecast.VisualStudioTabControl
    Friend WithEvents Tabnaive As System.Windows.Forms.TabPage
    Friend WithEvents Grdnaieve As System.Windows.Forms.DataGridView
    Friend WithEvents TabmovingAverage As System.Windows.Forms.TabPage
    Friend WithEvents GrdMovingA As System.Windows.Forms.DataGridView
    Friend WithEvents TabwightedMoving As System.Windows.Forms.TabPage
    Friend WithEvents TabExponenSmooth As System.Windows.Forms.TabPage
    Friend WithEvents LBLEnterForecast As System.Windows.Forms.Label
    Friend WithEvents LbLEnterA As System.Windows.Forms.Label
    Friend WithEvents TxtAlpha As Forecast.VisualStudioNormalTextBox
    Friend WithEvents GrdExponSmooth As System.Windows.Forms.DataGridView
    Friend WithEvents TabAdjExponSmoth As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LbLBetaAdj As System.Windows.Forms.Label
    Friend WithEvents txtBetaAdj As Forecast.VisualStudioNormalTextBox
    Friend WithEvents LbLEnterAdj As System.Windows.Forms.Label
    Friend WithEvents LbLAlphaAdj As System.Windows.Forms.Label
    Friend WithEvents txtAlphaAdj As Forecast.VisualStudioNormalTextBox
    Friend WithEvents GrdAdjExponential As System.Windows.Forms.DataGridView
    Friend WithEvents TabRegression As System.Windows.Forms.TabPage
    Friend WithEvents GrdRegression As System.Windows.Forms.DataGridView
    Friend WithEvents LblFocus As System.Windows.Forms.Label
    Friend WithEvents BtnForecast As Forecast.VisualStudioButton
    Friend WithEvents VisualStudioStatusBar1 As Forecast.VisualStudioStatusBar
    Friend WithEvents GrdWightedMovingA As System.Windows.Forms.DataGridView
    Friend WithEvents TabSeasonAdj As System.Windows.Forms.TabPage
    Friend WithEvents clmname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmdemand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmforecast As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmError As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAbsError As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNameMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDemandMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPeriodsMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmForecastMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmErrorMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAbsErrorMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNameEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDemandEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmForecastEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmErrorEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAbsErrorEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNameAdjEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDemandAdjEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTrendAdjEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmForecastAdjEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAdjForecastAdjEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmErrorAdjEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAbsErrorAdjEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNameWMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDemandWMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPeriodsWMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmForecastWMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmErrorWMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAbsErrorWMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBLMAD As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClear As Forecast.VisualStudioButton
    Friend WithEvents clmNameRg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDemandRg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPeriodsRg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmForecastRg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmErrorRg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAbsErrorRg As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
