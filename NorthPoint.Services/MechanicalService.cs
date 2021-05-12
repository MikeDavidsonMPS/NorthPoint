using NorthPoint.Data;
using NorthPoint.Models.Mechanical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPoint.Services
{
    public class MechanicalService
    {
        private readonly Guid _userId;

        public MechanicalService(Guid userId)
        {
            _userId = userId;
        }


        public IEnumerable<MechanicalListItem> GetMechanicals()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                ctx
                    .Mechanicals
                    .Select(e =>
                     new MechanicalListItem
                    {
                        MechId = e.MechId,
                        Address = e.Address,
                        ElecService = e.ElecService,
                        ElecServiceCondition = e.ElecServiceCondition,
                        ServicePanel = e.ServicePanel,
                        PanelCondition = e.PanelCondition,
                        Wiring = e.Wiring,
                        WiringCondition = e.WiringCondition,
                        SwitchPlug = e.SwitchPlug,
                        GFCPlug = e.GFCPlug,
                        SmokeDetectors = e.SmokeDetectors
                     });

                return query.ToArray();
            }
        }
        public bool CreateMechanical(MechanicalCreate model)
        {
            var entity =
                new Mechanical()
                {
                    Address = model.Address,
                    ElecService = model.ElecService,
                    ElecServiceCondition = model.ElecServiceCondition,
                    ServicePanel = model.ServicePanel,
                    PanelCondition = model.PanelCondition,
                    Wiring = model.Wiring,
                    WiringCondition = model.WiringCondition,
                    SwitchPlug = model.SwitchPlug,
                    GFCPlug = model.GFCPlug,
                    SmokeDetectors = model.SmokeDetectors
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Mechanicals.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public MechanicalDetail GetMechanicalById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Mechanicals
                        .Single(e => e.MechId == id);

                return
                    new MechanicalDetail
                    {
                        Address = entity.Address,
                        ElecService = entity.ElecService,
                        ElecServiceCondition = entity.ElecServiceCondition,
                        ServicePanel = entity.ServicePanel,
                        PanelCondition = entity.PanelCondition,
                        Wiring = entity.Wiring,
                        WiringCondition = entity.WiringCondition,
                        SwitchPlug = entity.SwitchPlug,
                        GFCPlug = entity.GFCPlug,
                        SmokeDetectors = entity.SmokeDetectors
                    };
            }
        }

        public bool UpdateMechanical(MechanicalEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                   ctx
                        .Mechanicals
                        .Single(e => e.MechId == model.MechId);

                entity.Address = model.Address;
                entity.ElecService = model.ElecService; ;
                entity.ElecServiceCondition = model.ElecServiceCondition;
                entity.ServicePanel = model.ServicePanel;
                entity.PanelCondition = model.PanelCondition;
                entity.Wiring = model.Wiring;
                entity.WiringCondition = model.WiringCondition;
                entity.SwitchPlug = model.SwitchPlug;
                entity.GFCPlug = model.GFCPlug;
                entity.SmokeDetectors = model.SmokeDetectors;



                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteMechanical(int mechId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Mechanicals
                        .Single(e => e.MechId == mechId);

                ctx.Mechanicals.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
