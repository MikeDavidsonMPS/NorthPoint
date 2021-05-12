using Microsoft.AspNet.Identity;
using NorthPoint.Models.Financial;
using NorthPoint.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthPoint.WebMVC.Controllers
{
    public class FinancialController : Controller
    {
       
        // GET: Investment Portfolio
        public ActionResult Index()
        {
            var service = CreateFinancialService();
            var model = service.GetFinancials();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FinancialCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateFinancialService();

            if (service.CreateFinancial(model))
            {
                TempData["SaveResult"] = "Our Property has been created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Property could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var service = CreateFinancialService();
            var model = service.GetFinancialById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateFinancialService();
            var detail = service.GetFinancialById(id);

            var model =
                new FinancialEdit
                {
                    FinancialId = detail.FinancialId,
                    Address = detail.Address,
                    ListPrice = detail.ListPrice,
                    PurchasePrice = detail.PurchasePrice,
                    LendersName = detail.LendersName,
                    TypeOfMortgages = detail.TypeOfMortgages,
                    InterestRate = detail.InterestRate,
                    DownPayment = detail.DownPayment,
                    MonthlyPayments = detail.MonthlyPayments,
                    RemainingYearsOnLoan = detail.RemainingYearsOnLoan,
                    TaxAssessment = detail.TaxAssessment,
                    AnnualTaxAmount = detail.AnnualTaxAmount
                   
                };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FinancialEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.FinancialId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateFinancialService();

            if (service.UpdateFinancial(model))
            {
                TempData["SaveResult"] = "The information was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The information could not be updated.");

            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var service = CreateFinancialService();
            var model = service.GetFinancialById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateFinancialService();
            service.DeleteFinancial(id);

            TempData["SaveResult"] = "The property was deleted.";

            return RedirectToAction("Index");
        }



        private FinancialService CreateFinancialService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new FinancialService(userId);
            return service;
        }
    }
}