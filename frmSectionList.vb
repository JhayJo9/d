Imports MySql.Data.MySqlClient
Public Class frmSectionList
    Private Sub frmSectionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_Data()
    End Sub
    Public Sub Get_Data()
        dgwSectionList.Rows.Clear()
        Try
            If DatabaseModule.openconnection Then
                Dim query As String = "SELECT * FROM sections"
                Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader
                        While reader.Read
                            Dim section As String = reader.GetString("section_name")
                            dgwSectionList.Rows.Add(section)
                        End While
                    End Using
                End Using
                DatabaseModule.closeconnection()
            End If
        Catch ex As Exception
            MsgBox("GETTING SECTION: " & ex.Message)
        End Try
    End Sub
End Class