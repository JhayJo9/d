Public Class frmAdminDashboard
    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        With frmCourseList
            .TopLevel = False
            dh.Controls.Add(frmCourseList)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmSectionList
            .TopLevel = False
            dh.Controls.Add(frmSectionList)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnQuestions_Click(sender As Object, e As EventArgs) Handles btnQuestions.Click
        With frmQuestionList
            .TopLevel = False
            dh.Controls.Add(frmQuestionList)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With frmRegisterStudentList
            .TopLevel = False
            dh.Controls.Add(frmRegisterStudentList)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnAssess_Click(sender As Object, e As EventArgs) Handles btnAssess.Click
        With frmAssignStudent
            .TopLevel = False
            dh.Controls.Add(frmAssignStudent)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        frmLogin.Show()
    End Sub
End Class