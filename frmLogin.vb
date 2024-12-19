Imports MySql.Data.MySqlClient

Public Class frmLogin

    Public Shared StudentId As Integer ' Shared variable to store the student ID

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If ValidateUser(username, password) Then
            Dim userType As String = GetUserType(username)
            If userType = "admin" Then
                MessageBox.Show("Login Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim adminDashboard As New frmAdminDashboard()
                adminDashboard.Show()
            ElseIf userType = "student" Then
                StudentId = GetStudentId(username) ' Store the student ID in the shared variable
                MessageBox.Show("Login Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim studentDashboard As New frmStudentDashboard(StudentId)
                studentDashboard.Show()
            End If
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Function ValidateUser(username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"
        Dim result As Integer = 0

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                result = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
            DatabaseModule.closeconnection()
        End If

        Return result > 0
    End Function

    Private Function GetUserType(username As String) As String
        Dim query As String = "SELECT user_type FROM users WHERE username = @username"
        Dim userType As String = String.Empty

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                cmd.Parameters.AddWithValue("@username", username)
                userType = cmd.ExecuteScalar().ToString()
            End Using
            DatabaseModule.closeconnection()
        End If

        Return userType
    End Function

    Private Function GetStudentId(username As String) As Integer
        Dim query As String = "SELECT user_id FROM users WHERE username = @username"
        Dim studentId As Integer = 0

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                cmd.Parameters.AddWithValue("@username", username)
                studentId = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
            DatabaseModule.closeconnection()
        End If

        Return studentId
    End Function

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
End Class
