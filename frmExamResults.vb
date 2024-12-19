Imports MySql.Data.MySqlClient

Public Class frmExamResults
    Private studentId As Integer
    Private courseId As Integer
    Private assessmentTypeId As Integer

    Public Sub New(studentId As Integer, courseId As Integer, assessmentTypeId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.studentId = studentId
        Me.courseId = courseId
        Me.assessmentTypeId = assessmentTypeId

        ' Load the student name, course name, and assessment type name
        lblStudentName.Text = "Student: " & GetStudentName(studentId)
        lblCourseName.Text = "Course: " & GetCourseName(courseId)
        lblAssessmentTypeName.Text = "Assessment Type: " & GetAssessmentTypeName(assessmentTypeId)
    End Sub

    Private Sub frmExamResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the exam results when the form loads
        LoadExamResults()
    End Sub

    Private Sub LoadExamResults()
        Dim query As String = "SELECT q.question_text, sr.selected_answer, q.correct_answer, " &
                              "IF(sr.selected_answer = q.correct_answer, 'Correct', 'Incorrect') AS result " &
                              "FROM student_responses sr " &
                              "JOIN questions q ON sr.question_id = q.question_id " &
                              "WHERE sr.student_id = @student_id AND sr.course_id = @course_id AND sr.assessment_type_id = @assessment_type_id"

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                cmd.Parameters.AddWithValue("@student_id", studentId)
                cmd.Parameters.AddWithValue("@course_id", courseId)
                cmd.Parameters.AddWithValue("@assessment_type_id", assessmentTypeId)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvResults.DataSource = dt
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If
    End Sub

    Private Function GetStudentName(studentId As Integer) As String
        Dim query As String = "SELECT CONCAT(firstname, ' ', lastname) AS student_name FROM students WHERE student_id = @student_id"
        Dim studentName As String = String.Empty

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                cmd.Parameters.AddWithValue("@student_id", studentId)
                studentName = cmd.ExecuteScalar().ToString()
            End Using
            DatabaseModule.closeconnection()
        End If

        Return studentName
    End Function

    Private Function GetCourseName(courseId As Integer) As String
        Dim query As String = "SELECT course_name FROM courses WHERE course_id = @course_id"
        Dim courseName As String = String.Empty

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                cmd.Parameters.AddWithValue("@course_id", courseId)
                courseName = cmd.ExecuteScalar().ToString()
            End Using
            DatabaseModule.closeconnection()
        End If

        Return courseName
    End Function

    Private Function GetAssessmentTypeName(assessmentTypeId As Integer) As String
        Dim query As String = "SELECT assessment_type_name FROM assessment_types WHERE assessment_type_id = @assessment_type_id"
        Dim assessmentTypeName As String = String.Empty

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                cmd.Parameters.AddWithValue("@assessment_type_id", assessmentTypeId)
                assessmentTypeName = cmd.ExecuteScalar().ToString()
            End Using
            DatabaseModule.closeconnection()
        End If

        Return assessmentTypeName
    End Function
End Class