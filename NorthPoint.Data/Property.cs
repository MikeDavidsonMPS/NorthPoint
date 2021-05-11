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
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

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
        public int YearBuilt { get; set; }

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

        [DisplayName("# of Full Bathrooms")]
        public int NumberOfFullBaths { get; set; }

        [DisplayName("# of Haft Baths")]
        public int NumberOfHaftBaths { get; set; }

        [DisplayName("# of Bedrooms")]
        public int NumberOfBedrooms { get; set; }

        [DisplayName("Date Created")]
        public DateTimeOffset CreateUtc { get; set; }

        [DisplayName("Date Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
        public int ListPrice { get; set; }
        public int DownPayment { get; set; }
        public int MonthlyPayments { get; set; }
        public object RemainingYearOnLoan { get; set; }
        public TypeOfMortgage TypeOfMortgages { get; set; }
        public object RemainingYearsOnLoan { get; set; }
    }

    public enum HomeType
    {
        [Description("Single Family")]
        SingleFamily,
        [Description("Multi-Family")]
        MultiHousing,
        [Description("Co-Op")]
        CoOp,
        TownHouse,
        Apartment,
        Duplex,
        Other
    }
    public enum Architectural
    {
        [Description("Adobe Revival")]
        AdobeRevival,
        [Description("A-Frame")]
        AFrame,
        Beach,
        Bungalow,
        [Description("Cape Cod")]
        CapeCod,
        Colonial,
        Contemporay,
        [Description("Contemporary Craftsman")]
        ContemporaryCraftsman,
        Country,
        Craftsman,
        [Description("Dutch Colonial")]
        DutchColonial,
        [Description("English Cottage")]
        EnglishCottage,
        [Description("Farm House")]
        FarmHouse,
        [Description("Federal Colonial")]
        FederalColonial,
        Florida,
        [Description("French Country")]
        FrenchCountry,
        [Description("French Colonial")]
        FrenchColonial,
        Georgian,
        [Description("Greek Revival")]
        GreekRevival,
        [Description("Log Cabin")]
        LogCabin,
        Mediterranean,
        [Description("Mid-Century Modern")]
        MidCenturyModern,
        Modern,
        Mountain,
        Northwest,
        Prairie,
        Ranch,
        Shingle,
        Spanish,
        Southern,
        Southwest,
        Traditional,
        Tudor,
        Victorian,
        Rustic,
        Italianate,
        Gothic,
        [Description("Queen Anne")]
        QueenAnne,
        Other
    }
    public enum ConstructionMaterials
    {
        [Description("Wood Siding")]
        WoodSiding,
        [Description("Hardie Board Siding")]
        HardieBoard,
        Brick,
        Stone,
        Stucco,
        [Description("Alumium Siding")]
        AluminumSiding,
        [Description("Vinyle Siding")]
        VinyleSiding,
        Other

    }
    public enum Roof
    {
        Gable,
        [Description("Cross Gable")]
        CrossGable,
        Mansard,
        [Description("Pyramid Hip")]
        PyramidHip,
        Hip,
        [Description("Cross Hipped")]
        CrossHipped,
        Saltbox,
        Gambrel,
        Flat,
        Bonnet,
        Shed,
        Other,

    }
    public enum Foundation
    {
        FullBasement,
        PartialBasement,
        DaylightBasement,
        Crawlspace,
        ConcreteSlab,
        Wood,
        Masonry,
        Stone,
        other
    }
}
