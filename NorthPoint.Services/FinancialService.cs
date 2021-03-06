using NorthPoint.Data;
using NorthPoint.Models.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPoint.Services
{
    public class FinancialService
    {

        private readonly Guid _userId;

        public FinancialService(Guid userId)
        {
            _userId = userId;
        }
        public IEnumerable<FinancialListItem> GetFinancials()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                ctx
                    .Financials
                    .Select(e =>
                    new FinancialListItem
                    {
                        FinId = e.FinId,
                        Address = e.Address,
                        City = e.City,
                        State = e.State,
                        ListPrice = e.ListPrice,
                        LendersName = e.LendersName,
                        TypeOfMortgage = e.TypeOfMortgages,
                        InterestRate = e.InterestRate,
                        DownPayment = e.DownPayment,
                        MonthlyPayments = e.MonthlyPayments,
                        TaxAssessment = e.TaxAssessment,
                        AnnualTaxAmount = e.AnnualTaxAmount,
                        RemainingYearsOnLoan = e.RemainingYearsOnLoan

                    });

                return query.ToArray();
            }
        }
        public bool CreateFinancial(FinancialCreate model)
        {
            var entity =
                new Financial()
                {
                    Address = (string)model.Address,
                    ListPrice = model.ListPrice,
                    PurchasePrice = model.PurchasePrice,
                    LendersName = model.LendersName,
                    TypeOfMortgages = model.TypeOfMortgages,
                    InterestRate = model.InterestRate,
                    DownPayment = model.DownPayment,
                    MonthlyPayments = model.MonthlyPayments,
                    RemainingYearsOnLoan = (string)model.RemainingYearsOnLoan,
                    TaxAssessment = model.TaxAssessment,
                    AnnualTaxAmount = model.AnnualTaxAmount

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Financials.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public FinancialDetail GetFinancialById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Financials
                        .Single(e => e.FinId == id);

                return
                    new FinancialDetail
                    {
                        Address = (string)entity.Address,
                        ListPrice = entity.ListPrice,
                        PurchasePrice = entity.PurchasePrice,
                        LendersName = entity.LendersName,
                        TypeOfMortgages = entity.TypeOfMortgages,
                        InterestRate = entity.InterestRate,
                        DownPayment = entity.DownPayment,
                        MonthlyPayments = entity.MonthlyPayments,
                        RemainingYearsOnLoan = entity.RemainingYearsOnLoan,
                        TaxAssessment = entity.TaxAssessment,
                        AnnualTaxAmount = entity.AnnualTaxAmount

                    };
            }
        }

        public bool UpdateFinancial(FinancialEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Financials
                        .Single(e => e.FinId == model.FinId);

                entity.FinId = model.FinId;
                entity.Address = model.Address;
                entity.ListPrice = model.ListPrice;
                entity.PurchasePrice = model.PurchasePrice;
                entity.LendersName = model.LendersName;
                entity.TypeOfMortgages = model.TypeOfMortgages;
                entity.InterestRate = model.InterestRate;
                entity.DownPayment = model.DownPayment;
                entity.MonthlyPayments = model.MonthlyPayments;
                entity.RemainingYearsOnLoan = (string)model.RemainingYearsOnLoan;
                entity.TaxAssessment = model.TaxAssessment;
                entity.AnnualTaxAmount = model.AnnualTaxAmount;


                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteFinancial(int finId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Financials
                        .Single(e => e.FinId == finId);

                ctx.Financials.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
