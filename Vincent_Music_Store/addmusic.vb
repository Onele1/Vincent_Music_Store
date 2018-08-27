Public Class addmusic
    Dim business As New business
    Private Sub addmusic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBProjectDataSet.Music_Stock' table. You can move, or remove it, as needed.
        Me.Music_StockTableAdapter.Fill(Me.DBProjectDataSet.Music_Stock)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Music_StockBindingSource.AddNew()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Visible = False
        Admin.Show()

    End Sub

    Private Sub Music_StockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Music_StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Music_StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBProjectDataSet)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Music_StockBindingSource.EndEdit()
            Music_StockTableAdapter.Update(DBProjectDataSet.Music_Stock)
            MessageBox.Show("Save Successful")
        Catch ex As Exception
            MessageBox.Show("Error occured while saving")
        End Try
    End Sub
End Class