<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrationStudentView
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
        btnBack = New Button()
        chGender = New CheckedListBox()
        txtEmail = New TextBox()
        txtContactNo = New TextBox()
        dateOfBirth = New DateTimePicker()
        txtMiddlename = New TextBox()
        txtFirstname = New TextBox()
        txtLastname = New TextBox()
        btnRegister = New Button()
        cmbSection = New ComboBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(39, 347)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 20
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' chGender
        ' 
        chGender.FormattingEnabled = True
        chGender.Items.AddRange(New Object() {"Male" & vbTab, "Female"})
        chGender.Location = New Point(39, 199)
        chGender.Name = "chGender"
        chGender.Size = New Size(225, 48)
        chGender.TabIndex = 19
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(37, 253)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(227, 27)
        txtEmail.TabIndex = 18
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(37, 286)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(227, 27)
        txtContactNo.TabIndex = 17
        ' 
        ' dateOfBirth
        ' 
        dateOfBirth.Location = New Point(38, 165)
        dateOfBirth.Name = "dateOfBirth"
        dateOfBirth.Size = New Size(250, 27)
        dateOfBirth.TabIndex = 16
        ' 
        ' txtMiddlename
        ' 
        txtMiddlename.Location = New Point(37, 132)
        txtMiddlename.Name = "txtMiddlename"
        txtMiddlename.Size = New Size(227, 27)
        txtMiddlename.TabIndex = 15
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Location = New Point(37, 99)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(227, 27)
        txtFirstname.TabIndex = 14
        ' 
        ' txtLastname
        ' 
        txtLastname.Location = New Point(37, 66)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(227, 27)
        txtLastname.TabIndex = 13
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(158, 347)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(94, 29)
        btnRegister.TabIndex = 12
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' cmbSection
        ' 
        cmbSection.FormattingEnabled = True
        cmbSection.Location = New Point(432, 66)
        cmbSection.Name = "cmbSection"
        cmbSection.Size = New Size(151, 28)
        cmbSection.TabIndex = 11
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(456, 199)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(125, 27)
        txtPassword.TabIndex = 22
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(456, 157)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(125, 27)
        txtUsername.TabIndex = 21
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9})
        DataGridView1.Location = New Point(342, 314)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(570, 188)
        DataGridView1.TabIndex = 23
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Column1"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Column2"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Column3"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Column4"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Column5"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Column6"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Column7"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Column8"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Column9"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 125
        ' 
        ' frmRegistrationStudentView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(951, 557)
        ControlBox = False
        Controls.Add(DataGridView1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(btnBack)
        Controls.Add(chGender)
        Controls.Add(txtEmail)
        Controls.Add(txtContactNo)
        Controls.Add(dateOfBirth)
        Controls.Add(txtMiddlename)
        Controls.Add(txtFirstname)
        Controls.Add(txtLastname)
        Controls.Add(btnRegister)
        Controls.Add(cmbSection)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmRegistrationStudentView"
        StartPosition = FormStartPosition.CenterScreen
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents chGender As CheckedListBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents dateOfBirth As DateTimePicker
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
