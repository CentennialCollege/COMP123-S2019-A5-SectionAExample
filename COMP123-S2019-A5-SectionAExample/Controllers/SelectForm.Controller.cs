using COMP123_S2019_A5_SectionAExample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_SectionAExample.Views
{
    public partial class SelectForm : Form
    {
        public bool HasLoadedDataSource()
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
                if (productBindingSource.DataSource != null)
                {
                    return true;
                }
            }

            return false;
        }

        public string ProductDataGridViewSelectedItem()
        {
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductDataGridView.Rows[rowIndex];
            var cost = currentRow.Cells[1].Value.ToString();
            var costDecimal = Decimal.Parse(cost);

            cost = costDecimal.ToString("C2");

            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();

            string outputString = manufacturer + " " + model + " " + cost;

            return outputString;
        }
    }
}
