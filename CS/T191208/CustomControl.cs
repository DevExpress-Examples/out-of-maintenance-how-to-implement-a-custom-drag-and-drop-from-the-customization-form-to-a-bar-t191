using System.Drawing;
using System.Windows.Forms;
using System;

using DevExpress.XtraBars.Customization;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraBars;
using DevExpress.XtraTreeList;

namespace T191208 {
    public partial class CustomCustomizationControl : CustomizationControl, ISupportCustomizationDrag {
        // Fields...
        Control selectedControl;
        protected Control SelectedControl {
            get {
                return selectedControl;
            }
            set {
                selectedControl = value;
            }
        }

        public CustomCustomizationControl() {
            InitializeComponent();
            this.gridControl1.MouseDown += gridControl1_MouseDown;
            this.gridControl2.MouseDown += gridControl2_MouseDown;
            this.treeList1.MouseDown += treeList1_MouseDown;
        }

        private void CustomCustomizationControl_Load(object sender, EventArgs e) {

        }

        void treeList1_MouseDown(object sender, MouseEventArgs e) {
            SelectedControl = sender as TreeList;
        }

        void gridControl1_MouseDown(object sender, MouseEventArgs e) {
            SelectedControl = sender as GridControl;
        }

        private void gridControl2_MouseDown(object sender, MouseEventArgs e) {
            SelectedControl = sender as GridControl;
        }
        public void AddMouseMoveHandler(MouseEventHandler mouseMove) {
            this.gridView2.MouseMove += mouseMove;
            this.gridView1.MouseMove += mouseMove;
            this.treeList1.MouseMove += mouseMove;
        }


        public void AddMouseDownHandler(MouseEventHandler mouseDown) {
            this.gridView2.MouseDown += mouseDown;
            this.gridView1.MouseDown += mouseDown;
            this.treeList1.MouseDown += mouseDown;
        }

        public void AddMouseUpHandler(MouseEventHandler mouseUp) {
            this.gridView2.MouseUp += mouseUp;
            this.gridView1.MouseUp += mouseUp;
            this.treeList1.MouseUp += mouseUp;
        }

        public BarItem GetDraggingItem(Point location) {
            // your logic here
            BarItem item = null;
            if (SelectedControl is GridControl) {
                GridControl grid = SelectedControl as GridControl;
                if (grid != null) {
                    GridView view = grid.MainView as GridView;
                    if (view != null) {
                        GridHitInfo hitInfo = view.CalcHitInfo(location);
                        item = view.GetRow(hitInfo.RowHandle) as BarItem;
                    }
                }
            }
            if (SelectedControl is TreeList) {
                TreeList treeList = SelectedControl as TreeList;
                if (treeList != null) {
                    TreeListHitInfo hitInfo = treeList.CalcHitInfo(location);
                    item = treeList1.GetDataRecordByNode(hitInfo.Node) as BarItem;
                }
            }
            return item;
        }

        public Control GetControlToPerformDragging(Point location) {
            //your logic here
            return SelectedControl;
        }
        public void InitControl(BarManager manager) {
            this.gridControl1.DataSource = manager.Items;
            this.gridControl2.DataSource = manager.Items;
            this.treeList1.DataSource = manager.Items;
        }
    }
}
