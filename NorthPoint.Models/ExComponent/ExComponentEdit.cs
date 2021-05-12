using NorthPoint.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPoint.Models.ExComponent
{
    public class ExComponentEdit
    {
        public int ExComplId { get; set; }

        public object Address { get; set; }

        [DisplayName("Foundation")]
        public Foundations Foundation { get; set; }

        [DisplayName("Foundation Condition")]
        public Condition FoundationCondition { get; set; }

        [DisplayName("Floor Structure")]
        public FloorStructure FloorStructure { get; set; }

        [DisplayName("Floor Condition")]
        public Condition FloorCondition { get; set; }

        [DisplayName("Exterior Walls")]
        public ExteriorWalls ExteriorWalls { get; set; }

        [DisplayName("Wall Condition")]
        public Condition WallCondition { get; set; }

        [DisplayName("Roof Framing")]
        public RoofStructure RoofFraming { get; set; }

        [DisplayName("Roof Frame")]
        public Condition RoofFrame { get; set; }

        [DisplayName("Roof Cover")]
        public RoofCover RoofCover { get; set; }

        [DisplayName("Roof Condition")]
        public Condition RoofCondition { get; set; }

        [DisplayName("Chimneys")]
        public ChimneyType ChimneyType { get; set; }

        [DisplayName("Chimney Condition")]
        public Condition ChimneyCondition { get; set; }

        [DisplayName("Roof Drainage")]
        public RoofDrainage RoofDrainage { get; set; }

        [DisplayName("Drainage Condition")]
        public Condition DrainageCondition { get; set; }

        [DisplayName("Wall Covering")]
        public WallCover WallCover { get; set; }

        [DisplayName("Wall Condition")]
        public Condition WallCovers { get; set; }

        [DisplayName("Eaves Soffits and Fascias")]
        public EavesSoffitsFascia EavesSoffitsFascia { get; set; }

        [DisplayName("Eaves/Soffits Condition")]
        public Condition EavesSoffitsAndFascia { get; set; }

        [DisplayName("Exterior Doors")]
        public ExteriorDoors ExteriorDoors { get; set; }

        [DisplayName("Exterior Door Condition")]
        public Condition ExtDoorCondition { get; set; }

        public Driveway Driveways { get; set; }

        [DisplayName("Driveway Condition")]
        public Condition DriveCondition { get; set; }

        public Walkways Walkways { get; set; }

        [DisplayName("Walkway Conidition")]
        public Condition WalkCondition { get; set; }

        [DisplayName("Garage Doors")]
        public GarageDoors GarageDoors { get; set; }

        [DisplayName("Garage Door Condition")]
        public Condition GarageDoorCond { get; set; }

        [DisplayName("Porch and Patio")]
        public PorchAndPatio PorchAndPatio { get; set; }

        [DisplayName("Porch/Patio Condition")]
        public Condition PorchCondition { get; set; }

        [DisplayName("Surface Drainage")]
        public SurfaceDrainage SurfaceDrainage { get; set; }

        [DisplayName("Drainage Condition")]
        public Condition SurfaceDrainCondition { get; set; }

        [DisplayName("Retaining Walls")]
        public RetainingWall RetainingWall { get; set; }

        [DisplayName("Wall Condition")]
        public Condition RetainingWallCondition { get; set; }

        public Fencing Fencing { get; set; }

        [DisplayName("Fence Condition")]
        public Condition FenceCondition { get; set; }
  
    }
}
