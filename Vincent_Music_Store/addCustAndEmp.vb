Public Class addCustAndEmp

    Private Sub PersonBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PersonBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBProjectDataSet)

    End Sub

    Private Sub addCustAndEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBProjectDataSet.Person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter.Fill(Me.DBProjectDataSet.Person)

    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub PasswordLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Pay_LevelTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pay_LevelTextBox.TextChanged

    End Sub

    Private Sub Pay_LevelLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Job_TitleTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Job_TitleTextBox.TextChanged

    End Sub

    Private Sub Job_TitleLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Telephone_NumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Telephone_NumberTextBox.TextChanged

    End Sub

    Private Sub Telephone_NumberLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AddressTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub AddressLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Last_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last_NameTextBox.TextChanged

    End Sub

    Private Sub Last_NameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub First_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First_NameTextBox.TextChanged

    End Sub

    Private Sub First_NameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Person_IDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Person_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PersonBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Visible = False
        Admin.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Visible = False
    End Sub
End Class