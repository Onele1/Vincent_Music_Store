Public Class ChangeMusic
    Dim business As New business
    Dim StrResults As String
    Private Sub Querymusic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strconn As String = "true"
        Dim ds As New DataSet
        Dim dsMusic As New DataSet

    End Sub

    Private Sub cboId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboId.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgvReload_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReload.CellContentClick

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MusicApp.Show()
        Me.Dispose()
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Me.Visible = False
        Form1.ShowDialog()

    End Sub
End Class