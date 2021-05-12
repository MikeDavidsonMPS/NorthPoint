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
    public class FinancialListItem
    {
        public int PropertyId { get; set; }
        public int FinancialId { get; set; }

        [DisplayName("Property Address")]
        public object Address { get; set; }
        public object City { get; set; }
        public object State { get; set; }



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
        [DisplayName("Tax Assessment")]
        public int TaxAssessment { get; set; }

        [Required]
        [DisplayName("Annual Tax Amount")]
        public int AnnualTaxAmount { get; set; }
        public object RemainingYearsOnLoan { get; set; }
    
    }
}
