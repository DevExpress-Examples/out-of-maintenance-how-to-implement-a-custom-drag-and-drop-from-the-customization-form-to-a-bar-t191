using DevExpress.XtraBars;
using DevExpress.XtraBars.Utils;
using System.ComponentModel;
using System.Reflection;

namespace T191208 {
    public class MyBarManager : BarManager {
        public MyBarManager()
            : base() {
        }
        public MyBarManager(IContainer components)
            : base(components) {
        }
        //
        //This method is hidden from IntelliSense
        //since 'Helper' class is designed for internal use
        //Avoid using it in your app
        //
        [EditorBrowsable(EditorBrowsableState.Never)]
        public BarManagerHelpers GetHelper() {
            return this.Helper;
        }
        public void SetCustomizeSelectedLink(BarItemLink link) {
            this.SelectionInfo.CustomizeSelectedLink = link;
        }

        //We do not recommend using Reflection 
        public void SetSelectedItem(BarItem item) {
            FieldInfo selItemField = this.SelectionInfo.GetType().GetField("selectedItem", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            selItemField.SetValue(this.SelectionInfo, item);
        }
    }
}
