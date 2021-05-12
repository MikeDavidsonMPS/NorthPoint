using NorthPoint.Data;
using NorthPoint.Models.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPoint.Services
{
    public class PropertyService
    {
        private readonly Guid _userId;

        public PropertyService(Guid userId)
        {
            _userId = userId;
        }

        public IEnumerable<PropertyListItem> GetPropertyProfiles()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .PropertyProfiles
                        .Select(e =>
                        new PropertyListItem
                        {
                            PropertyId = e.PropertyId,
                            Address = e.Address,
                            City = e.City,
                            State = e.State,
                            PurchasePrice = e.PurchasePrice,
                            YearBuilt = e.YearBuilt,
                            CreateUtc = e.CreateUtc,
                            ModifiedUtc = e.ModifiedUtc
                        });

                return query.ToArray();
            }
        }

        public bool CreateProperty(PropertyCreate model)
        {
            var entity =
                new Property()
                {
                    Address = model.Address,
                    City = model.City,
                    State = model.State,
                    ZipCode = model.ZipCode,
                    PurchasePrice = model.PurchasePrice,
                    YearBuilt = model.YearBuilt,
                    SqFt = model.SqFt,
                    HomeTypes = model.HomeTypes,
                    ArchitecturalStyle = model.ArchitecturalStyle,
                    Construction = model.Construction,
                    RoofType = model.RoofType,
                    FoundationType = model.FoundationType,
                    NewConstruction = model.NewConstruction,
                    HistroicRegister = model.HistroicRegister,
                    NumberOfLevels = model.NumberOfLevels,
                    AttachedGarage = model.AttachedGarage,
                    GarageSpaces = model.GarageSpaces,
                    NumberOfFireplaces = model.NumberOfFireplaces,
                    NumberOfBathrooms = model.NumberOfBathrooms,
                    NumberOfFullBaths = model.NumberOfFullBaths,
                    NumberOfHaftBaths = model.NumberOfHaftBaths,
                    NumberOfBedrooms = model.NumberOfBedrooms,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.PropertyProfiles.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public PropertyDetails GetPropertyById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .PropertyProfiles
                        .Single(e => e.PropertyId == id);

                return
                    new PropertyDetails
                    {
                        Address = entity.Address,
                        City = entity.City,
                        State = entity.State,
                        ZipCode = entity.ZipCode,
                        PurchasePrice = entity.PurchasePrice,
                        YearBuilt = entity.YearBuilt,
                        SqFt = entity.SqFt,
                        HomeTypes = entity.HomeTypes,
                        ArchitecturalStyle = entity.ArchitecturalStyle,
                        Construction = entity.Construction,
                        RoofType = entity.RoofType,
                        FoundationType = entity.FoundationType,
                        NewConstruction = entity.NewConstruction,
                        HistroicRegister = entity.HistroicRegister,
                        NumberOfLevels = entity.NumberOfLevels,
                        AttachedGarage = entity.AttachedGarage,
                        GarageSpaces = entity.GarageSpaces,
                        NumberOfFireplaces = entity.NumberOfFireplaces,
                        NumberOfBathrooms = entity.NumberOfBathrooms,
                        NumberOfFullBaths = entity.NumberOfFullBaths,
                        NumberOfHaftBaths = entity.NumberOfHaftBaths,
                        NumberOfBedrooms = entity.NumberOfBedrooms,
                    };
            }
        }

        public bool UpdateProperty(PropertyEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .PropertyProfiles
                        .Single(e => e.PropertyId == model.PropertyId);

                entity.PropertyId = model.PropertyId;
                entity.Address = model.Address;
                entity.City = model.City;
                entity.State = model.State;
                entity.ZipCode = model.ZipCode;
                entity.PurchasePrice = model.PurchasePrice;
                entity.YearBuilt = model.YearBuilt;
                entity.SqFt = model.SqFt;
                entity.HomeTypes = model.HomeTypes;
                entity.ArchitecturalStyle = model.ArchitecturalStyle;
                entity.Construction = model.Construction;
                entity.RoofType = model.RoofType;
                entity.FoundationType = model.FoundationType;
                entity.NewConstruction = model.NewConstruction;
                entity.HistroicRegister = model.HistroicRegister;
                entity.NumberOfLevels = model.NumberOfLevels;
                entity.AttachedGarage = model.AttachedGarage;
                entity.GarageSpaces = model.GarageSpaces;
                entity.NumberOfFireplaces = model.NumberOfFireplaces;
                entity.NumberOfBathrooms = model.NumberOfBathrooms;
                entity.NumberOfFullBaths = model.NumberOfFullBaths;
                entity.NumberOfHaftBaths = model.NumberOfHaftBaths;
                entity.NumberOfBedrooms = model.NumberOfBedrooms;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteProperty(int propertyId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .PropertyProfiles
                        .Single(e => e.PropertyId == propertyId);

                ctx.PropertyProfiles.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
