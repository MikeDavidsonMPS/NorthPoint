using Microsoft.AspNet.Identity;
using NorthPoint.Models.ExComponent;
using NorthPoint.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthPoint.WebMVC.Controllers
{
    public class ExComponentController : Controller
    {
        // GET: ExComponent
        public ActionResult Index()
        {
            var service = CreateExComponentService();
            var model = service.GetExComponentProfiles();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ExComponentCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateExComponentService();

            if (service.CreateExComponent(model))
            {
                TempData["SaveResult"] = "Our Property has been created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Property could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var service = CreateExComponentService();
            var model = service.GetExComponentById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateExComponentService();
            var detail = service.GetExComponentById(id);

            var model =
                new ExComponentEdit
                {
                    ExterId = detail.ExterId,
                    Foundation = detail.Foundation,
                    FoundationCondition = detail.FoundationCondition,
                    FloorStructure = detail.FloorStructure,
                    FloorCondition = detail.FloorCondition,
                    ExteriorWalls = detail.ExteriorWalls,
                    WallCondition = detail.WallCondition,
                    RoofFraming = detail.RoofFraming,
                    RoofFrame = detail.RoofFrame,
                    RoofCover = detail.RoofCover,
                    RoofCondition = detail.RoofCondition,
                    ChimneyType = detail.ChimneyType,
                    ChimneyCondition = detail.ChimneyCondition,
                    RoofDrainage = detail.RoofDrainage,
                    DrainageCondition = detail.DrainageCondition,
                    WallCover = detail.WallCover,
                    WallCovers = detail.WallCovers,
                    EavesSoffitsFascia = detail.EavesSoffitsFascia,
                    EavesSoffitsAndFascia =detail.EavesSoffitsAndFascia,
                    ExteriorDoors = detail.ExteriorDoors,
                    ExtDoorCondition = detail.ExtDoorCondition,
                    Driveways = detail.Driveways,
                    DriveCondition = detail.DriveCondition,
                    Walkways = detail.Walkways,
                    WalkCondition = detail.WalkCondition,
                    GarageDoors = detail.GarageDoors,
                    GarageDoorCond = detail.GarageDoorCond,
                    PorchAndPatio = detail.PorchAndPatio,
                    PorchCondition = detail.PorchCondition,
                    SurfaceDrainage = detail.SurfaceDrainage,
                    SurfaceDrainCondition = detail.SurfaceDrainCondition,
                    RetainingWall = detail.RetainingWall,
                    RetainingWallCondition = detail.RetainingWallCondition,
                    Fencing = detail.Fencing,
                    FenceCondition = detail.FenceCondition

                };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ExComponentEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.ExterId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateExComponentService();

            if (service.UpdateExComponent(model))
            {
                TempData["SaveResult"] = "The property was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The property could not be updated.");

            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var service = CreateExComponentService();
            var model = service.GetExCompenentById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateExComponentService();
            service.DeleteExComponent(id);

            TempData["SaveResult"] = "The property was deleted.";

            return RedirectToAction("Index");
        }



        private ExComponentService CreateExComponentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ExComponentService(userId);
            return service;
        }
    }
}