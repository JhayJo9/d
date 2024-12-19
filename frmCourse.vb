Imports MySql.Data.MySqlClient

Public Class frmCourse
    Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any initialization code can go here
        If btnAdd.Text = "UPDATE" Then
            'UPDATE CODE HERE
        ElseIf btnAdd.Text = "SAVE" Then
            Insert_Data()
        End If
    End Sub

    ' Create a sub to insert course into table course with validation
    Private Sub Insert_Data()
        Try
            ' Validate that the course title and course code are not empty
            If String.IsNullOrWhiteSpace(txtCourseTitle.Text) Then
                MessageBox.Show("Please enter the course title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtCourseCode.Text) Then
                MessageBox.Show("Please enter the course code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' If validation passes, proceed with inserting data
            If DatabaseModule.openconnection() Then
                Dim query As String = "INSERT INTO courses VALUES (null, @course_description, @course_code)"
                Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                    cmd.Parameters.AddWithValue("@course_description", txtCourseTitle.Text.Trim())
                    cmd.Parameters.AddWithValue("@course_code", txtCourseCode.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Course Added Successfully!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DatabaseModule.closeconnection()

                ' Refresh the course list in frmCourseList
                With frmCourseList
                    .Get_Course()
                End With
            End If
        Catch ex As Exception
            MsgBox("INSERTING COURSE: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Call the Insert_Data subroutine when the Add button is clicked
        Insert_Data()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the form when the Back button is clicked
        Me.Close()
    End Sub
End Class