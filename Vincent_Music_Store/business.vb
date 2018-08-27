Public Class business
    Dim con As New OleDb.OleDbConnection
    Public Function getConnection() As String
        Dim strConn As String = "true"
        Try
            con.ConnectionString = "Provider = Microsoft.jet.OleDB.4.0; Data source=DBProject.mdb"
        Catch ex As Exception
            strConn = ex.Message.ToString
        End Try
        Return strConn
    End Function
    Public Function AddMusic(ByVal Music_ID As Integer, ByVal Vendor_ID As Integer, ByVal Tape_quantity As Integer, ByVal CD_Quantity As Integer, ByVal Title As String, ByVal Artist As String, ByVal Producer As String, ByVal Year As String, ByVal Price As Double, ByVal Music_Subject As String) As String
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = ""
        Try
            sql = "insert into lecturer(lecturerId,lecturerName)values(" & Music_ID & "," & Vendor_ID & ", " & Tape_quantity & ", " & CD_Quantity & ", '" & Title & "','" & Artist & "','" & Producer & "','" & Year & "', '" & Price & "', '" & Music_Subject & "')"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"
            If cmd.Connection.State + ConnectionState.Open Then
                cmd.Connection.Close()
            End If

        Catch ex As Exception
            result = ex.Message.ToString()

        End Try
        Return result
    End Function
End Class
