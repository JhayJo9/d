Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmQuestion

    Private Sub frmAddQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the courses and assessment types into the combo boxes when the form loads
        LoadCourses()
        LoadAssessmentTypes()
    End Sub

    Public Sub ClearFields()
        ' Clear all the input fields
        txtQuestion.Text = ""
        txtOptionA.Text = ""
        txtOptionB.Text = ""
        txtOptionC.Text = ""
        txtOptionD.Text = ""
        cmbCorrectAnswer.SelectedIndex = -1
    End Sub

    Private Sub LoadCourses()
        ' Load courses into the cmbCourse combo box
        cmbCourse.Items.Clear()
        Dim query As String = "SELECT * FROM courses"
        Dim dt As New DataTable()

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If

        cmbCourse.DataSource = dt
        cmbCourse.DisplayMember = "course_code"
        cmbCourse.ValueMember = "course_id"
    End Sub

    Private Sub LoadAssessmentTypes()
        ' Load assessment types into the cmbAssessmentType combo box
        cmbAssessmentType.Items.Clear()
        Dim query As String = "SELECT * FROM assessment_types"
        Dim dt As New DataTable()

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If

        cmbAssessmentType.DataSource = dt
        cmbAssessmentType.DisplayMember = "assessment_type_name"
        cmbAssessmentType.ValueMember = "assessment_type_id"
    End Sub

    Public Sub Insert_Data()
        Try
            ' Validate that all fields are filled before inserting data
            If String.IsNullOrWhiteSpace(txtQuestion.Text) Then
                MessageBox.Show("Please enter a question.")
                Return
            End If

            If String.IsNullOrWhiteSpace(txtOptionA.Text) Then
                MessageBox.Show("Please enter option A.")
                Return
            End If

            If String.IsNullOrWhiteSpace(txtOptionB.Text) Then
                MessageBox.Show("Please enter option B.")
                Return
            End If

            If String.IsNullOrWhiteSpace(txtOptionC.Text) Then
                MessageBox.Show("Please enter option C.")
                Return
            End If

            If String.IsNullOrWhiteSpace(txtOptionD.Text) Then
                MessageBox.Show("Please enter option D.")
                Return
            End If

            If cmbCorrectAnswer.SelectedIndex = -1 Then
                MessageBox.Show("Please select the correct answer.")
                Return
            End If

            Dim courseId As Integer = Convert.ToInt32(cmbCourse.SelectedValue)
            Dim assessmentTypeId As Integer = Convert.ToInt32(cmbAssessmentType.SelectedValue)
            Dim questionText As String = txtQuestion.Text
            Dim optionA As String = txtOptionA.Text
            Dim optionB As String = txtOptionB.Text
            Dim optionC As String = txtOptionC.Text
            Dim optionD As String = txtOptionD.Text
            Dim correctAnswer As String = cmbCorrectAnswer.SelectedItem.ToString()

            Dim query As String = "INSERT INTO questions (course_id, assessment_type_id, question_text, optiona, optionb, optionc, optiond, correct_answer) " &
                                  "VALUES (@course_id, @assessment_type_id, @question_text, @optiona, @optionb, @optionc, @optiond, @correct_answer)"

            If DatabaseModule.openconnection() Then
                Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                    ' Add parameters to the command
                    cmd.Parameters.AddWithValue("@course_id", courseId)
                    cmd.Parameters.AddWithValue("@assessment_type_id", assessmentTypeId)
                    cmd.Parameters.AddWithValue("@question_text", questionText)
                    cmd.Parameters.AddWithValue("@optiona", optionA)
                    cmd.Parameters.AddWithValue("@optionb", optionB)
                    cmd.Parameters.AddWithValue("@optionc", optionC)
                    cmd.Parameters.AddWithValue("@optiond", optionD)
                    cmd.Parameters.AddWithValue("@correct_answer", correctAnswer)

                    ' Execute the command
                    cmd.ExecuteNonQuery()
                End Using
                DatabaseModule.closeconnection()
            End If
            MessageBox.Show("Question added successfully!")
            With frmQuestionList
                .ShowDialog()
            End With
            ClearFields()
        Catch ex As Exception
            MsgBox("INSERTING QUESTION: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddQuestion_Click(sender As Object, e As EventArgs) Handles btnAddQuestion.Click
        ' Call the Insert_Data function when the Add Question button is clicked
        Insert_Data()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class