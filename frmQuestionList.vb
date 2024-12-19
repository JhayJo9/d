Imports MySql.Data.MySqlClient

Public Class frmQuestionList
    Private Sub frmQuestionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_Data()
    End Sub

    Public Sub Get_Data()
        Try
            If DatabaseModule.openconnection() Then
                ' Update the query to include joins with the courses, assessment_types, and section_assignments tables
                Dim query As String = "SELECT q.question_text, q.optiona, q.optionb, q.optionc, q.optiond, q.correct_answer, " &
                                      "c.course_code,at.assessment_type_name " &
                                      "FROM questions q " &
                                      "JOIN courses c ON q.course_id = c.course_id " &
                                      "JOIN assessment_types at ON q.assessment_type_id = at.assessment_type_id " &
                                      "JOIN section_assignments sa ON q.course_id = sa.course_id AND q.assessment_type_id = sa.assessment_type_id " &
                                      "JOIN sections s ON sa.section_id = s.section_id"
                Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                ' Retrieve the data from the reader
                                Dim question As String = reader.GetString("question_text")
                                Dim optiona As String = reader.GetString("optiona")
                                Dim optionb As String = reader.GetString("optionb")
                                Dim optionc As String = reader.GetString("optionc")
                                Dim optiond As String = reader.GetString("optiond")
                                Dim correct_answer As String = reader.GetString("correct_answer")
                                Dim course_name As String = reader.GetString("course_code")
                                Dim assessment_type_name As String = reader.GetString("assessment_type_name")
                                'Dim section_name As String = reader.GetString("section_name")

                                ' Add the data to the DataGridView
                                dgwQuestionList.Rows.Add(question, optiona, optionb, optionc, optiond, correct_answer, course_name, assessment_type_name)
                            End While
                        End If
                    End Using
                End Using
                DatabaseModule.closeconnection()
            End If
        Catch ex As Exception
            MsgBox("GETTING QUESTIONS: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdddNew.Click
        With frmQuestion
            .ShowDialog()
        End With
    End Sub

    Private Sub dgwQuestionList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwQuestionList.CellContentClick

    End Sub
End Class