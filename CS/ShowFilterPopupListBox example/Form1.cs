using System;
using System.Windows.Forms;
using DevExpress.XtraTreeList;

namespace ShowFilterPopupListBox_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeList1_ShowFilterPopupListBox(object sender, FilterPopupListBoxEventArgs e)
        {
            if (e.Column.FieldName == "Name")
            {
                //Removes "(Blanks)"
                e.ComboBox.Items.RemoveAt(0);
                //Removes "(Non blanks)"
                e.ComboBox.Items.RemoveAt(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.table1TableAdapter.Fill(this.treelistdbDataSet.Table1);

        }
    }
}
