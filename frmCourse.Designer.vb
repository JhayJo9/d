<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourse
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
        txtCourseTitle = New TextBox()
        txtCourseCode = New TextBox()
        btnBack = New Button()
        btnAdd = New Button()
        SuspendLayout()
        ' 
        ' txtCourseTitle
        ' 
        txtCourseTitle.Location = New Point(63, 66)
        txtCourseTitle.Name = "txtCourseTitle"
        txtCourseTitle.Size = New Size(387, 27)
        txtCourseTitle.TabIndex = 0
        ' 
        ' txtCourseCode
        ' 
        txtCourseCode.Location = New Point(63, 135)
        txtCourseCode.Name = "txtCourseCode"
        txtCourseCode.Size = New Size(387, 27)
        txtCourseCode.TabIndex = 1
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(63, 192)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 2
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(181, 192)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 3
        btnAdd.Text = "SAVE"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' frmCourse
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 262)
        ControlBox = False
        Controls.Add(btnAdd)
        Controls.Add(btnBack)
        Controls.Add(txtCourseCode)
        Controls.Add(txtCourseTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmCourse"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCourseTitle As TextBox
    Friend WithEvents txtCourseCode As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAdd As Button
End Class
