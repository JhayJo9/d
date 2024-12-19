<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterStudentList
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
        dgwStudentList = New DataGridView()
        Column10 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewImageColumn()
        Column5 = New DataGridViewImageColumn()
        Column6 = New DataGridViewImageColumn()
        txtSearch = New TextBox()
        btnAddNew = New Button()
        CType(dgwStudentList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgwStudentList
        ' 
        dgwStudentList.AllowUserToAddRows = False
        dgwStudentList.AllowUserToDeleteRows = False
        dgwStudentList.AllowUserToResizeColumns = False
        dgwStudentList.AllowUserToResizeRows = False
        dgwStudentList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgwStudentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        dgwStudentList.ColumnHeadersHeight = 29
        dgwStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgwStudentList.Columns.AddRange(New DataGridViewColumn() {Column10, Column1, Column2, Column3, Column7, Column8, Column9, Column11, Column12, Column13, Column14, Column4, Column5, Column6})
        dgwStudentList.Location = New Point(21, 52)
        dgwStudentList.Name = "dgwStudentList"
        dgwStudentList.ReadOnly = True
        dgwStudentList.RowHeadersVisible = False
        dgwStudentList.RowHeadersWidth = 51
        dgwStudentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgwStudentList.Size = New Size(1034, 437)
        dgwStudentList.TabIndex = 3
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Student ID"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 108
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Section Code"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 126
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Lastname"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 101
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Firstname"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 102
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Middlename"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 122
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Date of Birth"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 123
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Gender"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 86
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Email Address"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 132
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Contact No."
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Width = 116
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "username"
        Column13.MinimumWidth = 6
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        Column13.Width = 102
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "password"
        Column14.MinimumWidth = 6
        Column14.Name = "Column14"
        Column14.ReadOnly = True
        Column14.Width = 101
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Edit"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 41
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Delete"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 59
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "View"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 47
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSearch.Font = New Font("Calibri", 10.2F)
        txtSearch.Location = New Point(777, 19)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(181, 28)
        txtSearch.TabIndex = 5
        ' 
        ' btnAddNew
        ' 
        btnAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddNew.Font = New Font("Calibri", 10.2F)
        btnAddNew.Location = New Point(964, 17)
        btnAddNew.Name = "btnAddNew"
        btnAddNew.Size = New Size(94, 29)
        btnAddNew.TabIndex = 4
        btnAddNew.Text = "ADD NEW"
        btnAddNew.UseVisualStyleBackColor = True
        ' 
        ' frmRegisterStudentList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1075, 507)
        ControlBox = False
        Controls.Add(dgwStudentList)
        Controls.Add(txtSearch)
        Controls.Add(btnAddNew)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmRegisterStudentList"
        StartPosition = FormStartPosition.Manual
        WindowState = FormWindowState.Maximized
        CType(dgwStudentList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgwStudentList As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
End Class
