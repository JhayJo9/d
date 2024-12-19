Imports MySql.Data.MySqlClient
Imports MySql.Data
Module DatabaseModule
    Private connectionString As String = "server=localhost;user=Yohan;password=Yohan;port=3307;database=offline_exam"

    ' Method to execute a query and return the results as a DataTable
    Public Function GetData(query As String, params As Dictionary(Of String, Object)) As DataTable
            Dim dt As New DataTable()

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    ' Add query parameters
                    For Each param As KeyValuePair(Of String, Object) In params
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using

            Return dt
        End Function

        ' Method to execute a non-query (INSERT, UPDATE, DELETE)
        Public Sub ExecuteNonQuery(query As String, params As Dictionary(Of String, Object))
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    ' Add query parameters
                    For Each param As KeyValuePair(Of String, Object) In params
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

    ' Method to execute a scalar query (returning a single value)
    Public Function ExecuteScalar(query As String, params As Dictionary(Of String, Object)) As Object
        Dim result As Object = Nothing

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                ' Add query parameters
                For Each param As KeyValuePair(Of String, Object) In params
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next

                result = cmd.ExecuteScalar()
            End Using
        End Using

        Return result
    End Function
End Module