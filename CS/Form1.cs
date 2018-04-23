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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyXtraGrid {
    public partial class Form1 : Form {
        BindingList<Customer> customers;
        public Form1() {
            InitializeComponent();
            FillGridDataSource();
            myGridView1.ColumnPositionChanged += myGridView1_ColumnPositionChanged;
        }

        void myGridView1_ColumnPositionChanged(object sender, EventArgs e) {
            
        }

        private void FillGridDataSource()
        {
            customers = new BindingList<Customer>();
            for (int i = 0; i < 50; i++)
            {
                Customer customer = new Customer();
                customer.Name = "Mike";
                if (i % 2 == 0)
                    customer.Name = "John";                
                customer.Age = 70 - i;
                customer.Weight = 50 + i;
                customer.Height = 150 + i;
                customers.Add(customer);
            }
            myGridControl1.DataSource = customers;
        }
    }
}