Public Class frmStudentDashboard

    Private currentStudentId As Integer

    Public Sub New(studentId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        currentStudentId = studentId
    End Sub

    Private Sub frmStudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentData()
    End Sub

    Private Sub LoadStudentData()
        Dim query As String = "SELECT c.course_name, a.assessment_type_name, COUNT(q.question_id) AS question_count, " &
                              "COALESCE(sr.status, 'Not Taken') AS status " &
                              "FROM section_assignments sa " &
                              "JOIN courses c ON sa.course_id = c.course_id " &
                              "JOIN assessment_types a ON sa.assessment_type_id = a.assessment_type_id " &
                              "LEFT JOIN questions q ON sa.question_id = q.question_id " &
                              "LEFT JOIN (SELECT q.course_id, q.assessment_type_id, 'Taken' AS status " &
                              "           FROM student_responses sr " &
                              "           JOIN questions q ON sr.question_id = q.question_id " &
                              "           WHERE sr.student_id = @student_id " &
                              "           GROUP BY q.course_id, q.assessment_type_id) sr " &
                              "ON sa.course_id = sr.course_id AND sa.assessment_type_id = sr.assessment_type_id " &
                              "JOIN students stu ON stu.section_id = sa.section_id " &
                              "WHERE stu.student_id = @student_id " &
                              "GROUP BY c.course_name, a.assessment_type_name, sr.status"

        Dim params As New Dictionary(Of String, Object) From {
            {"@student_id", currentStudentId}
        }

        Dim dt As DataTable = DatabaseModule.GetData(query, params)
        DataGridView1.DataSource = dt

        ' Add Take Exam button column if it doesn't exist
        AddTakeExamButtonColumn()
    End Sub

    Private Sub AddTakeExamButtonColumn()
        If DataGridView1.Columns("TakeExam") Is Nothing Then
            Dim btnCol As New DataGridViewButtonColumn()
            btnCol.HeaderText = "Take Exam"
            btnCol.Name = "TakeExam"
            btnCol.Text = "Take Exam"
            btnCol.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(btnCol)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns("TakeExam").Index AndAlso e.RowIndex >= 0 Then
            Dim courseName As String = DataGridView1.Rows(e.RowIndex).Cells("course_name").Value.ToString()
            Dim assessmentTypeName As String = DataGridView1.Rows(e.RowIndex).Cells("assessment_type_name").Value.ToString()

            ' Assuming course_id and assessment_type_id can be retrieved from courseName and assessmentTypeName
            Dim courseId As Integer = GetCourseId(courseName)
            Dim assessmentTypeId As Integer = GetAssessmentTypeId(assessmentTypeName)

            Dim frm As New frmTakeExam(currentStudentId, courseId, assessmentTypeId, courseName, assessmentTypeName)
            frm.ShowDialog()
        End If
    End Sub

    Private Function GetCourseId(courseName As String) As Integer
        Dim query As String = "SELECT course_id FROM courses WHERE course_name = @course_name"
        Dim params As New Dictionary(Of String, Object) From {
            {"@course_name", courseName}
        }
        Return Convert.ToInt32(DatabaseModule.ExecuteScalar(query, params))
    End Function

    Private Function GetAssessmentTypeId(assessmentTypeName As String) As Integer
        Dim query As String = "SELECT assessment_type_id FROM assessment_types WHERE assessment_type_name = @assessment_type_name"
        Dim params As New Dictionary(Of String, Object) From {
            {"@assessment_type_name", assessmentTypeName}
        }
        Return Convert.ToInt32(DatabaseModule.ExecuteScalar(query, params))
    End Function
End Class