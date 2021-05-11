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
     class ExComponent
    {
        [Key]
        public int ExComplId { get; set; }

        //[ForeignKey(nameof(PropertyId))]
        //public string PropertyId { get; set; }

        //public virtual Property Property { get; set; }

        [Required]
        public object Address { get; set; }


        [Required]
        [DisplayName("Foundation")]
        public Foundations Foundation { get; set; }

        [DisplayName("Foundation Condition")]
        public Condition FoundationCondition { get; set; }

        [Required]
        [DisplayName("Floor Structure")]
        public FloorStructure FloorStructure { get; set; }

        [DisplayName("Floor Condition")]
        public Condition FloorCondition { get; set; }

        [Required]
        [DisplayName("Exterior Walls")]
        public ExteriorWalls ExteriorWalls { get; set; }
        
        [DisplayName("Wall Condition")]
        public Condition WallCondition { get; set; }

        [Required]
        [DisplayName("Roof Framing")]
        public RoofStructure RoofFraming { get; set; }

        [DisplayName("Roof Frame")]
        public Condition RoofFrame { get; set; }

        [Required]
        [DisplayName("Roof Cover")]
        public RoofCover RoofCover { get; set; }

        [Required]
        [DisplayName("Roof Condition")]
        public Condition RoofCondition { get; set; }

        [Required]
        [DisplayName("Chimneys")]
        public ChimneyType ChimneyType { get; set; }

        
        [DisplayName("Chimney Condition")]
        public Condition ChimneyCondition { get; set; }

        [Required]
        [DisplayName("Roof Drainage")]
        public RoofDrainage RoofDrainage { get; set; }

        [DisplayName("Drainage Condition")]
        public Condition DrainageCondition { get; set; }

        [Required]
        [DisplayName("Wall Covering")]
        public WallCover WallCover { get; set; }

        [DisplayName("Wall Condition")]
        public Condition WallCovers { get; set; }

        [Required]
        [DisplayName("Eaves Soffits and Fascias")]
        public EavesSoffitsFascia EavesSoffitsFascia { get; set; }

        [DisplayName("Eaves/Soffits Condition")]
        public Condition EavesSoffitsAndFascia { get; set; }

        [Required]
        [DisplayName("Exterior Doors")]
        public ExteriorDoors ExteriorDoors { get; set; }

        [DisplayName("Exterior Door Condition")]
        public Condition ExtDoorCondition { get; set; }

        [Required]
        public Driveway Driveways { get; set; }

        [DisplayName("Driveway Condition")]
        public Condition DriveCondition{ get; set; }

        [Required]
        public Walkways Walkways{ get; set; }

        [DisplayName("Walkway Conidition")]
        public Condition WalkCondition{ get; set; }

        [Required]
        [DisplayName("Garage Doors")]
        public GarageDoors GarageDoors{ get; set; }

        [DisplayName("Garage Door Condition")]
        public Condition GarageDoorCond{ get; set; }

        [Required]
        [DisplayName("Porch and Patio")]
        public PorchAndPatio PorchAndPatio { get; set; }

        [DisplayName("Porch/Patio Condition")]
        public Condition PorchCondition{ get; set; }

        [Required]
        [DisplayName("Surface Drainage")]
        public SurfaceDrainage SurfaceDrainage { get; set; }

        [DisplayName("Drainage Condition")]
        public Condition SurfaceDrainCondition { get; set; }

        [Required]
        [DisplayName("Retaining Walls")]
        public RetainingWall RetainingWall { get; set; }

        [DisplayName("Wall Condition")]
        public Condition RetainingWallCondition { get; set; }

        [Required]
        public Fencing Fencing { get; set; }

        [DisplayName("Fence Condition")]
        public Condition FenceCondition{ get; set; }



    }

    public enum Foundations
    {
        PouredConcrete,
        ConcreteBlock,
        MasonryBrick,
        Stone,
        Wood,
        Piers,
        other
    }
    public enum FloorStructure
    {
        WoodJoist,
        Trusses,
        Concrete,
        Other
    }

    public enum ExteriorWalls
    {
        WoodFrame,
        Brick,
        Stone,
        WoodFrameBrickVeneer,
        WoodFrameHardieBoard,
        WoodFrameVinyl,
        WoodFrameAluminum,
        Log,
        PostAndBeam,
        Stucco,
        other
    }

    public enum RoofStructure
    {
        WoodJoist,
        Trusses,
        Concrete,
        Steel,
        Fabricated,
        other
    }
    public enum RoofCover
    {
        AshaltFiftyYear,
        AshaltTwentyFive,
        Metal,
        Clay,
        Steel,
        Slate,
        other
    }

    public enum ChimneyType
    {
        Masonry,
        Metal,
        Stucco,
        Wood,
        Concrete,
        other
    }

    public enum RoofDrainage
    {
        Aluminum,
        Galvanized,
        Plastic,
        Copper,
        Wood,
        other
    }

    public enum WallCover
    {
        Brick,
        Stucco,
        WoodSiding,
        MetalSiding,
        VinylSiding,
        Stone,
        PerFabStone,
        Block,
        AsphaltShingle,
        AsbestosCementSiding,
        Plywood,
        HardieBoard,
        Insulbrick,
        other
    }
    public enum EavesSoffitsFascia
    {
        Wood,
        Vinyl,
        Aluminum,
        Metal,
        OpenRafter,
        other
    }
    public enum ExteriorDoors
    {
        Metal,
        SolidWood,
        HollowWood,
        SlidingGlass,
        FrenchDoor,
        MulitPanelGlass,
        Overhead,
        other
    }
    public enum Driveway
    {
        Concrete,
        Asphalt,
        Pavers,
        Stone,
        Gravel,
        Brick,
        Sand,
        other
    }
    public enum Walkways
    {
        Concrete,
        Asphalt,
        Pavers,
        Wood,
        Gravel,
        Brick,
        Stone,
        other
    }
     public enum GarageDoors
    {
        Wood,
        Steel,
        Plastic,
        Automatic,
        other
    }
    public enum PorchAndPatio
    {
        Concrete,
        Brick,
        Stone,
        Wood,
        TreatedWood,
        other
    }
    public enum SurfaceDrainage
    {
        GradeLevel,
        GradelevelAwayFromHome,
        GradedTowardsHome,
        BelowGrade,
        BelowGradeAwayFromHome,
        RavineLot,
        other
    }

    public enum RetainingWall
    {
        Wood,
        Concrete,
        Brick,
        Stone,
        Block,
        PreFabMasonry,
        Plastic,
        other
    }

    public enum Fencing
    {
        Wood,
        ChainLink,
        SteelIron,
        Masonry,
        Vinyl,
        other

    }



    public enum Condition
    {
        New,
        Good,
        Monitor,
        RepairsNeeded,
        MajorConcern,
        Replacement
    }
}
