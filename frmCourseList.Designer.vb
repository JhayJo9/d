<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourseList
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
        dgwCourseList = New DataGridView()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewImageColumn()
        Column5 = New DataGridViewImageColumn()
        Column6 = New DataGridViewImageColumn()
        btnAddNew = New Button()
        txtSearch = New TextBox()
        CType(dgwCourseList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgwCourseList
        ' 
        dgwCourseList.AllowUserToAddRows = False
        dgwCourseList.AllowUserToDeleteRows = False
        dgwCourseList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgwCourseList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgwCourseList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgwCourseList.Columns.AddRange(New DataGridViewColumn() {Column2, Column3, Column4, Column5, Column6})
        dgwCourseList.Location = New Point(12, 41)
        dgwCourseList.Name = "dgwCourseList"
        dgwCourseList.RowHeadersVisible = False
        dgwCourseList.RowHeadersWidth = 51
        dgwCourseList.Size = New Size(836, 437)
        dgwCourseList.TabIndex = 0
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Course Title"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Course Code"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Edit"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 41
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Delete"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 59
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "View"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 47
        ' 
        ' btnAddNew
        ' 
        btnAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddNew.Location = New Point(754, 6)
        btnAddNew.Name = "btnAddNew"
        btnAddNew.Size = New Size(94, 29)
        btnAddNew.TabIndex = 1
        btnAddNew.Text = "ADD NEW"
        btnAddNew.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSearch.Location = New Point(567, 8)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(181, 27)
        txtSearch.TabIndex = 2
        ' 
        ' frmCourseList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(860, 488)
        ControlBox = False
        Controls.Add(txtSearch)
        Controls.Add(btnAddNew)
        Controls.Add(dgwCourseList)
        Name = "frmCourseList"
        WindowState = FormWindowState.Maximized
        CType(dgwCourseList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgwCourseList As DataGridView
    Friend WithEvents btnAddNew As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
End Class
