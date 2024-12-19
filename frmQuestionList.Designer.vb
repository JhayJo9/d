<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestionList
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
        dgwQuestionList = New DataGridView()
        txtSearch = New TextBox()
        btnAdddNew = New Button()
        Column10 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewImageColumn()
        Column5 = New DataGridViewImageColumn()
        Column6 = New DataGridViewImageColumn()
        CType(dgwQuestionList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgwQuestionList
        ' 
        dgwQuestionList.AllowUserToAddRows = False
        dgwQuestionList.AllowUserToDeleteRows = False
        dgwQuestionList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgwQuestionList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgwQuestionList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgwQuestionList.Columns.AddRange(New DataGridViewColumn() {Column10, Column2, Column3, Column7, Column8, Column9, Column11, Column12, Column4, Column5, Column6})
        dgwQuestionList.Location = New Point(12, 41)
        dgwQuestionList.Name = "dgwQuestionList"
        dgwQuestionList.RowHeadersVisible = False
        dgwQuestionList.RowHeadersWidth = 51
        dgwQuestionList.Size = New Size(1202, 409)
        dgwQuestionList.TabIndex = 6
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSearch.Location = New Point(933, 8)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(181, 27)
        txtSearch.TabIndex = 8
        ' 
        ' btnAdddNew
        ' 
        btnAdddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdddNew.Location = New Point(1120, 6)
        btnAdddNew.Name = "btnAdddNew"
        btnAdddNew.Size = New Size(94, 29)
        btnAdddNew.TabIndex = 7
        btnAdddNew.Text = "ADD NEW"
        btnAdddNew.UseVisualStyleBackColor = True
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Question"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Option A"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Option B"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Option C"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Option D"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "Correct Answer"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 138
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Course Code"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Assessment Type"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Edit"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Delete"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "View"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        ' 
        ' frmQuestionList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1226, 462)
        ControlBox = False
        Controls.Add(dgwQuestionList)
        Controls.Add(txtSearch)
        Controls.Add(btnAdddNew)
        Name = "frmQuestionList"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        CType(dgwQuestionList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgwQuestionList As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAdddNew As Button
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
End Class
