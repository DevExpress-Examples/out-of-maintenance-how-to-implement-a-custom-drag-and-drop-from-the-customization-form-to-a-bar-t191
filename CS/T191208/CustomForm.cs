using System.Drawing;
using System.Windows.Forms;
using System;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Utils;

namespace T191208 {
    public class CustomizationFormEx : DevExpress.XtraBars.Customization.CustomizationForm {
        //Custom control
        private CustomCustomizationControl control;
        protected ISupportCustomizationDrag ControlForDrag {
            get {
                return control as ISupportCustomizationDrag;
            }
        }
        protected virtual MyBarManager MyManager {
            get {
                return (Manager as MyBarManager);
            }
        }
        private Point mouseDownPoint;
        protected virtual Point MouseDownPoint {
            get {
                return mouseDownPoint;
            }
            set {
                mouseDownPoint = value;
            }
        }
        private BarItem mouseDownItem;
        protected virtual BarItem MouseDownItem {
            get {
                return mouseDownItem;
            }
            set {
                mouseDownItem = value;
            }
        }

        private BarItem mouseDraggingItem;
        protected virtual BarItem MouseDraggingItem {
            get {
                return mouseDraggingItem;
            }
            set {
                mouseDraggingItem = value;
            }
        }
        public CustomizationFormEx(DevExpress.XtraBars.Customization.CustomizationControl control, UserLookAndFeel laf)
            : base(control, laf) {
            this.control = control as T191208.CustomCustomizationControl;
        }
        void MouseDownEx(object sender, MouseEventArgs e) {
            if ((e.Button & MouseButtons.Left) != 0) {
                MouseDownPoint = Control.MousePosition;
                MouseDownItem = null;
                MouseDownItem = ControlForDrag.GetDraggingItem(new Point(e.X, e.Y));
            }
        }
        void MouseUpEx(object sender, MouseEventArgs e) {
            Capture = false;
            MouseDownItem = null;
        }
        void MouseMoveEx(object sender, MouseEventArgs e) {
            if ((e.Button & MouseButtons.Left) != 0) {
                if (MouseDownItem != null) {
                    Point p = Control.MousePosition;
                    p.Offset(-MouseDownPoint.X, -MouseDownPoint.Y);
                    if (Math.Abs(p.X) > 4 || Math.Abs(p.Y) > 4) {
                        MyManager.SetCustomizeSelectedLink(null);
                        MyManager.SetSelectedItem(MouseDownItem);
                        BarManagerHelpers helper = MyManager.GetHelper();
                        try {
                            MouseDraggingItem = MouseDownItem;
                            this.ControlForDrag.GetControlToPerformDragging(Control.MousePosition).AllowDrop = true;
                            helper.DragManager.UseDefaultCursors = true;
                            helper.DragManager.StartDragging(null, e, MouseDownItem, this.ControlForDrag.GetControlToPerformDragging(Control.MousePosition));
                        }
                        finally {
                            helper.DragManager.UseDefaultCursors = false;
                            this.ControlForDrag.GetControlToPerformDragging(Control.MousePosition).AllowDrop = false;
                            MyManager.SetSelectedItem(null);
                            MouseDraggingItem = null;
                        }
                    }
                }
            }
        }

        public override void Init(BarManager AManager) {
            base.Init(AManager);
            if (ControlForDrag != null && MyManager != null) {
                this.ControlForDrag.InitControl(AManager);
                ControlForDrag.AddMouseDownHandler(MouseDownEx);
                ControlForDrag.AddMouseMoveHandler(MouseMoveEx);
                ControlForDrag.AddMouseUpHandler(MouseUpEx);
            }
        }
    }

    public class MyForm : CustomizationFormEx {
        public MyForm(DevExpress.XtraBars.Customization.CustomizationControl control, UserLookAndFeel lookAndFeel)
            : base(control, lookAndFeel) {
        }
    }
    
}
