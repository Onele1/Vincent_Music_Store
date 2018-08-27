Public Class QueryMusic


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MusicApp.Show()
        Me.Dispose()


    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Me.Visible = False
        Form1.ShowDialog()


    End Sub

    Private Sub Music_StockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Music_StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Music_StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBProjectDataSet)

    End Sub

    Private Sub QueryMusic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBProjectDataSet.Music_Stock' table. You can move, or remove it, as needed.
        Me.Music_StockTableAdapter.Fill(Me.DBProjectDataSet.Music_Stock)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class