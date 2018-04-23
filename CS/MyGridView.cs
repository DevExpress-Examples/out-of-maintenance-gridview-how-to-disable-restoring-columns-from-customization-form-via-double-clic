// Developer Express Code Central Example:
// How to create a GridView descendant class and register it for design-time use
// 
// This is an example of a custom GridView and a custom control that inherits the
// DevExpress.XtraGrid.GridControl. Make sure to build the project prior to opening
// Form1 in the designer. Please refer to the http://www.devexpress.com/scid=A859
// Knowledge Base article for the additional information.
// In addition, you can
// refer to the examples describing how to create GridControl's View
// descendants:
// 1. http://www.devexpress.com/scid=T122347; 2.
// http://www.devexpress.com/scid=T122335; 3.
// http://www.devexpress.com/scid=T122333; 4.
// http://www.devexpress.com/scid=T122322 ;
// 5.
// http://www.devexpress.com/scid=T122275.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E900

using System;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Customization;

namespace MyXtraGrid {
    public class MyGridView : DevExpress.XtraGrid.Views.Grid.GridView {
        public MyGridView()
            : this(null) {
        }
        public MyGridView(DevExpress.XtraGrid.GridControl grid)
            : base(grid) {
            // put your initialization code here
        }
        protected override string ViewName {
            get {
                return "MyGridView";
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.Customization.CustomizationForm CreateCustomizationForm() {
            return new CustomCustomizationForm(this);//            base.CreateCustomizationForm();
        }
    }
    public class CustomCustomizationForm : CustomizationForm {
        public CustomCustomizationForm(GridView view)
            : base(view) {

        }
        protected override DevExpress.XtraEditors.Customization.CustomizationListBoxBase CreateCustomizationListBox() {
            return new CustomCustomizationListBox(this);
        }
    }
    public class CustomCustomizationListBox : ColumnCustomizationListBox {
        public CustomCustomizationListBox(CustomizationForm form)
            : base(form) {

        }
        protected override void OnMouseDoubleClick(System.Windows.Forms.MouseEventArgs e) {
            if(e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks >= 2) {
                return;
            }
            base.OnMouseDoubleClick(e);
        }
    }
}
