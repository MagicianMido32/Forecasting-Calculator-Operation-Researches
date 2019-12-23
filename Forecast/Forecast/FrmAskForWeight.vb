Public Class FrmAskForWeight
    '  Public Shared Demands As String
   

    Private Sub FrmAskForWeight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEnterW.Text = "Please Enter The weights For : " & Demands
        Me.TopMost = True
    End Sub

    Private Sub VisualStudioButton1_Click_1(sender As Object, e As EventArgs) Handles VisualStudioButton1.Click
        Dim returns As String = VisualStudioNormalTextBox1.Text
        Form1.returnedWeights = returns
        VisualStudioNormalTextBox1.Text = ""
        Me.Close()
    End Sub
    Private Shared _dmand As String
    Public Shared Property Demands As String
        Get
            Return _dmand
        End Get
        Set(value As String)
            _dmand = value
        End Set
    End Property
End Class
