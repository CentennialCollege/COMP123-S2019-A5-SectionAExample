using COMP123_S2019_A5_SectionAExample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_SectionAExample.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        public bool HasLoadedDataSource()
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
                if(productBindingSource.DataSource != null)
                {
                    return true;
                }
            }

            return false;
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
           if(!HasLoadedDataSource())
            {
                MessageBox.Show("DataSource Not Loaded", "ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
