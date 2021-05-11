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

        [ForeignKey(nameof(ApplicationUser))]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }



        [Required]

        [DisplayName("Lender's Name")]
        public string LendersName { get; set; }

        [Required]

        [DisplayName("Mortgage")]
        public TypeOfMortgage TypeOfMortgages { get; set; }

        [DisplayName("List Price")]
        public int ListPrice { get; set; }

        [Required]

        [DisplayName("Purchase Price")]
        public int PurchasePrice { get; set; }
        [Required]

        [DisplayName("Tax Assessment")]
        public int TaxAssessment { get; set; }
        [Required]

        [DisplayName("Annual Tax Amount")]
        public int AnnualTaxAmount { get; set; }

    }

    public enum TypeOfMortgage
    {
        ThrityYearFixed
    }
}
