using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPoint.Models.Property
{
    public class PropertyListItem
    {
        public int PropertyId { get; set; }


        [DisplayName("Property Address")]
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }


        [DisplayName("Purchase Price")]
        public int PurchasePrice { get; set; }

        [DisplayName("Year Built")]
        public DateTime YearBuilt { get; set; }

        [DisplayName("Date Created")]
        public DateTimeOffset CreateUtc { get; set; }

        [DisplayName("Date Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }


    }
}
