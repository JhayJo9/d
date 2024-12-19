<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignStudent
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
        cmbSections = New ComboBox()
        cmbCourses = New ComboBox()
        cmbAssessmentTypes = New ComboBox()
        cmbQuestions = New ComboBox()
        dgvAssignments = New DataGridView()
        btnAddAssignment = New Button()
        btnRemoveAssignment = New Button()
        btnSaveAssignments = New Button()
        Section = New DataGridViewTextBoxColumn()
        Course = New DataGridViewTextBoxColumn()
        Assessment_Type = New DataGridViewTextBoxColumn()
        CType(dgvAssignments, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbSections
        ' 
        cmbSections.FormattingEnabled = True
        cmbSections.Location = New Point(33, 33)
        cmbSections.Name = "cmbSections"
        cmbSections.Size = New Size(151, 28)
        cmbSections.TabIndex = 0
        ' 
        ' cmbCourses
        ' 
        cmbCourses.FormattingEnabled = True
        cmbCourses.Location = New Point(33, 67)
        cmbCourses.Name = "cmbCourses"
        cmbCourses.Size = New Size(151, 28)
        cmbCourses.TabIndex = 1
        ' 
        ' cmbAssessmentTypes
        ' 
        cmbAssessmentTypes.FormattingEnabled = True
        cmbAssessmentTypes.Location = New Point(33, 101)
        cmbAssessmentTypes.Name = "cmbAssessmentTypes"
        cmbAssessmentTypes.Size = New Size(151, 28)
        cmbAssessmentTypes.TabIndex = 2
        ' 
        ' cmbQuestions
        ' 
        cmbQuestions.FormattingEnabled = True
        cmbQuestions.Location = New Point(33, 135)
        cmbQuestions.Name = "cmbQuestions"
        cmbQuestions.Size = New Size(151, 28)
        cmbQuestions.TabIndex = 3
        ' 
        ' dgvAssignments
        ' 
        dgvAssignments.AllowUserToAddRows = False
        dgvAssignments.AllowUserToDeleteRows = False
        dgvAssignments.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAssignments.Columns.AddRange(New DataGridViewColumn() {Section, Course, Assessment_Type})
        dgvAssignments.Location = New Point(34, 204)
        dgvAssignments.Name = "dgvAssignments"
        dgvAssignments.RowHeadersVisible = False
        dgvAssignments.RowHeadersWidth = 51
        dgvAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAssignments.Size = New Size(725, 188)
        dgvAssignments.TabIndex = 4
        ' 
        ' btnAddAssignment
        ' 
        btnAddAssignment.Location = New Point(279, 147)
        btnAddAssignment.Name = "btnAddAssignment"
        btnAddAssignment.Size = New Size(94, 29)
        btnAddAssignment.TabIndex = 5
        btnAddAssignment.Text = "Button1"
        btnAddAssignment.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveAssignment
        ' 
        btnRemoveAssignment.Location = New Point(379, 147)
        btnRemoveAssignment.Name = "btnRemoveAssignment"
        btnRemoveAssignment.Size = New Size(94, 29)
        btnRemoveAssignment.TabIndex = 6
        btnRemoveAssignment.Text = "Button2"
        btnRemoveAssignment.UseVisualStyleBackColor = True
        ' 
        ' btnSaveAssignments
        ' 
        btnSaveAssignments.Location = New Point(479, 147)
        btnSaveAssignments.Name = "btnSaveAssignments"
        btnSaveAssignments.Size = New Size(94, 29)
        btnSaveAssignments.TabIndex = 7
        btnSaveAssignments.Text = "Button3"
        btnSaveAssignments.UseVisualStyleBackColor = True
        ' 
        ' Section
        ' 
        Section.HeaderText = "section"
        Section.MinimumWidth = 6
        Section.Name = "Section"
        Section.Width = 125
        ' 
        ' Course
        ' 
        Course.HeaderText = "course"
        Course.MinimumWidth = 6
        Course.Name = "Course"
        Course.Width = 125
        ' 
        ' Assessment_Type
        ' 
        Assessment_Type.HeaderText = "assessmentType"
        Assessment_Type.MinimumWidth = 6
        Assessment_Type.Name = "Assessment_Type"
        Assessment_Type.Width = 125
        ' 
        ' frmAssignStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(btnSaveAssignments)
        Controls.Add(btnRemoveAssignment)
        Controls.Add(btnAddAssignment)
        Controls.Add(dgvAssignments)
        Controls.Add(cmbQuestions)
        Controls.Add(cmbAssessmentTypes)
        Controls.Add(cmbCourses)
        Controls.Add(cmbSections)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmAssignStudent"
        WindowState = FormWindowState.Maximized
        CType(dgvAssignments, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbSections As ComboBox
    Friend WithEvents cmbCourses As ComboBox
    Friend WithEvents cmbAssessmentTypes As ComboBox
    Friend WithEvents cmbQuestions As ComboBox
    Friend WithEvents dgvAssignments As DataGridView
    Friend WithEvents btnAddAssignment As Button
    Friend WithEvents btnRemoveAssignment As Button
    Friend WithEvents btnSaveAssignments As Button
    Friend WithEvents Section As DataGridViewTextBoxColumn
    Friend WithEvents Course As DataGridViewTextBoxColumn
    Friend WithEvents Assessment_Type As DataGridViewTextBoxColumn
End Class
