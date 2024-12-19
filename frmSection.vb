Imports MySql.Data.MySqlClient
Public Class frmSection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub Insert_Data()
        Try
            If DatabaseModule.openconnection() Then
                Dim query As String = "INSERT INTO sections VALUES (null, @section_name)"
                Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                    cmd.Parameters.AddWithValue("@section_name", txtSectionCode.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Section Added Successfully!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DatabaseModule.closeconnection()
                With frmSectionList
                    .Get_Data()
                End With
            End If
        Catch ex As Exception
            MsgBox("INSET INTO sections: " & ex.Message)
        End Try
    End Sub

    Private Sub frmSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Insert_Data()
    End Sub
End Class