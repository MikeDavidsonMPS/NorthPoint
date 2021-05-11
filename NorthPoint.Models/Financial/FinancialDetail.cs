using NorthPoint.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPoint.Models.Financial
{
    public class FinancialDetail
    {
        [DisplayName("ID")]
        public int PropertyId { get; set; }

        public string Address { get; set; }

        [DisplayName("List Price")]
        public int ListPrice { get; set; }

        [DisplayName("Purchase Price")]
        public int PurchasePrice { get; set; }

        [DisplayName("Lender's Name")]
        public string LendersName { get; set; }

        [DisplayName("Mortgage")]
        public TypeOfMortgage TypeOfMortgages { get; set; }

        [DisplayName("Interest Rate")]
        public int InterestRate { get; set; }

        [DisplayName("Down Payment")]
        public int DownPayment { get; set; }

        [DisplayName("Monthly Payments")]
        public int MonthlyPayments { get; set; }

        [DisplayName("Remaining Years on Loan")]
        public object RemainingYearsOnLoan { get; set; }

        [DisplayName("Tax Assessment")]
        public int TaxAssessment { get; set; }

        [DisplayName("Annual Tax Amount")]
        public int AnnualTaxAmount { get; set; }
        public int FinancialId { get; set; }
    }
}
