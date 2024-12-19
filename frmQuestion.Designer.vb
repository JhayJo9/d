<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cmbAssessmentType = New ComboBox()
        cmbCourse = New ComboBox()
        cmbSection = New ComboBox()
        txtQuestion = New TextBox()
        txtOptionA = New TextBox()
        txtOptionB = New TextBox()
        txtOptionC = New TextBox()
        txtOptionD = New TextBox()
        cmbCorrectAnswer = New ComboBox()
        btnAddQuestion = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' cmbAssessmentType
        ' 
        cmbAssessmentType.FormattingEnabled = True
        cmbAssessmentType.Location = New Point(24, 130)
        cmbAssessmentType.Name = "cmbAssessmentType"
        cmbAssessmentType.Size = New Size(230, 28)
        cmbAssessmentType.TabIndex = 6
        ' 
        ' cmbCourse
        ' 
        cmbCourse.FormattingEnabled = True
        cmbCourse.Location = New Point(24, 84)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(230, 28)
        cmbCourse.TabIndex = 5
        ' 
        ' cmbSection
        ' 
        cmbSection.FormattingEnabled = True
        cmbSection.Location = New Point(24, 31)
        cmbSection.Name = "cmbSection"
        cmbSection.Size = New Size(230, 28)
        cmbSection.TabIndex = 4
        ' 
        ' txtQuestion
        ' 
        txtQuestion.Location = New Point(35, 193)
        txtQuestion.Multiline = True
        txtQuestion.Name = "txtQuestion"
        txtQuestion.Size = New Size(439, 92)
        txtQuestion.TabIndex = 7
        ' 
        ' txtOptionA
        ' 
        txtOptionA.Location = New Point(37, 301)
        txtOptionA.Name = "txtOptionA"
        txtOptionA.Size = New Size(437, 27)
        txtOptionA.TabIndex = 8
        ' 
        ' txtOptionB
        ' 
        txtOptionB.Location = New Point(37, 334)
        txtOptionB.Name = "txtOptionB"
        txtOptionB.Size = New Size(437, 27)
        txtOptionB.TabIndex = 9
        ' 
        ' txtOptionC
        ' 
        txtOptionC.Location = New Point(37, 367)
        txtOptionC.Name = "txtOptionC"
        txtOptionC.Size = New Size(437, 27)
        txtOptionC.TabIndex = 10
        ' 
        ' txtOptionD
        ' 
        txtOptionD.Location = New Point(37, 400)
        txtOptionD.Name = "txtOptionD"
        txtOptionD.Size = New Size(437, 27)
        txtOptionD.TabIndex = 11
        ' 
        ' cmbCorrectAnswer
        ' 
        cmbCorrectAnswer.FormattingEnabled = True
        cmbCorrectAnswer.Items.AddRange(New Object() {"A", "B", "C", "D"})
        cmbCorrectAnswer.Location = New Point(37, 433)
        cmbCorrectAnswer.Name = "cmbCorrectAnswer"
        cmbCorrectAnswer.Size = New Size(151, 28)
        cmbCorrectAnswer.TabIndex = 12
        ' 
        ' btnAddQuestion
        ' 
        btnAddQuestion.Location = New Point(154, 484)
        btnAddQuestion.Name = "btnAddQuestion"
        btnAddQuestion.Size = New Size(94, 29)
        btnAddQuestion.TabIndex = 13
        btnAddQuestion.Text = "SAVE"
        btnAddQuestion.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(37, 484)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 14
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmQuestion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(862, 600)
        ControlBox = False
        Controls.Add(btnBack)
        Controls.Add(btnAddQuestion)
        Controls.Add(cmbCorrectAnswer)
        Controls.Add(txtOptionD)
        Controls.Add(txtOptionC)
        Controls.Add(txtOptionB)
        Controls.Add(txtOptionA)
        Controls.Add(txtQuestion)
        Controls.Add(cmbAssessmentType)
        Controls.Add(cmbCourse)
        Controls.Add(cmbSection)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmQuestion"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbAssessmentType As ComboBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents txtOptionA As TextBox
    Friend WithEvents txtOptionB As TextBox
    Friend WithEvents txtOptionC As TextBox
    Friend WithEvents txtOptionD As TextBox
    Friend WithEvents cmbCorrectAnswer As ComboBox
    Friend WithEvents btnAddQuestion As Button
    Friend WithEvents btnBack As Button
End Class
