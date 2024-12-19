<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminDashboard
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
        Panel1 = New Panel()
        btnAssess = New Button()
        Button4 = New Button()
        Button3 = New Button()
        btnQuestions = New Button()
        Button1 = New Button()
        btnCourse = New Button()
        dh = New Panel()
        Button2 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(btnAssess)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(btnQuestions)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnCourse)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(252, 716)
        Panel1.TabIndex = 0
        ' 
        ' btnAssess
        ' 
        btnAssess.Font = New Font("Calibri", 10.8F, FontStyle.Bold)
        btnAssess.Location = New Point(46, 254)
        btnAssess.Name = "btnAssess"
        btnAssess.Size = New Size(154, 41)
        btnAssess.TabIndex = 6
        btnAssess.Text = "Assign Sections"
        btnAssess.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Calibri", 10.8F, FontStyle.Bold)
        Button4.Location = New Point(46, 217)
        Button4.Name = "Button4"
        Button4.Size = New Size(154, 41)
        Button4.TabIndex = 5
        Button4.Text = "Register Student"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Calibri", 10.8F, FontStyle.Bold)
        Button3.Location = New Point(46, 75)
        Button3.Name = "Button3"
        Button3.Size = New Size(154, 41)
        Button3.TabIndex = 4
        Button3.Text = "Dashboard"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btnQuestions
        ' 
        btnQuestions.Font = New Font("Calibri", 10.8F, FontStyle.Bold)
        btnQuestions.Location = New Point(46, 180)
        btnQuestions.Name = "btnQuestions"
        btnQuestions.Size = New Size(154, 41)
        btnQuestions.TabIndex = 3
        btnQuestions.Text = "Questions"
        btnQuestions.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Calibri", 10.8F, FontStyle.Bold)
        Button1.Location = New Point(46, 144)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 41)
        Button1.TabIndex = 2
        Button1.Text = "Section"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnCourse
        ' 
        btnCourse.Font = New Font("Calibri", 10.8F, FontStyle.Bold)
        btnCourse.Location = New Point(46, 110)
        btnCourse.Name = "btnCourse"
        btnCourse.Size = New Size(154, 41)
        btnCourse.TabIndex = 1
        btnCourse.Text = "Course"
        btnCourse.UseVisualStyleBackColor = True
        ' 
        ' dh
        ' 
        dh.Dock = DockStyle.Fill
        dh.Location = New Point(252, 0)
        dh.Name = "dh"
        dh.Size = New Size(982, 716)
        dh.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(56, 473)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 7
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' frmAdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1234, 716)
        ControlBox = False
        Controls.Add(dh)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmAdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnQuestions As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCourse As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents dh As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnAssess As Button
    Friend WithEvents Button2 As Button
End Class
