//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;

using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraBars;
using System.Reflection;
using DevExpress.XtraBars.Utils;

namespace T191208
{
	public partial class CustomCustomizationControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpOptions.SuspendLayout();
            this.tpCommands.SuspendLayout();
            this.tpToolbars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptionsShowFullMenus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_showFullMenusAfterDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_showTips.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_ShowShortcutInTips.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNBDlgName.Properties)).BeginInit();
            this.pnlNBDlg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_largeIcons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_MenuAnimation.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(839, 587);
            // 
            // tpOptions
            // 
            this.tpOptions.Size = new System.Drawing.Size(942, 543);
            // 
            // tpCommands
            // 
            this.tpCommands.Size = new System.Drawing.Size(942, 543);
            // 
            // tpToolbars
            // 
            this.tpToolbars.Size = new System.Drawing.Size(942, 543);
            // 
            // lbDescription
            // 
            this.lbDescription.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
            // lbCommands
            // 
            this.lbCommands.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbCommands.Appearance.Options.UseBackColor = true;
            // 
            // cbOptionsShowFullMenus
            // 
            // 
            // cbOptions_showFullMenusAfterDelay
            // 
            // 
            // cbOptions_showTips
            // 
            // 
            // cbOptions_ShowShortcutInTips
            // 
            // 
            // lbOptions_Other
            // 
            this.lbOptions_Other.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
            // lbOptions_PCaption
            // 
            this.lbOptions_PCaption.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
            // tabControl
            // 
            this.tabControl.Size = new System.Drawing.Size(948, 571);
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.tabControl.Controls.SetChildIndex(this.xtraTabPage1, 0);
            this.tabControl.Controls.SetChildIndex(this.tpOptions, 0);
            this.tabControl.Controls.SetChildIndex(this.tpToolbars, 0);
            this.tabControl.Controls.SetChildIndex(this.tpCommands, 0);
            // 
            // tbNBDlgName
            // 
            // 
            // cbOptions_largeIcons
            // 
            // 
            // cbOptions_MenuAnimation
            // 
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.treeList1);
            this.xtraTabPage1.Controls.Add(this.gridControl2);
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(942, 543);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(286, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(366, 543);
            this.treeList1.TabIndex = 2;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Caption";
            this.treeListColumn2.FieldName = "Caption";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.AllowDrop = true;
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl2.Location = new System.Drawing.Point(652, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(290, 543);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Caption";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(286, 543);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Caption";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "Glyph";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // CustomCustomizationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CustomCustomizationControl";
            this.Size = new System.Drawing.Size(956, 621);
            this.Load += new System.EventHandler(this.CustomCustomizationControl_Load);
            this.tpOptions.ResumeLayout(false);
            this.tpOptions.PerformLayout();
            this.tpCommands.ResumeLayout(false);
            this.tpCommands.PerformLayout();
            this.tpToolbars.ResumeLayout(false);
            this.tpToolbars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptionsShowFullMenus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_showFullMenusAfterDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_showTips.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_ShowShortcutInTips.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbNBDlgName.Properties)).EndInit();
            this.pnlNBDlg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_largeIcons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_MenuAnimation.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
	}
}
