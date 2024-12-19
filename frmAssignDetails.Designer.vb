<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignDetails
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
        btnAddAssignment = New Button()
        btnRemoveAssignment = New Button()
        btnSaveAssignments = New Button()
        Panel1 = New Panel()
        dgvAssignments = New DataGridView()
        Section = New DataGridViewTextBoxColumn()
        Course = New DataGridViewTextBoxColumn()
        Assessment_Type = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(dgvAssignments, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbSections
        ' 
        cmbSections.FormattingEnabled = True
        cmbSections.Location = New Point(59, 64)
        cmbSections.Name = "cmbSections"
        cmbSections.Size = New Size(151, 28)
        cmbSections.TabIndex = 0
        ' 
        ' cmbCourses
        ' 
        cmbCourses.FormattingEnabled = True
        cmbCourses.Location = New Point(59, 98)
        cmbCourses.Name = "cmbCourses"
        cmbCourses.Size = New Size(151, 28)
        cmbCourses.TabIndex = 1
        ' 
        ' cmbAssessmentTypes
        ' 
        cmbAssessmentTypes.FormattingEnabled = True
        cmbAssessmentTypes.Location = New Point(59, 132)
        cmbAssessmentTypes.Name = "cmbAssessmentTypes"
        cmbAssessmentTypes.Size = New Size(151, 28)
        cmbAssessmentTypes.TabIndex = 2
        ' 
        ' btnAddAssignment
        ' 
        btnAddAssignment.Location = New Point(543, 120)
        btnAddAssignment.Name = "btnAddAssignment"
        btnAddAssignment.Size = New Size(94, 29)
        btnAddAssignment.TabIndex = 4
        btnAddAssignment.Text = "ADD NEW"
        btnAddAssignment.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveAssignment
        ' 
        btnRemoveAssignment.Location = New Point(643, 120)
        btnRemoveAssignment.Name = "btnRemoveAssignment"
        btnRemoveAssignment.Size = New Size(94, 29)
        btnRemoveAssignment.TabIndex = 5
        btnRemoveAssignment.Text = "DELETE"
        btnRemoveAssignment.UseVisualStyleBackColor = True
        ' 
        ' btnSaveAssignments
        ' 
        btnSaveAssignments.Location = New Point(743, 120)
        btnSaveAssignments.Name = "btnSaveAssignments"
        btnSaveAssignments.Size = New Size(94, 29)
        btnSaveAssignments.TabIndex = 6
        btnSaveAssignments.Text = "SAVE"
        btnSaveAssignments.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(btnSaveAssignments)
        Panel1.Controls.Add(dgvAssignments)
        Panel1.Controls.Add(btnRemoveAssignment)
        Panel1.Controls.Add(btnAddAssignment)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(877, 509)
        Panel1.TabIndex = 7
        ' 
        ' dgvAssignments
        ' 
        dgvAssignments.AllowUserToAddRows = False
        dgvAssignments.AllowUserToDeleteRows = False
        dgvAssignments.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAssignments.Columns.AddRange(New DataGridViewColumn() {Section, Course, Assessment_Type})
        dgvAssignments.Location = New Point(47, 162)
        dgvAssignments.Name = "dgvAssignments"
        dgvAssignments.RowHeadersVisible = False
        dgvAssignments.RowHeadersWidth = 51
        dgvAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAssignments.Size = New Size(796, 321)
        dgvAssignments.TabIndex = 8
        ' 
        ' Section
        ' 
        Section.HeaderText = "Section"
        Section.MinimumWidth = 6
        Section.Name = "Section"
        ' 
        ' Course
        ' 
        Course.HeaderText = "Course"
        Course.MinimumWidth = 6
        Course.Name = "Course"
        ' 
        ' Assessment_Type
        ' 
        Assessment_Type.HeaderText = "Assessment Type"
        Assessment_Type.MinimumWidth = 6
        Assessment_Type.Name = "Assessment_Type"
        ' 
        ' frmAssignDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(901, 533)
        ControlBox = False
        Controls.Add(cmbAssessmentTypes)
        Controls.Add(cmbCourses)
        Controls.Add(cmbSections)
        Controls.Add(Panel1)
        Name = "frmAssignDetails"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(dgvAssignments, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbSections As ComboBox
    Friend WithEvents cmbCourses As ComboBox
    Friend WithEvents cmbAssessmentTypes As ComboBox
    Friend WithEvents btnAddAssignment As Button
    Friend WithEvents btnRemoveAssignment As Button
    Friend WithEvents btnSaveAssignments As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvAssignments As DataGridView
    Friend WithEvents Section As DataGridViewTextBoxColumn
    Friend WithEvents Course As DataGridViewTextBoxColumn
    Friend WithEvents Assessment_Type As DataGridViewTextBoxColumn
End Class
