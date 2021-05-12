using Microsoft.AspNet.Identity;
using NorthPoint.Models.Mechanical;
using NorthPoint.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthPoint.WebMVC.Controllers
{
    public class MechanicalController : Controller
    {
         //GET: Mechanical Assets
        public ActionResult Index()
        {
           var service = CreateMechanicalService();
            var model = service.GetMechanicals();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MechanicalCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateMechanicalService();

            if (service.CreateMechanical(model))
            {
                TempData["SaveResult"] = "Our Property has been created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Property could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var service = CreateMechanicalService();
            var model = service.GetMechanicalById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateMechanicalService();
            var detail = service.GetMechanicalById(id);

            var model =
                new MechanicalEdit
                {
                    MechId = detail.MechId,
                    Address = detail.Address,
                    ElecService = detail.ElecService,
                    ElecServiceCondition = detail.ElecServiceCondition,
                    ServicePanel = detail.ServicePanel,
                    PanelCondition = detail.PanelCondition,
                    Wiring = detail.Wiring,
                    WiringCondition = detail.WiringCondition,
                    SwitchPlug = detail.SwitchPlug,
                    GFCPlug = detail.GFCPlug,
                    SmokeDetectors = detail.SmokeDetectors

                };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MechanicalEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.MechId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateMechanicalService();

            if (service.UpdateMechanical(model))
            {
                TempData["SaveResult"] = "The information was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The information could not be updated.");

            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var service = CreateMechanicalService();
            var model = service.GetMechanicalById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateMechanicalService();
            service.DeleteMechanical(id);

            TempData["SaveResult"] = "The property was deleted.";

            return RedirectToAction("Index");
        }



        private MechanicalService CreateMechanicalService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new MechanicalService(userId);
            return service;
        }
    }
}