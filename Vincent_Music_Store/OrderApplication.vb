Public Class OrderApplication

    Private Sub OrderApplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Me.Visible = False
        QueryOrder.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Visible = False
        QueryOrder.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Me.Visible = False
        PlaceOrder.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Me.Visible = False
        'Form1.Show()
        PlaceOrder.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Me.Visible = False
        'Form1.ShowDialog()

    End Sub
End Class