using NorthPoint.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPoint.Models.Financial
{
    public class FinancialCreate
    {
        public object Address { get; set; }

        [DisplayName("List Price")]
        public int ListPrice { get; set; }

        [Required]
        [DisplayName("Purchase Price")]
        public int PurchasePrice { get; set; }


        [Required]
        [DisplayName("Lender's Name")]
        public string LendersName { get; set; }

        [Required]
        [DisplayName("Mortgage")]
        public TypeOfMortgage TypeOfMortgages { get; set; }

        [Required]
        [DisplayName("Interest Rate")]
        public int InterestRate { get; set; }

        [Required]
        [DisplayName("Down Payment")]
        public int DownPayment { get; set; }

        [Required]
        [DisplayName("Monthly Payments")]
        public int MonthlyPayments { get; set; }

        [Required]
        [DisplayName("Remaining Years on Loan")]
        public object RemainingYearsOnLoan { get; set; }

        [Required]
        [DisplayName("Tax Assessment")]
        public int TaxAssessment { get; set; }

        [Required]
        [DisplayName("Annual Tax Amount")]
        public int AnnualTaxAmount { get; set; }
    }
}

