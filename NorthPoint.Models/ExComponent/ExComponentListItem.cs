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
    public class ExComponentListItem
    {
        public int PropertyId { get; set; }

        public object Address { get; set; }

    
        [DisplayName("Foundation")]
        public Foundations Foundation { get; set; }

        [DisplayName("Floor Structure")]
        public FloorStructure FloorStructure { get; set; }

        [DisplayName("Exterior Walls")]
        public ExteriorWalls ExteriorWalls { get; set; }

        [DisplayName("Roof Framing")]
        public RoofStructure RoofFraming { get; set; }

        [DisplayName("Roof Cover")]
        public RoofCover RoofCover { get; set; }

        [DisplayName("Chimneys")]
        public ChimneyType ChimneyType { get; set; }

        [DisplayName("Roof Drainage")]
        public RoofDrainage RoofDrainage { get; set; }

        [DisplayName("Wall Covering")]
        public WallCover WallCover { get; set; }

        [DisplayName("Eaves Soffits and Fascias")]
        public EavesSoffitsFascia EavesSoffitsFascia { get; set; }

        [DisplayName("Exterior Doors")]
        public ExteriorDoors ExteriorDoors { get; set; }
        public Driveway Driveways { get; set; }
        public Walkways Walkways { get; set; }

        [DisplayName("Garage Doors")]
        public GarageDoors GarageDoors { get; set; }

        [DisplayName("Porch and Patio")]
        public PorchAndPatio PorchAndPatio { get; set; }

        [DisplayName("Surface Drainage")]
        public SurfaceDrainage SurfaceDrainage { get; set; }

        [DisplayName("Retaining Walls")]
        public RetainingWall RetainingWall { get; set; }

        public Fencing Fencing { get; set; }




    }
}
