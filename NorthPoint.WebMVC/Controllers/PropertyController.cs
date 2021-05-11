using Microsoft.AspNet.Identity;
using NorthPoint.Models.Property;
using NorthPoint.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthPoint.WebMVC.Controllers
{
    [Authorize]
    public class PropertyController : Controller
    {
        // GET: PropertyProfile
        public ActionResult Index()
        {
            var service = CreatePropertyService();
            var model = service.GetPropertyProfiles();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PropertyCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreatePropertyService();

            if (service.CreateProperty(model))
            {
                TempData["SaveResult"] = "Our Property has been created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Property could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var service = CreatePropertyService();
            var model = service.GetPropertyById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreatePropertyService();
            var detail = service.GetPropertyById(id);

            var model =
                new PropertyEdit
                {
                    PropertyId = detail.PropertyId,
                    Address = detail.Address,
                    City = detail.City,
                    State = detail.State,
                    ZipCode = detail.ZipCode,
                    PurchasePrice = detail.PurchasePrice,
                    YearBuilt = detail.YearBuilt,
                    SqFt = detail.SqFt,
                    HomeTypes = detail.HomeTypes,
                    ArchitecturalStyle = detail.ArchitecturalStyle,
                    Construction = detail.Construction,
                    RoofType = detail.RoofType,
                    FoundationType = detail.FoundationType,
                    NewConstruction = detail.NewConstruction,
                    HistroicRegister = detail.HistroicRegister,
                    NumberOfLevels = detail.NumberOfLevels,
                    AttachedGarage = detail.AttachedGarage,
                    GarageSpaces = detail.GarageSpaces,
                    NumberOfFireplaces = detail.NumberOfFireplaces,
                    NumberOfBathrooms = detail.NumberOfBathrooms,
                    NumberOfFullBaths = detail.NumberOfFullBaths,
                    NumberOfHaftBaths = detail.NumberOfHaftBaths,
                    NumberOfBedrooms = detail.NumberOfBedrooms
                };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PropertyEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.PropertyId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreatePropertyService();

            if (service.UpdateProperty(model))
            {
                TempData["SaveResult"] = "The property was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The property could not be updated.");

            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var service = CreatePropertyService();
            var model = service.GetPropertyById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreatePropertyService();
            service.DeleteProperty(id);

            TempData["SaveResult"] = "The property was deleted.";

            return RedirectToAction("Index");
        }



        private PropertyService CreatePropertyService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PropertyService(userId);
            return service;
        }
    }
}