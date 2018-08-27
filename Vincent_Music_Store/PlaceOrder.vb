Public Class PlaceOrder



    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs)
        OrderApplication.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Visible = False
        Form1.ShowDialog()

    End Sub

    Private Sub PlaceOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBProjectDataSet.Includes' table. You can move, or remove it, as needed.
        Me.IncludesTableAdapter.Fill(Me.DBProjectDataSet.Includes)
        'TODO: This line of code loads data into the 'DBProjectDataSet.Music_Stock' table. You can move, or remove it, as needed.
        Me.Music_StockTableAdapter.Fill(Me.DBProjectDataSet.Music_Stock)
        'TODO: This line of code loads data into the 'DBProjectDataSet.Purchase_Details' table. You can move, or remove it, as needed.
        Me.Purchase_DetailsTableAdapter.FillBy2(Me.DBProjectDataSet.Purchase_Details)

    End Sub

    Private Sub Purchase_DetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Purchase_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBProjectDataSet)

    End Sub

    Private Sub Purchase_DetailsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Purchase_DetailsDataGridView.CellContentClick

    End Sub

    Private Sub Music_StockDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Music_StockDataGridView.CellContentClick

    End Sub

    Private Sub FillBy2ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Purchase_DetailsTableAdapter.FillBy2(Me.DBProjectDataSet.Purchase_Details)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub IncludesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles IncludesDataGridView.CellContentClick

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Visible = False

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Visible = False
        OrderApplication.ShowDialog()
    End Sub

    Private Sub Grand_TotalLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Purchase_DetailsBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Purchase_DetailsBindingSource.EndEdit()
            Purchase_DetailsTableAdapter.Update(DBProjectDataSet.Purchase_Details)
            MessageBox.Show("Save Successful")
        Catch ex As Exception
            MessageBox.Show("Error occured while saving")
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            IncludesBindingSource.EndEdit()
            IncludesTableAdapter.Update(DBProjectDataSet.Includes)
            MessageBox.Show("Save Successful")
        Catch ex As Exception
            MessageBox.Show("Error occured while saving, make sure the purchase exists")
        End Try
    End Sub
End Class