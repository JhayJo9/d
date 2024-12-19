Imports MySql.Data.MySqlClient

Public Class frmRegisterStudentList

    Private Sub frmRegisterStudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRegisteredStudents()
    End Sub

    Private Sub LoadRegisteredStudents()
        Dim query As String = "SELECT s.student_id, s.student_number, s.firstname, s.lastname, s.middlename, s.email, s.contact_number, u.username, u.password " &
                              "FROM students s JOIN users u ON s.student_id = u.user_id WHERE u.user_type = 'student'"

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dgwStudentList.Rows.Clear()
                    While reader.Read()
                        Dim studentNumber As String = reader("student_number").ToString()
                        Dim firstname As String = reader("firstname").ToString()
                        Dim lastname As String = reader("lastname").ToString()
                        Dim middlename As String = reader("middlename").ToString()
                        Dim email As String = reader("email").ToString()
                        Dim contactNumber As String = reader("contact_number").ToString()
                        Dim username As String = reader("username").ToString()
                        Dim password As String = reader("password").ToString()

                        dgwStudentList.Rows.Add(studentNumber, firstname, lastname, middlename, email, contactNumber, username, password)
                    End While
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If
    End Sub

    Private Sub dgwStudentList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwStudentList.CellContentClick
        Dim colName As String = dgwStudentList.Columns(e.RowIndex).Name
        If colName = "colView" Then
            With frmRegistrationStudentView

                .txtLastname.Text = dgwStudentList.Rows(e.RowIndex).Cells(0).Value.ToString()
                .txtFirstname.Text = dgwStudentList.Rows(e.RowIndex).Cells(1).Value.ToString()
                .txtMiddlename.Text = dgwStudentList.Rows(e.RowIndex).Cells(2).Value.ToString()

                .txtEmail.Text = dgwStudentList.Rows(e.RowIndex).Cells(3).Value.ToString()
                .txtContactNo.Text = dgwStudentList.Rows(e.RowIndex).Cells(4).Value.ToString()
                .txtUsername.Text = dgwStudentList.Rows(e.RowIndex).Cells("colUsername").Value.ToString()
                .txtPassword.Text = dgwStudentList.Rows(e.RowIndex).Cells("colPassword").Value.ToString()

                'disable the textboxes and comboboxes

                .dateOfBirth.Enabled = False
                .chGender.Enabled = False
                .txtLastname.Enabled = False
                .txtFirstname.Enabled = False
                .txtMiddlename.Enabled = False
                .txtEmail.Enabled = False
                .txtContactNo.Enabled = False
                .txtUsername.Enabled = False
                .txtPassword.Enabled = False
                .cmbSection.Enabled = False
            End With
        End If
    End Sub
End Class