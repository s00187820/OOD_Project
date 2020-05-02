using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Company
    {
        public decimal GameSales { get; set; }
        public decimal finalRevenue { get; set; }

        public void Deposit(decimal amount)
        {
            GameSales += amount;
        }

        public void WithDraw(decimal amount)
        {
            decimal CompanyFunds = GameSales + finalRevenue;
            if (amount <= CompanyFunds)//looks for the amount
                GameSales -= amount;
        }
    }
}
