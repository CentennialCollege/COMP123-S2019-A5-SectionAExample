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

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SelectLabel.Text = ProductDataGridViewSelectedItem();
        }

        
    }
}
