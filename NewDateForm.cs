using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLAP_Week1_Exercise_CostCalculator
{
    public partial class NewDateForm : Form
    {
        CostCalculator costCalculator;

        internal NewDateForm(CostCalculator costCalculator)
        {
            this.costCalculator = costCalculator;
            InitializeComponent();
        }

        private void BtnNewDateOk_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParseExact(TbNewDate.Text, "dd-MM-yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime dateTime))
            {
                MessageBox.Show("Please input a valid date before today in the format dd-MM-yyyy.");
            }
            else
            {
                if (costCalculator.SetDate(dateTime))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Did you specify a later date than today?");
                }
            }

        }

        private void BtnNewDateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
