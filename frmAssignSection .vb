Imports MySql.Data.MySqlClient

Public Class frmAssignStudent
    Private Sub frmAssignSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into ComboBoxes
        LoadSections()
        LoadCourses()
        LoadAssessmentTypes()
        ' Load existing assignments into DataGridView
        LoadAssignments()
    End Sub

    ' Load sections into ComboBox
    Private Sub LoadSections()
        If DatabaseModule.openconnection() Then
            Dim query As String = "SELECT section_id, section_name FROM sections WHERE section_id IN (SELECT DISTINCT section_id FROM students)"
            Dim cmd As New MySqlCommand(query, DatabaseModule.conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim section = $"{reader("section_id")} - {reader("section_name")}"
                cmbSections.Items.Add(section)
            End While
            reader.Close()
            DatabaseModule.closeconnection()
        End If
    End Sub

    ' Load courses into ComboBox
    Private Sub LoadCourses()
        If DatabaseModule.openconnection() Then
            Dim query As String = "SELECT course_id, course_code FROM courses"
            Dim cmd As New MySqlCommand(query, DatabaseModule.conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim course = $"{reader("course_id")} - {reader("course_code")}"
                cmbCourses.Items.Add(course)
            End While
            reader.Close()
            DatabaseModule.closeconnection()
        End If
    End Sub

    ' Load assessment types into ComboBox
    Private Sub LoadAssessmentTypes()
        If DatabaseModule.openconnection() Then
            Dim query As String = "SELECT assessment_type_id, assessment_type_name FROM assessment_types"
            Dim cmd As New MySqlCommand(query, DatabaseModule.conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim assessmentType = $"{reader("assessment_type_id")} - {reader("assessment_type_name")}"
                cmbAssessmentTypes.Items.Add(assessmentType)
            End While
            reader.Close()
            DatabaseModule.closeconnection()
        End If
    End Sub

    ' Load existing assignments into DataGridView
    Private Sub LoadAssignments()
        If DatabaseModule.openconnection() Then
            Dim query As String = "SELECT sa.section_id, s.section_name, sa.course_id, c.course_code, sa.assessment_type_id, at.assessment_type_name " &
                                  "FROM section_assignments sa " &
                                  "JOIN sections s ON sa.section_id = s.section_id " &
                                  "JOIN courses c ON sa.course_id = c.course_id " &
                                  "JOIN assessment_types at ON sa.assessment_type_id = at.assessment_type_id"
            Dim cmd As New MySqlCommand(query, DatabaseModule.conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim section = $"{reader("section_id")} - {reader("section_name")}"
                Dim course = $"{reader("course_id")} - {reader("course_code")}"
                Dim assessmentType = $"{reader("assessment_type_id")} - {reader("assessment_type_name")}"
                dgvAssignments.Rows.Add(section, course, assessmentType)
            End While
            reader.Close()
            DatabaseModule.closeconnection()
        End If
    End Sub

    ' Add assignment to DataGridView
    Private Sub btnAddAssignment_Click(sender As Object, e As EventArgs) Handles btnAddAssignment.Click
        Dim section = cmbSections.SelectedItem.ToString()
        Dim course = cmbCourses.SelectedItem.ToString()
        Dim assessmentType = cmbAssessmentTypes.SelectedItem.ToString()
        dgvAssignments.Rows.Add(section, course, assessmentType)
    End Sub

    ' Remove selected assignment from DataGridView
    Private Sub btnRemoveAssignment_Click(sender As Object, e As EventArgs) Handles btnRemoveAssignment.Click
        For Each row As DataGridViewRow In dgvAssignments.SelectedRows
            dgvAssignments.Rows.Remove(row)
        Next
    End Sub

    ' Save assignments to the database
    Private Sub btnSaveAssignments_Click(sender As Object, e As EventArgs) Handles btnSaveAssignments.Click
        Try
            If DatabaseModule.openconnection() Then
                For Each row As DataGridViewRow In dgvAssignments.Rows
                    If Not row.IsNewRow Then
                        Dim section = row.Cells("Section").Value.ToString().Split("-"c)
                        Dim sectionId = section(0).Trim()
                        Dim course = row.Cells("Course").Value.ToString().Split("-"c)
                        Dim courseId = course(0).Trim()
                        Dim assessmentType = row.Cells("Assessment_Type").Value.ToString().Split("-"c)
                        Dim assessmentTypeId = assessmentType(0).Trim()

                        Debug.WriteLine($"Section ID: {sectionId}, Course ID: {courseId}, Assessment Type ID: {assessmentTypeId}")
                        Dim query As String = "INSERT INTO section_assignments (section_id, course_id, assessment_type_id) " &
                                              "VALUES (@section_id, @course_id, @assessment_type_id)"
                        Dim cmd As New MySqlCommand(query, DatabaseModule.conn)
                        cmd.Parameters.AddWithValue("@section_id", sectionId)
                        cmd.Parameters.AddWithValue("@course_id", courseId)
                        cmd.Parameters.AddWithValue("@assessment_type_id", assessmentTypeId)
                        cmd.ExecuteNonQuery()
                    End If
                Next
                DatabaseModule.closeconnection()
                MessageBox.Show("Assignments saved successfully!")
            End If
        Catch ex As Exception
            MsgBox("section_assignments: " & ex.Message)
        End Try
    End Sub
End Class