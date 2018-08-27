Imports System.Data.OleDb

Public Class Search


    Private Sub Music_StockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Music_StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Music_StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBProjectDataSet)

    End Sub

    Private Sub Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBProjectDataSet.Music_Stock' table. You can move, or remove it, as needed.
        Me.Music_StockTableAdapter.Fill(Me.DBProjectDataSet.Music_Stock)

    End Sub

    Private Sub Music_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Music_IDTextBox.TextChanged



    End Sub

    Private Sub TitleTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleTextBox.TextChanged
        
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim match As DataGridViewCell() = (From row As DataGridViewRow In Me.Music_StockDataGridView.Rows From cell As DataGridViewCell In row.Cells Select cell Where CStr(cell.FormattedValue).Contains(Me.TextBox1.Text)).ToArray()
        'If (TextBox1.Text.StartsWith(match(4).FormattedValue)) Then
        '    Dim str As String
        '    str = Convert.ToString(match(4).Value)
        '    TextBox1.Text = str
        'End If

        'Dim temp As Integer = 0
        'Dim str As String


        'For i As Integer = 0 To Music_StockDataGridView.RowCount - 2
        '    For j As Integer = 0 To Music_StockDataGridView.ColumnCount - 1

        '        If Not (IsDBNull(Music_StockDataGridView.Rows(i).Cells(j).Value)) Then
        '            str = Music_StockDataGridView.Rows(i).Cells(j).Value.ToString()

        '            If str.Contains(TextBox1.Text) Then

        '                temp = 1
        '            End If
        '        End If
        '    Next
        'Next

        'Dim ds As New DataSet
        'Dim dt As New DataTable
        'ds.Tables.Add(dt)
        'Dim da As New OleDbDataAdapter

        'da = New OleDbDataAdapter("SELECT * FROM Music_Stock", con)
        'da.Fill(dt)
        'Music_StockDataGridView.DataSource = dt.DefaultView





    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'If Not (TitleTextBox.Text.Trim(" ") = " ") Then
        '    '/*here "Name" is the column that you want filter/search
        '    Dim mID As String

        '    Music_StockBindingSource.Filter = String.Format("{0} LIKE '{1}%'", "Title",
        '    mID)
        '    '/* sorting method ascending/descending
        '    Music_StockBindingSource.Sort = "Title ASC"
        'End If

        Dim Flag As String
        Flag = True
        Dim count As Integer

        If Flag = True Then


            Music_StockDataGridView.ClearSelection()

            For Each row As DataGridViewRow In Music_StockDataGridView.Rows
                count += 1

                If Not (count = 5) Then
                    For Each cell As DataGridViewCell In row.Cells


                        If Not IsDBNull(cell.Value) Then

                            If Not cell.Value = Nothing Then
                                If cell.Value.ToString().StartsWith(TextBox1.Text, StringComparison.InvariantCultureIgnoreCase) Then

                                    cell.Selected = True

                                    Music_StockDataGridView.CurrentCell = Music_StockDataGridView.SelectedCells(0)

                                    'Exit For
                                End If

                            End If
                        End If
                    Next

                End If


            Next

        Else
            If TextBox1.Text = "" Then

                Music_StockDataGridView.Rows(0).Selected = True
            End If

        End If
    End Sub

    Private Sub Music_StockBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Music_StockBindingNavigator.RefreshItems

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Visible = False

    End Sub
End Class