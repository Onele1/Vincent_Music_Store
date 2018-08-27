Public Class Form1

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        'Me.Visible = False

        Dim musApp As New MusicApp
        musApp.Show()


    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        'Me.Visible = False
        SalesAppMenu.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        ' Me.Visible = False
        OrderApplication.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click

        Me.Dispose()
    End Sub


    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click

        ' Me.Visible = False
        LogIn.ShowDialog()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
