Public Class Customer

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'OrderApplication.Show()
        Me.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        Form1.ShowDialog()

    End Sub

    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBProjectDataSet.Person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter.Fill(Me.DBProjectDataSet.Person)

    End Sub

    Private Sub PersonBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PersonBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBProjectDataSet)

    End Sub

    Private Sub PersonDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PersonDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PersonBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            PersonBindingSource.EndEdit()
            PersonTableAdapter.Update(DBProjectDataSet.Person)
            MessageBox.Show("Save Successful")
        Catch ex As Exception
            MessageBox.Show("Error occured while saving")
        End Try
    End Sub
End Class