using System.Globalization;

namespace SLAP_Week1_Exercise_CostCalculator
{
    public partial class Form1 : Form
    {
        private CostCalculator _costCalculator;
        private double _expenses;
        private double _income;

        public Form1()
        {
            InitializeComponent();

            _costCalculator = new();
            _expenses = 100704.1;
            _income = 246585;

            TbInputExpenses.Text = _expenses.ToString();
            TbInputIncome.Text = _income.ToString();

            UpdateForm();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(TbInputExpenses.Text, out _expenses) || _expenses < 0)
            {
                MessageBox.Show("Please input a valid value above 0 as expenses.");
            }
            else if (!double.TryParse(TbInputIncome.Text, out _income) || _income < 0)
            {
                MessageBox.Show("Please input a valid value above 0 as income.");
            }
            else
            {
                UpdateForm();
            }
        }

        private void UpdateForm()
        {
            TbAvgExpenses.Text = String.Format("{0:0.00}", _costCalculator.CalcAvgExpenses(_expenses));
            TbAvgIncome.Text = String.Format("{0:0.00}", _costCalculator.CalcAvgIncome(_income));
            TbSavingsRate.Text = String.Format("{0:0.00}", _costCalculator.CalcSavingsRate(_income, _expenses));
            TbDate.Text = DateOnly.FromDateTime(_costCalculator.StartDate).ToString();
        }

        private void BtnDate_Click(object sender, EventArgs e)
        {
            NewDateForm newDateForm = new(_costCalculator);
            DialogResult dr = newDateForm.ShowDialog();
            if (dr == DialogResult.OK) UpdateForm();
        }
    }
}