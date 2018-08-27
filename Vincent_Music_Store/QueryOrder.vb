Public Class QueryOrder

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        OrderApplication.Show()
        Me.Dispose()
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Me.Visible = False
        Form1.ShowDialog()
    End Sub

    Private Sub QueryOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBProjectDataSet.Purchase_Details' table. You can move, or remove it, as needed.
        Me.Purchase_DetailsTableAdapter.FillBy(Me.DBProjectDataSet.Purchase_Details)

    End Sub

    Private Sub Purchase_DetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Purchase_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Purchase_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBProjectDataSet)

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Purchase_DetailsTableAdapter.FillBy(Me.DBProjectDataSet.Purchase_Details)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Purchase_DetailsTableAdapter.FillBy1(Me.DBProjectDataSet.Purchase_Details)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Purchase_DetailsTableAdapter.FillBy1(Me.DBProjectDataSet.Purchase_Details)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Purchase_DetailsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Purchase_DetailsDataGridView.CellContentClick

    End Sub

    Private Sub cboId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim Flag As String
        Flag = True
        Dim count As Integer

        If Flag = True Then


            Purchase_DetailsDataGridView.ClearSelection()

            For Each row As DataGridViewRow In Purchase_DetailsDataGridView.Rows
                count += 1

                If Not (count = 5) Then
                    For Each cell As DataGridViewCell In row.Cells


                        If Not IsDBNull(cell.Value) Then

                            If Not cell.Value = Nothing Then
                                If cell.Value.ToString().StartsWith(TextBox1.Text, StringComparison.InvariantCultureIgnoreCase) Then

                                    cell.Selected = True

                                    Purchase_DetailsDataGridView.CurrentCell = Purchase_DetailsDataGridView.SelectedCells(0)

                                    'Exit For
                                End If

                            End If
                        End If
                    Next

                End If


            Next

        Else
            If TextBox1.Text = "" Then

                Purchase_DetailsDataGridView.Rows(0).Selected = True
            End If

        End If

    End Sub
End Class