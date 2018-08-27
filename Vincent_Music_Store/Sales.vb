Public Class Sales

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SalesAppMenu.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        Form1.ShowDialog()

    End Sub

    Private Sub Music_StockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Purchase_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBProjectDataSet)

    End Sub

    Private Sub Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBProjectDataSet.Includes' table. You can move, or remove it, as needed.
        Me.IncludesTableAdapter.Fill(Me.DBProjectDataSet.Includes)
        'TODO: This line of code loads data into the 'DBProjectDatk'aSet.Music_Stoc table. You can move, or remove it, as needed.
        Me.Purchase_DetailsTableAdapter.Fill(Me.DBProjectDataSet.Purchase_Details)

        Me.Music_StockTableAdapter.Fill(Me.DBProjectDataSet.Music_Stock)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub Purchase_DetailsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Purchase_DetailsDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Employee_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Purchase_DetailsBindingSource.AddNew()

    End Sub

    Private Sub Purchase_DetailsDataGridView_CellContentClick_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Purchase_DetailsDataGridView.CellContentClick

    End Sub

    Private Sub Submission_TypeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Submission_TypeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Vendor_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Vendor_IDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Customer_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Customer_IDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Employee_IDTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Employee_IDTextBox.TextChanged

    End Sub

    Private Sub Employee_IDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Grand_TotalTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grand_TotalTextBox.TextChanged

    End Sub

    Private Sub Grand_TotalLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateDateTimePicker.ValueChanged

    End Sub

    Private Sub DateLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Purchase_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Purchase_IDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Music_StockDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Music_StockDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Music_StockDataGridView.CellContentClick

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' If (IsNumeric(Music_StockDataGridView.SelectedCells) And IsNumeric(Purchase_DetailsDataGridView.SelectedCells)) Then

        'SQL Statement including music_id, purchase_id and quantity || use no sql just DGVs to export data to textboxes or then 
        Try
            IncludesBindingSource.AddNew()
        Catch ex As Exception

        End Try

        '  End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Purchase_IDTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Purchase_IDTextBox1.TextChanged

    End Sub

    Private Sub Purchase_IDLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub IncludesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles IncludesDataGridView.CellContentClick

    End Sub

    Private Sub Submission_TypeLabel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class