<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAskForWeight
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAskForWeight))
        Me.VisualStudioContainer1w = New Forecast.VisualStudioContainer()
        Me.lblEnterW = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bar1 = New Forecast.bar()
        Me.VisualStudioNormalTextBox1 = New Forecast.VisualStudioNormalTextBox()
        Me.VisualStudioButton1 = New Forecast.VisualStudioButton()
        Me.VisualStudioContainer1w.SuspendLayout()
        Me.SuspendLayout()
        '
        'VisualStudioContainer1w
        '
        Me.VisualStudioContainer1w.AllowClose = False
        Me.VisualStudioContainer1w.AllowMaximize = False
        Me.VisualStudioContainer1w.AllowMinimize = False
        Me.VisualStudioContainer1w.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioContainer1w.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioContainer1w.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.VisualStudioContainer1w.Controls.Add(Me.lblEnterW)
        Me.VisualStudioContainer1w.Controls.Add(Me.Label1)
        Me.VisualStudioContainer1w.Controls.Add(Me.Bar1)
        Me.VisualStudioContainer1w.Controls.Add(Me.VisualStudioNormalTextBox1)
        Me.VisualStudioContainer1w.Controls.Add(Me.VisualStudioButton1)
        Me.VisualStudioContainer1w.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisualStudioContainer1w.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioContainer1w.FontSize = 12
        Me.VisualStudioContainer1w.Form = Me
        Me.VisualStudioContainer1w.FormOrWhole = Forecast.VisualStudioContainer.__FormOrWhole.Form
        Me.VisualStudioContainer1w.HoverColour = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.VisualStudioContainer1w.IconStyle = Forecast.VisualStudioContainer.__IconStyle.VSIcon
        Me.VisualStudioContainer1w.Location = New System.Drawing.Point(0, 0)
        Me.VisualStudioContainer1w.Name = "VisualStudioContainer1w"
        Me.VisualStudioContainer1w.ShowIcon = True
        Me.VisualStudioContainer1w.Size = New System.Drawing.Size(440, 107)
        Me.VisualStudioContainer1w.TabIndex = 1
        '
        'lblEnterW
        '
        Me.lblEnterW.AutoSize = True
        Me.lblEnterW.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblEnterW.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEnterW.Location = New System.Drawing.Point(37, 9)
        Me.lblEnterW.Name = "lblEnterW"
        Me.lblEnterW.Size = New System.Drawing.Size(86, 14)
        Me.lblEnterW.TabIndex = 5
        Me.lblEnterW.Text = "Enter Weights"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.3!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Separate between them with ,"
        '
        'Bar1
        '
        Me.Bar1.Location = New System.Drawing.Point(329, 3)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(108, 28)
        Me.Bar1.TabIndex = 3
        '
        'VisualStudioNormalTextBox1
        '
        Me.VisualStudioNormalTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.VisualStudioNormalTextBox1.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.VisualStudioNormalTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.VisualStudioNormalTextBox1.Location = New System.Drawing.Point(37, 41)
        Me.VisualStudioNormalTextBox1.MaxLength = 32767
        Me.VisualStudioNormalTextBox1.Multiline = False
        Me.VisualStudioNormalTextBox1.Name = "VisualStudioNormalTextBox1"
        Me.VisualStudioNormalTextBox1.ReadOnly = False
        Me.VisualStudioNormalTextBox1.Size = New System.Drawing.Size(285, 25)
        Me.VisualStudioNormalTextBox1.Style = Forecast.VisualStudioNormalTextBox.Styles.NotRounded
        Me.VisualStudioNormalTextBox1.TabIndex = 1
        Me.VisualStudioNormalTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.VisualStudioNormalTextBox1.TextColour = System.Drawing.Color.White
        Me.VisualStudioNormalTextBox1.UseSystemPasswordChar = False
        '
        'VisualStudioButton1
        '
        Me.VisualStudioButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.VisualStudioButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.VisualStudioButton1.ImageAlignment = Forecast.VisualStudioButton.__ImageAlignment.Left
        Me.VisualStudioButton1.ImageChoice = Nothing
        Me.VisualStudioButton1.Location = New System.Drawing.Point(328, 41)
        Me.VisualStudioButton1.Name = "VisualStudioButton1"
        Me.VisualStudioButton1.ShowBorder = True
        Me.VisualStudioButton1.ShowImage = False
        Me.VisualStudioButton1.ShowText = True
        Me.VisualStudioButton1.Size = New System.Drawing.Size(75, 25)
        Me.VisualStudioButton1.TabIndex = 0
        Me.VisualStudioButton1.Text = "OK"
        Me.VisualStudioButton1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'FrmAskForWeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 107)
        Me.ControlBox = False
        Me.Controls.Add(Me.VisualStudioContainer1w)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAskForWeight"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAskForWeight"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.VisualStudioContainer1w.ResumeLayout(False)
        Me.VisualStudioContainer1w.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisualStudioContainer1w As Forecast.VisualStudioContainer
    Friend WithEvents VisualStudioNormalTextBox1 As Forecast.VisualStudioNormalTextBox
    Friend WithEvents VisualStudioButton1 As Forecast.VisualStudioButton
    Friend WithEvents Bar1 As Forecast.bar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEnterW As System.Windows.Forms.Label
End Class
