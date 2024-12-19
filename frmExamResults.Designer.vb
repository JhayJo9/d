<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamResults
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
        dgvResults = New DataGridView()
        lblStudentName = New Label()
        lblCourseName = New Label()
        lblAssessmentTypeName = New Label()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvResults
        ' 
        dgvResults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResults.Location = New Point(12, 92)
        dgvResults.Name = "dgvResults"
        dgvResults.RowHeadersWidth = 51
        dgvResults.Size = New Size(1080, 436)
        dgvResults.TabIndex = 0
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.Location = New Point(43, 9)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(53, 20)
        lblStudentName.TabIndex = 1
        lblStudentName.Text = "Label1"
        ' 
        ' lblCourseName
        ' 
        lblCourseName.AutoSize = True
        lblCourseName.Location = New Point(43, 29)
        lblCourseName.Name = "lblCourseName"
        lblCourseName.Size = New Size(53, 20)
        lblCourseName.TabIndex = 2
        lblCourseName.Text = "Label1"
        ' 
        ' lblAssessmentTypeName
        ' 
        lblAssessmentTypeName.AutoSize = True
        lblAssessmentTypeName.Location = New Point(43, 49)
        lblAssessmentTypeName.Name = "lblAssessmentTypeName"
        lblAssessmentTypeName.Size = New Size(53, 20)
        lblAssessmentTypeName.TabIndex = 3
        lblAssessmentTypeName.Text = "Label2"
        ' 
        ' frmExamResults
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1111, 540)
        ControlBox = False
        Controls.Add(lblAssessmentTypeName)
        Controls.Add(lblCourseName)
        Controls.Add(lblStudentName)
        Controls.Add(dgvResults)
        Name = "frmExamResults"
        WindowState = FormWindowState.Maximized
        CType(dgvResults, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblCourseName As Label
    Friend WithEvents lblAssessmentTypeName As Label
End Class
