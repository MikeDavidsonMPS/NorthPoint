using NorthPoint.Data;
using NorthPoint.Models.ExComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPoint.Services
{
    public class ExComponentService
    {
        private readonly Guid _userId;

        public ExComponentService(Guid userId)
        {
            _userId = userId;
        }

        public IEnumerable<ExComponentListItem> GetExComponentProfiles()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .ExComponents
                        .Select(e =>
                        new ExComponentListItem
                        {
                            ExterId = e.ExterId,
                            Address = e.Address,
                            Foundation= e.Foundation,
                            FloorStructure = e.FloorStructure,
                            ExteriorWalls = e.ExteriorWalls,
                            RoofFraming = e.RoofFraming,
                            RoofCover = e.RoofCover,
                            ChimneyType = e.ChimneyType,
                            RoofDrainage = e.RoofDrainage,
                            WallCover = e.WallCover,
                            EavesSoffitsFascia = e.EavesSoffitsFascia,
                            ExteriorDoors = e.ExteriorDoors,
                            Driveways = e.Driveways,
                            Walkways = e.Walkways,
                            GarageDoors = e.GarageDoors,
                            PorchAndPatio = e.PorchAndPatio,
                            SurfaceDrainage = e.SurfaceDrainage,
                            RetainingWall = e.RetainingWall,
                            Fencing = e.Fencing

                        });

                return query.ToArray();
            }
        }

        public bool CreateExComponent(ExComponentCreate model)
        {
            var entity =
                new ExComponent()
                {
                    Address = (string)model.Address,
                    Foundation = model.Foundation,
                    FoundationCondition = model.FoundationCondition,
                    FloorStructure = model.FloorStructure,
                    FloorCondition = model.FloorCondition,
                    ExteriorWalls = model.ExteriorWalls,
                    WallCondition = model.WallCondition,
                    RoofFraming = model.RoofFraming,
                    RoofFrame = model.RoofFrame,
                    RoofCover = model.RoofCover,
                    RoofCondition = model.RoofCondition,
                    ChimneyType = model.ChimneyType,
                    ChimneyCondition = model.ChimneyCondition,
                    RoofDrainage = model.RoofDrainage,
                    DrainageCondition = model.DrainageCondition,
                    WallCover = model.WallCover,
                    WallCovers = model.WallCovers,
                    EavesSoffitsFascia = model.EavesSoffitsFascia,
                    EavesSoffitsAndFascia = model.EavesSoffitsAndFascia,
                    ExteriorDoors = model.ExteriorDoors,
                    ExtDoorCondition = model.ExtDoorCondition,
                    Driveways = model.Driveways,
                    DriveCondition = model.DriveCondition,
                    Walkways = model.Walkways,
                    WalkCondition = model.WalkCondition,
                    GarageDoors = model.GarageDoors,
                    GarageDoorCond = model.GarageDoorCond,
                    PorchAndPatio = model.PorchAndPatio,
                    PorchCondition = model.PorchCondition,
                    SurfaceDrainage = model.SurfaceDrainage,
                    SurfaceDrainCondition = model.SurfaceDrainCondition,
                    RetainingWall = model.RetainingWall,
                    RetainingWallCondition = model.RetainingWallCondition,
                    Fencing = model.Fencing,
                    FenceCondition = model.FenceCondition
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.ExComponents.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public ExComponentDetail GetExComponentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .ExComponents
                        .Single(e => e.ExterId == id);

                return
                    new ExComponentDetail
                    {
                        Address = entity.Address,
                        Foundation= entity.Foundation,
                        FoundationCondition = entity.FoundationCondition,
                        FloorStructure = entity.FloorStructure,
                        FloorCondition = entity.FloorCondition,
                        ExteriorWalls = entity.ExteriorWalls,
                        WallCondition = entity.WallCondition,
                        RoofFraming = entity.RoofFraming,
                        RoofFrame = entity.RoofFrame,
                        RoofCover = entity.RoofCover,
                        RoofCondition= entity.RoofCondition,
                        ChimneyType = entity.ChimneyType,
                        ChimneyCondition = entity.ChimneyCondition,
                        RoofDrainage = entity.RoofDrainage,
                        DrainageCondition = entity.DrainageCondition,
                        WallCover = entity.WallCover,
                        WallCovers = entity.WallCovers,
                        EavesSoffitsFascia = entity.EavesSoffitsFascia,
                        EavesSoffitsAndFascia = entity.EavesSoffitsAndFascia,
                        ExteriorDoors = entity.ExteriorDoors,
                        ExtDoorCondition = entity.ExtDoorCondition,
                        Driveways = entity.Driveways,
                        DriveCondition = entity.DriveCondition,
                        Walkways = entity.Walkways,
                        WalkCondition = entity.WalkCondition,
                        GarageDoors = entity.GarageDoors,
                        GarageDoorCond = entity.GarageDoorCond,
                        PorchAndPatio = entity.PorchAndPatio,
                        PorchCondition = entity.PorchCondition,
                        SurfaceDrainage = entity.SurfaceDrainage,
                        SurfaceDrainCondition = entity.SurfaceDrainCondition,
                        RetainingWall = entity.RetainingWall,
                        RetainingWallCondition = entity.RetainingWallCondition,
                        Fencing = entity.Fencing,
                        FenceCondition = entity.FenceCondition
                    };
            }
        }

        public bool UpdateExComponents(ExComponentEdit model)
        {
            throw new NotImplementedException();
        }

        public object GetExCompenentById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateExComponent(ExComponentEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .ExComponents
                        .Single(e => e.ExterId == model.ExterId);

                    entity.Foundation = model.Foundation;
                    entity.FoundationCondition = model.FoundationCondition;
                    entity.FloorStructure = model.FloorStructure;
                    entity.FloorCondition = model.FloorCondition;
                    entity.ExteriorWalls = model.ExteriorWalls;
                    entity.WallCondition = model.WallCondition;
                    entity.RoofFraming = model.RoofFraming;
                    entity.RoofFrame = model.RoofFrame;
                    entity.RoofCover = model.RoofCover;
                    entity.RoofCondition = model.RoofCondition;
                    entity.ChimneyType = model.ChimneyType;
                    entity.ChimneyCondition = model.ChimneyCondition;
                    entity.RoofDrainage = model.RoofDrainage;
                    entity.DrainageCondition = model.DrainageCondition;
                    entity.WallCover = model.WallCover;
                    entity.WallCovers = model.WallCovers;
                    entity.EavesSoffitsFascia = model.EavesSoffitsFascia;
                    entity.EavesSoffitsAndFascia = model.EavesSoffitsAndFascia;
                    entity.ExteriorDoors = model.ExteriorDoors;
                    entity.ExtDoorCondition = model.ExtDoorCondition;
                    entity.Driveways = model.Driveways;
                    entity.DriveCondition = model.DriveCondition;
                    entity.Walkways = model.Walkways;
                    entity.WalkCondition = model.WalkCondition;
                    entity.GarageDoors = model.GarageDoors;
                    entity.GarageDoorCond = model.GarageDoorCond;
                    entity.PorchAndPatio = model.PorchAndPatio;
                    entity.PorchCondition = model.PorchCondition;
                    entity.SurfaceDrainage = model.SurfaceDrainage;
                    entity.SurfaceDrainCondition = model.SurfaceDrainCondition;
                    entity.RetainingWall = model.RetainingWall;
                    entity.RetainingWallCondition = model.RetainingWallCondition;
                    entity.Fencing = model.Fencing;
                    entity.FenceCondition = model.FenceCondition;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteExComponent(int exterId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .ExComponents
                        .Single(e => e.ExterId == exterId);

                ctx.ExComponents.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
