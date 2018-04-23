'INSTANT C# NOTE: Formerly VB project-level imports:
Imports System.Collections.Generic
Imports System.Collections
Imports System.Diagnostics
Imports System.Linq
Imports System.Xml.Linq
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System

Imports System.ComponentModel
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraBars.Customization
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraBars
Imports System.Reflection
Imports DevExpress.XtraBars.Utils

Namespace T191208
    Partial Public Class CustomCustomizationControl
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.tpOptions.SuspendLayout()
            Me.tpCommands.SuspendLayout()
            Me.tpToolbars.SuspendLayout()
            DirectCast(Me.toolBarsList, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lbCommands, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lbCategories, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbOptionsShowFullMenus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbOptions_showFullMenusAfterDelay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbOptions_showTips.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbOptions_ShowShortcutInTips.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControl.SuspendLayout()
            DirectCast(Me.tbNBDlgName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlNBDlg.SuspendLayout()
            DirectCast(Me.cbOptions_largeIcons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbOptions_MenuAnimation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage1.SuspendLayout()
            DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' btClose
            ' 
            Me.btClose.Location = New System.Drawing.Point(839, 587)
            ' 
            ' tpOptions
            ' 
            Me.tpOptions.Size = New System.Drawing.Size(942, 543)
            ' 
            ' tpCommands
            ' 
            Me.tpCommands.Size = New System.Drawing.Size(942, 543)
            ' 
            ' tpToolbars
            ' 
            Me.tpToolbars.Size = New System.Drawing.Size(942, 543)
            ' 
            ' lbDescription
            ' 
            Me.lbDescription.Appearance.BackColor = System.Drawing.Color.Transparent
            ' 
            ' lbCommands
            ' 
            Me.lbCommands.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbCommands.Appearance.Options.UseBackColor = True
            ' 
            ' cbOptionsShowFullMenus
            ' 
            ' 
            ' cbOptions_showFullMenusAfterDelay
            ' 
            ' 
            ' cbOptions_showTips
            ' 
            ' 
            ' cbOptions_ShowShortcutInTips
            ' 
            ' 
            ' lbOptions_Other
            ' 
            Me.lbOptions_Other.Appearance.BackColor = System.Drawing.Color.Transparent
            ' 
            ' lbOptions_PCaption
            ' 
            Me.lbOptions_PCaption.Appearance.BackColor = System.Drawing.Color.Transparent
            ' 
            ' tabControl
            ' 
            Me.tabControl.Size = New System.Drawing.Size(948, 571)
            Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
            Me.tabControl.Controls.SetChildIndex(Me.xtraTabPage1, 0)
            Me.tabControl.Controls.SetChildIndex(Me.tpOptions, 0)
            Me.tabControl.Controls.SetChildIndex(Me.tpToolbars, 0)
            Me.tabControl.Controls.SetChildIndex(Me.tpCommands, 0)
            ' 
            ' tbNBDlgName
            ' 
            ' 
            ' cbOptions_largeIcons
            ' 
            ' 
            ' cbOptions_MenuAnimation
            ' 
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.treeList1)
            Me.xtraTabPage1.Controls.Add(Me.gridControl2)
            Me.xtraTabPage1.Controls.Add(Me.gridControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(942, 543)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            ' 
            ' treeList1
            ' 
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2})
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(286, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.Size = New System.Drawing.Size(366, 543)
            Me.treeList1.TabIndex = 2
            ' 
            ' treeListColumn1
            ' 
            Me.treeListColumn1.Caption = "Name"
            Me.treeListColumn1.FieldName = "Name"
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.OptionsColumn.AllowEdit = False
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            ' 
            ' treeListColumn2
            ' 
            Me.treeListColumn2.Caption = "Caption"
            Me.treeListColumn2.FieldName = "Caption"
            Me.treeListColumn2.Name = "treeListColumn2"
            Me.treeListColumn2.Visible = True
            Me.treeListColumn2.VisibleIndex = 1
            ' 
            ' gridControl2
            ' 
            Me.gridControl2.AllowDrop = True
            Me.gridControl2.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Right
            Me.gridControl2.Location = New System.Drawing.Point(652, 0)
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.Size = New System.Drawing.Size(290, 543)
            Me.gridControl2.TabIndex = 1
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
            ' 
            ' gridView2
            ' 
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2})
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.Name = "gridView2"
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.FieldName = "Name"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.OptionsColumn.AllowEdit = False
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.FieldName = "Caption"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.OptionsColumn.AllowEdit = False
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(286, 543)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn3, Me.gridColumn4, Me.gridColumn5})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' gridColumn3
            ' 
            Me.gridColumn3.FieldName = "Name"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.OptionsColumn.AllowEdit = False
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 0
            ' 
            ' gridColumn4
            ' 
            Me.gridColumn4.FieldName = "Caption"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 1
            ' 
            ' gridColumn5
            ' 
            Me.gridColumn5.FieldName = "Glyph"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 2
            ' 
            ' CustomCustomizationControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "CustomCustomizationControl"
            Me.Size = New System.Drawing.Size(956, 621)
            Me.tpOptions.ResumeLayout(False)
            Me.tpOptions.PerformLayout()
            Me.tpCommands.ResumeLayout(False)
            Me.tpCommands.PerformLayout()
            Me.tpToolbars.ResumeLayout(False)
            Me.tpToolbars.PerformLayout()
            DirectCast(Me.toolBarsList, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lbCommands, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lbCategories, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbOptionsShowFullMenus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbOptions_showFullMenusAfterDelay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbOptions_showTips.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbOptions_ShowShortcutInTips.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControl.ResumeLayout(False)
            DirectCast(Me.tbNBDlgName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlNBDlg.ResumeLayout(False)
            DirectCast(Me.cbOptions_largeIcons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbOptions_MenuAnimation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage1.ResumeLayout(False)
            DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Private gridControl2 As DevExpress.XtraGrid.GridControl
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Private treeList1 As DevExpress.XtraTreeList.TreeList
        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
