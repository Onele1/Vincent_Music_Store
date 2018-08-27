Public Class MusicApp


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Dispose()
        addmusic.Show()


    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Visible = False
        ChangeMusic.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
        Search.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Dispose()

        Form1.Show()


    End Sub
End Class