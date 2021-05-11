using NorthPoint.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPoint.Models.Property
{
    public class PropertyCreate
    {
        [Required]
        [DisplayName("Property Address")]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [DisplayName("Zip Code")]
        public int ZipCode { get; set; }

        [DisplayName("Purchase Price")]
        public int PurchasePrice { get; set; }

        [DisplayName("Year Built")]
        public DateTime YearBuilt { get; set; }

        [Required]
        [DisplayName("Square Footage")]
        public int SqFt { get; set; }

        [DisplayName("Residental Type")]
        public HomeType HomeTypes { get; set; }

        [DisplayName("Architectural Style")]
        public Architectural ArchitecturalStyle { get; set; }

        [DisplayName("Construction Material")]
        public ConstructionMaterials Construction { get; set; }

        [DisplayName("Roof Type")]
        public Roof RoofType { get; set; }

        [DisplayName("Foundation Type")]
        public Foundation FoundationType { get; set; }

        [DisplayName("New Construction")]
        public bool NewConstruction { get; set; }

        [DisplayName("Histroic Register")]
        public bool HistroicRegister { get; set; }

        [DisplayName("# of Levels")]
        public int NumberOfLevels { get; set; }

        [DisplayName("Attached Garage")]
        public bool AttachedGarage { get; set; }

        [DisplayName("# Garage Spaces")]
        public int GarageSpaces { get; set; }

        [DisplayName("# of Fireplace")]
        public int NumberOfFireplaces { get; set; }

        [DisplayName("# of Bathrooms")]
        public int NumberOfBathrooms { get; set; }

        [DisplayName("# of Full Baths")]
        public int NumberOfFullBaths { get; set; }

        [DisplayName("# of Haft Baths")]
        public int NumberOfHaftBaths { get; set; }

        [DisplayName("# of Bedrooms")]
        public int NumberOfBedrooms { get; set; }

    }
}
