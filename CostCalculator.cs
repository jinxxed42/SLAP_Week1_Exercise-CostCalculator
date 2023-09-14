using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAP_Week1_Exercise_CostCalculator
{
    internal class CostCalculator
    {
        public DateTime StartDate { get; private set; } = new(2019, 01, 01);

        internal bool SetDate(DateTime startDate)
        {
            if (startDate > DateTime.Now) return false;
            StartDate = startDate;
            return true;
        }

        internal double CalcAvgIncome(double income)
        {
            return income / (DateTime.Now - StartDate).Days;
        }

        internal double CalcAvgExpenses(double expenses)
        {
            return expenses / (DateTime.Now - StartDate).Days;
        }

        internal double CalcSavingsRate(double income, double expenses)
        {
            return (income - expenses) / income * 100;
        }
    }
}
