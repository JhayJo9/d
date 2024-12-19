Imports MySql.Data.MySqlClient

''' <summary>
''' Form to manage assignment details.
''' </summary>
Public Class frmAssignDetails
    Dim courseId As Integer = 0

    ''' <summary>
    ''' Handles the Load event of the form.
    ''' Loads data into ComboBoxes.
    ''' </summary>
    Private Sub frmAssignDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSections()
        LoadCoursesWithQuestions()
        LoadAssessmentTypesWithQuestions()
    End Sub

    ''' <summary>
    ''' Loads sections into ComboBox.
    ''' </summary>
    Private Sub LoadSections()
        If DatabaseModule.openconnection() Then
            Dim query As String = "SELECT section_id, section_name FROM sections"
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim section = $"{reader("section_id")} - {reader("section_name")}"
                        cmbSections.Items.Add(section)
                    End While
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If
    End Sub

    ''' <summary>
    ''' Loads courses that have linked questions into ComboBox.
    ''' </summary>
    Private Sub LoadCoursesWithQuestions()
        If DatabaseModule.openconnection() Then
            Dim query As String = "SELECT DISTINCT c.course_code " &
                                  "FROM courses c " &
                                  "JOIN section_assignments sa ON c.course_id = sa.course_id " &
                                  "JOIN questions q ON sa.question_id = q.question_id"
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbCourses.Items.Add(reader("course_code").ToString())
                    End While
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If
    End Sub

    ''' <summary>
    ''' Loads assessment types that have linked questions into ComboBox.
    ''' </summary>
    Private Sub LoadAssessmentTypesWithQuestions()
        If DatabaseModule.openconnection() Then
            Dim query As String = "SELECT DISTINCT at.assessment_type_name " &
                                  "FROM assessment_types at " &
                                  "JOIN section_assignments sa ON at.assessment_type_id = sa.assessment_type_id " &
                                  "JOIN questions q ON sa.question_id = q.question_id"
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbAssessmentTypes.Items.Add(reader("assessment_type_name").ToString())
                    End While
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If
    End Sub

    ''' <summary>
    ''' Adds assignment to DataGridView.
    ''' </summary>
    Private Sub btnAddAssignment_Click(sender As Object, e As EventArgs) Handles btnAddAssignment.Click
        Dim section = cmbSections.SelectedItem.ToString()
        Dim course = cmbCourses.SelectedItem.ToString()
        Dim assessmentType = cmbAssessmentTypes.SelectedItem.ToString()
        dgvAssignments.Rows.Add(section, course, assessmentType)
    End Sub

    ''' <summary>
    ''' Removes selected assignment from DataGridView.
    ''' </summary>
    Private Sub btnRemoveAssignment_Click(sender As Object, e As EventArgs) Handles btnRemoveAssignment.Click
        For Each row As DataGridViewRow In dgvAssignments.SelectedRows
            dgvAssignments.Rows.Remove(row)
        Next
    End Sub

    ''' <summary>
    ''' Saves assignments to the database.
    ''' </summary>
    Private Sub btnSaveAssignments_Click(sender As Object, e As EventArgs) Handles btnSaveAssignments.Click
        InsertData()
        Debug.WriteLine(courseId)
    End Sub

    ''' <summary>
    ''' Inserts data into the database.
    ''' </summary>
    Private Sub InsertData()
        Try
            If DatabaseModule.openconnection() Then
                For Each row As DataGridViewRow In dgvAssignments.Rows
                    If Not row.IsNewRow Then
                        Dim section = row.Cells("Section").Value.ToString().Split("-"c)
                        Dim sectionId = section(0).Trim()
                        Dim course = row.Cells("Course").Value.ToString()
                        Dim assessmentType = row.Cells("Assessment_Type").Value.ToString()

                        ' Debug output before getting IDs
                        Debug.WriteLine($"Before lookup - Course: '{course}', Assessment Type: '{assessmentType}'")

                        courseId = GetCourseId(course)
                        Dim assessmentTypeId = GetAssessmentTypeId(assessmentType)

                        Debug.WriteLine($"After lookup - Section ID: {sectionId}, Course: {course}, Course ID: {courseId}, Assessment Type: {assessmentType}, Assessment Type ID: {assessmentTypeId}")

                        ' Add validation before insert
                        If courseId <= 0 Then
                            MsgBox($"Could not find course ID for course: {course}")
                            Continue For
                        End If

                        If assessmentTypeId <= 0 Then
                            MsgBox($"Could not find assessment type ID for: {assessmentType}")
                            Continue For
                        End If
                    End If
                Next
                DatabaseModule.closeconnection()
                MessageBox.Show("Assignments saved successfully!")
            End If
        Catch ex As Exception
            MsgBox("Error in InsertData: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Gets the Course ID from the Course Code.
    ''' </summary>
    ''' <param name="courseCode">The course code.</param>
    ''' <returns>The course ID.</returns>
    Private Function GetCourseId(courseCode As String) As Integer
        Dim courseId As Integer = 0
        Try
            If DatabaseModule.openconnection() Then
                ' Debug: Show all courses first
                Using debugCmd As New MySqlCommand("SELECT course_id, course_code FROM courses", DatabaseModule.conn)
                    Using debugReader As MySqlDataReader = debugCmd.ExecuteReader()
                        Debug.WriteLine("Available courses in database:")
                        While debugReader.Read()
                            Debug.WriteLine($"ID: {debugReader("course_id")}, Code: '{debugReader("course_code")}'")
                        End While
                    End Using
                End Using

                ' Modified query to handle whitespace
                Dim query As String = "SELECT course_id FROM courses WHERE REPLACE(TRIM(course_code), ' ', '') = REPLACE(@CourseCode, ' ', '')"
                Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                    cmd.Parameters.AddWithValue("@CourseCode", courseCode.Trim())
                    Debug.WriteLine($"Searching for course code: '{courseCode.Trim()}'")

                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        courseId = Convert.ToInt32(result)
                        Debug.WriteLine($"Found course ID: {courseId}")
                    Else
                        Debug.WriteLine("No course found")
                    End If
                End Using
                DatabaseModule.closeconnection()
            End If
        Catch ex As Exception
            Debug.WriteLine("Error in GetCourseId: " & ex.Message)
            MsgBox("Error fetching Course ID: " & ex.Message)
        End Try
        Return courseId
    End Function

    ''' <summary>
    ''' Gets the Assessment Type ID from the Assessment Type Name.
    ''' </summary>
    ''' <param name="assessmentTypeName">The assessment type name.</param>
    ''' <returns>The assessment type ID.</returns>
    Private Function GetAssessmentTypeId(assessmentTypeName As String) As Integer
        Dim assessmentTypeId As Integer = 0
        Try
            If DatabaseModule.openconnection() Then
                ' Debug: Show all assessment types first
                Using debugCmd As New MySqlCommand("SELECT assessment_type_id, assessment_type_name FROM assessment_types", DatabaseModule.conn)
                    Using debugReader As MySqlDataReader = debugCmd.ExecuteReader()
                        Debug.WriteLine("Available assessment types in database:")
                        While debugReader.Read()
                            Debug.WriteLine($"ID: {debugReader("assessment_type_id")}, Name: '{debugReader("assessment_type_name")}'")
                        End While
                    End Using
                End Using

                ' Modified query to handle whitespace
                Dim query As String = "SELECT assessment_type_id FROM assessment_types WHERE REPLACE(TRIM(assessment_type_name), ' ', '') = REPLACE(@AssessmentTypeName, ' ', '')"
                Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                    cmd.Parameters.AddWithValue("@AssessmentTypeName", assessmentTypeName.Trim())
                    Debug.WriteLine($"Searching for assessment type: '{assessmentTypeName.Trim()}'")

                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        assessmentTypeId = Convert.ToInt32(result)
                        Debug.WriteLine($"Found assessment type ID: {assessmentTypeId}")
                    Else
                        Debug.WriteLine("No assessment type found")
                    End If
                End Using
                DatabaseModule.closeconnection()
            End If
        Catch ex As Exception
            Debug.WriteLine("Error in GetAssessmentTypeId: " & ex.Message)
            MsgBox("Error fetching Assessment Type ID: " & ex.Message)
        End Try
        Return assessmentTypeId
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
