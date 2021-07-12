Public Class frmLogin
    Public Sub New()
        InitializeComponent()

        pbMazimize.BackgroundImage = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "USER" And TextBox2.Text = "admin" Then

            Dim frm As New Form1  ' create a new Form1 object
            frm.Show()            ' ... and display it

            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub pbMazimize_Click(sender As Object, e As EventArgs) Handles pbMazimize.Click
        Me.Close()
    End Sub
End Class