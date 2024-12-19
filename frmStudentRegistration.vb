Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class frmStudentRegistration

    Private Sub frmStudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSections()
    End Sub

    Private Sub LoadSections()
        Dim query As String = "SELECT * FROM sections"
        Dim dt As DataTable = DatabaseModule.GetData(query)
        cmbSection.DataSource = dt
        cmbSection.DisplayMember = "section_name"
        cmbSection.ValueMember = "section_id"
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim studentName As String = txtStudentName.Text
        Dim sectionId As Integer = Convert.ToInt32(cmbSection.SelectedValue)
        Dim query As String = $"INSERT INTO students (student_name, section_id) VALUES ('{studentName}', {sectionId})"
        DatabaseModule.ExecuteQuery(query)
        MessageBox.Show("Student registered successfully!")
    End Sub
End Class