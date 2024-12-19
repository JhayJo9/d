<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSectionList
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
        dgwSectionList = New DataGridView()
        txtSearch = New TextBox()
        Button1 = New Button()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewImageColumn()
        Column5 = New DataGridViewImageColumn()
        Column6 = New DataGridViewImageColumn()
        CType(dgwSectionList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgwSectionList
        ' 
        dgwSectionList.AllowUserToAddRows = False
        dgwSectionList.AllowUserToDeleteRows = False
        dgwSectionList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgwSectionList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgwSectionList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgwSectionList.Columns.AddRange(New DataGridViewColumn() {Column3, Column4, Column5, Column6})
        dgwSectionList.Location = New Point(12, 41)
        dgwSectionList.Name = "dgwSectionList"
        dgwSectionList.RowHeadersVisible = False
        dgwSectionList.RowHeadersWidth = 51
        dgwSectionList.Size = New Size(836, 437)
        dgwSectionList.TabIndex = 3
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSearch.Location = New Point(567, 8)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(181, 27)
        txtSearch.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.Location = New Point(754, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Section Code"
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
        ' frmSectionList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(860, 488)
        ControlBox = False
        Controls.Add(dgwSectionList)
        Controls.Add(txtSearch)
        Controls.Add(Button1)
        Name = "frmSectionList"
        WindowState = FormWindowState.Maximized
        CType(dgwSectionList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgwSectionList As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
End Class
