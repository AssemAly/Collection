using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTable
{
    public partial class pheoneBookForm : Form
    {
        public pheoneBookForm()
        {
            InitializeComponent();
        }

        Dictionary<string, long> phoneBook = new Dictionary<string, long>();

        private void pheoneBookForm_Load(object sender, EventArgs e)
        {
            phoneBook["Dad"] = 01288144980;
            phoneBook["Mam"] = 01097001204;
            phoneBook["Emergency"] = 911;
            phoneBook["Friend"] = 5369852145;
            phoneBook["Assem"] = 53695;
            phoneBook["Ahmed"] = 535;
            phoneBook["Ahmed Ali"] = 535;
            phoneBook["Ahmed Mohamed"] = 535;
            gridControl1.DataSource = phoneBook;            
            gridView1.Columns[0].Caption = "Name";
            gridView1.Columns[1].Caption = "Number";

        }

        private void txtContactName_EditValueChanged(object sender, EventArgs e)
        {           
            gridControl1.DataSource = phoneBook.Where(x => x.Key.ToLower().Contains(txtContactName.Text.ToLower())).ToList();
        }
    }
}
