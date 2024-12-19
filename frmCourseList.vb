Imports MySql.Data.MySqlClient
Public Class frmCourseList
    Private Sub frmCourseList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_Course()
    End Sub

    Public Sub Get_Course()
        dgwCourseList.Rows.Clear()
        Dim query As String = "SELECT * FROM courses"
        Try
            If DatabaseModule.openconnection() Then
                Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader
                        While reader.Read()
                            Dim courseDEs As String = reader.GetString("course_description")
                            Dim course_code As String = reader.GetString("course_code")

                            dgwCourseList.Rows.Add(courseDEs, course_code)
                        End While
                    End Using
                End Using
                DatabaseModule.closeconnection()
            End If
        Catch ex As Exception
            MsgBox("GETTING COURSE: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        With frmCourse
            .ShowDialog()
        End With
    End Sub

    Private Sub dgwCourseList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwCourseList.CellContentClick
        Dim colname As String = dgwCourseList.Columns(e.ColumnIndex).Name
        If colname = "ColEdit" Then
            With frmCourse
                .txtCourseCode.Text = dgwCourseList.Rows(e.RowIndex).Cells(1).Value
                .txtCourseTitle.Text = dgwCourseList.Rows(e.RowIndex).Cells(0).Value
                .btnAdd.Text = "UPDATE"
                .ShowDialog()
            End With
        End If
    End Sub
End Class