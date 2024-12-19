Public Class frmTakeExam

    Private currentStudentId As Integer
    Private currentCourseId As Integer
    Private currentAssessmentTypeId As Integer
    Private courseName As String
    Private assessmentTypeName As String
    Private questions As List(Of DataRow)
    Private currentQuestionIndex As Integer = 0
    Private studentResponses As Dictionary(Of Integer, String)

    Public Sub New(studentId As Integer, courseId As Integer, assessmentTypeId As Integer, course As String, assessmentType As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        currentStudentId = studentId
        currentCourseId = courseId
        currentAssessmentTypeId = assessmentTypeId
        courseName = course
        assessmentTypeName = assessmentType
        studentResponses = New Dictionary(Of Integer, String)()
    End Sub

    Private Sub frmTakeExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCourse.Text = "Course: " & courseName
        lblAssessmentType.Text = "Assessment Type: " & assessmentTypeName
        LoadExamQuestions()
        DisplayCurrentQuestion()
    End Sub

    Private Sub LoadExamQuestions()
        Dim query As String = "SELECT q.question_id, q.question_text, q.optiona, q.optionb, q.optionc, q.optiond " &
                              "FROM questions q " &
                              "JOIN section_assignments sa ON q.question_id = sa.question_id " &
                              "WHERE sa.course_id = @course_id AND sa.assessment_type_id = @assessment_type_id"

        Dim params As New Dictionary(Of String, Object) From {
            {"@course_id", currentCourseId},
            {"@assessment_type_id", currentAssessmentTypeId}
        }

        Dim dt As DataTable = DatabaseModule.GetData(query, params)
        questions = dt.AsEnumerable().ToList()
    End Sub

    Private Sub DisplayCurrentQuestion()
        If questions IsNot Nothing AndAlso questions.Count > 0 Then
            Dim question = questions(currentQuestionIndex)
            txtQuestion.Text = question("question_text").ToString()
            rbOptionA.Text = "A. " & question("optiona").ToString()
            rbOptionB.Text = "B. " & question("optionb").ToString()
            rbOptionC.Text = "C. " & question("optionc").ToString()
            rbOptionD.Text = "D. " & question("optiond").ToString()

            ' Load the saved response if available
            Dim questionId = Convert.ToInt32(question("question_id"))
            If studentResponses.ContainsKey(questionId) Then
                Dim savedAnswer = studentResponses(questionId)
                Select Case savedAnswer
                    Case "A" : rbOptionA.Checked = True
                    Case "B" : rbOptionB.Checked = True
                    Case "C" : rbOptionC.Checked = True
                    Case "D" : rbOptionD.Checked = True
                End Select
            Else
                rbOptionA.Checked = False
                rbOptionB.Checked = False
                rbOptionC.Checked = False
                rbOptionD.Checked = False
            End If
        End If
    End Sub

    Private Sub SaveCurrentResponse()
        If questions IsNot Nothing AndAlso questions.Count > 0 Then
            Dim questionId = Convert.ToInt32(questions(currentQuestionIndex)("question_id"))
            Dim selectedAnswer As String = String.Empty

            If rbOptionA.Checked Then
                selectedAnswer = "A"
            ElseIf rbOptionB.Checked Then
                selectedAnswer = "B"
            ElseIf rbOptionC.Checked Then
                selectedAnswer = "C"
            ElseIf rbOptionD.Checked Then
                selectedAnswer = "D"
            End If

            If studentResponses.ContainsKey(questionId) Then
                studentResponses(questionId) = selectedAnswer
            Else
                studentResponses.Add(questionId, selectedAnswer)
            End If
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        SaveCurrentResponse()
        If currentQuestionIndex > 0 Then
            currentQuestionIndex -= 1
            DisplayCurrentQuestion()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        SaveCurrentResponse()
        If currentQuestionIndex < questions.Count - 1 Then
            currentQuestionIndex += 1
            DisplayCurrentQuestion()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SaveCurrentResponse()
        For Each question In questions
            Dim questionId = Convert.ToInt32(question("question_id"))
            Dim selectedAnswer As String = If(studentResponses.ContainsKey(questionId), studentResponses(questionId), String.Empty)
            Dim correctAnswer As String = GetCorrectAnswer(questionId)
            Dim isCorrect As Boolean = (selectedAnswer = correctAnswer)

            Dim query As String = "INSERT INTO student_responses (student_id, question_id, selected_answer, is_correct) VALUES (@student_id, @question_id, @selected_answer, @is_correct)"
            Dim params As New Dictionary(Of String, Object) From {
                {"@student_id", currentStudentId},
                {"@question_id", questionId},
                {"@selected_answer", selectedAnswer},
                {"@is_correct", isCorrect}
            }

            DatabaseModule.ExecuteNonQuery(query, params)
        Next

        MessageBox.Show("Exam submitted successfully!")
        Me.Close()
    End Sub

    Private Function GetCorrectAnswer(questionId As Integer) As String
        Dim query As String = "SELECT correct_answer FROM questions WHERE question_id = @question_id"
        Dim params As New Dictionary(Of String, Object) From {
            {"@question_id", questionId}
        }
        Return DatabaseModule.ExecuteScalar(query, params).ToString()
    End Function
End Class