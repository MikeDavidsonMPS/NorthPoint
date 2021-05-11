using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPoint.Data
{
    public class Financial
    {
        [Key]
        public int FinancialId { get; set; }

        //[ForeignKey(nameof(PropertyId))]
        //public string PropertyId { get; set; }

        //public virtual Property Property { get; set; }


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
        [DisplayName("Mortgage Type")]
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

    public enum TypeOfMortgage
    {
        [Description("FHA Loan")]
        FHA,
        [Description("FHA 203(k) Rehab Loan")]
        FHATwoHunderdAndThreeKRehab,
        [Description("30 year Fixed Loan")]
        ThrityYearFixed,
        [Description("20 Year Fixed Loan")]
        TwentyYearFixed,
        [Description("15 Year Fixed Loan")]
        FifteenYearFixed,
        [Description("VA Loan")]
        VALoan,
        [Description("USDA Loan")]
        USDALoan,
        [Description("Jumbo Loan")]
        JumboLoan,
        [Description("One Year ARM")]
        OneYearARM,
        [Description("10/1 ARM")]
        TenAndOneARM,
        [Description("5/5 ARM")]
        FiveAndFiveARM,
        [Description("5/1 ARM Loan")]
        FiveAndOneARM,
        [Description("3/3 ARM")]
        ThreeAndThreeARM,
        [Description("3/1 ARM Loan")]
        ThreeAndOneARM,

    }
}
