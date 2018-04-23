using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T191208
{
    public interface ISupportCustomizationDrag
    {
        void AddMouseMoveHandler(MouseEventHandler mouseMove);
        void AddMouseDownHandler(MouseEventHandler mouseDown);
        void AddMouseUpHandler(MouseEventHandler mouseUp);
        BarItem GetDraggingItem(Point location);
        Control GetControlToPerformDragging(Point location);
        void InitControl(BarManager manager);
    }
}
