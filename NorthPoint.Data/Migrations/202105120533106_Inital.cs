namespace NorthPoint.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExComponent",
                c => new
                    {
                        ExterId = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        Foundation = c.Int(nullable: false),
                        FoundationCondition = c.Int(nullable: false),
                        FloorStructure = c.Int(nullable: false),
                        FloorCondition = c.Int(nullable: false),
                        ExteriorWalls = c.Int(nullable: false),
                        WallCondition = c.Int(nullable: false),
                        RoofFraming = c.Int(nullable: false),
                        RoofFrame = c.Int(nullable: false),
                        RoofCover = c.Int(nullable: false),
                        RoofCondition = c.Int(nullable: false),
                        ChimneyType = c.Int(nullable: false),
                        ChimneyCondition = c.Int(nullable: false),
                        RoofDrainage = c.Int(nullable: false),
                        DrainageCondition = c.Int(nullable: false),
                        WallCover = c.Int(nullable: false),
                        WallCovers = c.Int(nullable: false),
                        EavesSoffitsFascia = c.Int(nullable: false),
                        EavesSoffitsAndFascia = c.Int(nullable: false),
                        ExteriorDoors = c.Int(nullable: false),
                        ExtDoorCondition = c.Int(nullable: false),
                        Driveways = c.Int(nullable: false),
                        DriveCondition = c.Int(nullable: false),
                        Walkways = c.Int(nullable: false),
                        WalkCondition = c.Int(nullable: false),
                        GarageDoors = c.Int(nullable: false),
                        GarageDoorCond = c.Int(nullable: false),
                        PorchAndPatio = c.Int(nullable: false),
                        PorchCondition = c.Int(nullable: false),
                        SurfaceDrainage = c.Int(nullable: false),
                        SurfaceDrainCondition = c.Int(nullable: false),
                        RetainingWall = c.Int(nullable: false),
                        RetainingWallCondition = c.Int(nullable: false),
                        Fencing = c.Int(nullable: false),
                        FenceCondition = c.Int(nullable: false),
                        PropertyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExterId)
                .ForeignKey("dbo.ApplicationUser", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                        IdentityRole_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id);
            
            CreateTable(
                "dbo.Financial",
                c => new
                    {
                        FinId = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        ListPrice = c.Int(nullable: false),
                        PurchasePrice = c.Int(nullable: false),
                        LendersName = c.String(nullable: false),
                        TypeOfMortgages = c.Int(nullable: false),
                        InterestRate = c.Int(nullable: false),
                        DownPayment = c.Int(nullable: false),
                        MonthlyPayments = c.Int(nullable: false),
                        TaxAssessment = c.Int(nullable: false),
                        AnnualTaxAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FinId)
                .ForeignKey("dbo.ApplicationUser", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Mechanical",
                c => new
                    {
                        MechId = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        ElecService = c.Int(nullable: false),
                        ElecServiceCondition = c.Int(nullable: false),
                        ServicePanel = c.Int(nullable: false),
                        PanelCondition = c.Int(nullable: false),
                        Wiring = c.Int(nullable: false),
                        WiringCondition = c.Int(nullable: false),
                        SwitchPlug = c.Int(nullable: false),
                        GFCPlug = c.Int(nullable: false),
                        SmokeDetectors = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MechId)
                .ForeignKey("dbo.ApplicationUser", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Property",
                c => new
                    {
                        PropertyId = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        Address = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                        ZipCode = c.Int(nullable: false),
                        PurchasePrice = c.Int(nullable: false),
                        DateTime = c.Int(nullable: false),
                        SqFt = c.Int(nullable: false),
                        HomeTypes = c.Int(nullable: false),
                        ArchitecturalStyle = c.Int(nullable: false),
                        Construction = c.Int(nullable: false),
                        RoofType = c.Int(nullable: false),
                        FoundationType = c.Int(nullable: false),
                        NewConstruction = c.Boolean(nullable: false),
                        HistroicRegister = c.Boolean(nullable: false),
                        NumberOfLevels = c.Int(nullable: false),
                        AttachedGarage = c.Boolean(nullable: false),
                        GarageSpaces = c.Int(nullable: false),
                        NumberOfFireplaces = c.Int(nullable: false),
                        NumberOfBathrooms = c.Int(nullable: false),
                        NumberOfFullBaths = c.Int(nullable: false),
                        NumberOfHaftBaths = c.Int(nullable: false),
                        NumberOfBedrooms = c.Int(nullable: false),
                        ListPrice = c.Int(nullable: false),
                        DownPayment = c.Int(nullable: false),
                        MonthlyPayments = c.Int(nullable: false),
                        TypeOfMortgages = c.Int(nullable: false),
                        CreateUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                        YearBuilt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PropertyId)
                .ForeignKey("dbo.ApplicationUser", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.Property", "UserId", "dbo.ApplicationUser");
            DropForeignKey("dbo.Mechanical", "UserId", "dbo.ApplicationUser");
            DropForeignKey("dbo.Financial", "UserId", "dbo.ApplicationUser");
            DropForeignKey("dbo.ExComponent", "UserId", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropIndex("dbo.Property", new[] { "UserId" });
            DropIndex("dbo.Mechanical", new[] { "UserId" });
            DropIndex("dbo.Financial", new[] { "UserId" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.ExComponent", new[] { "UserId" });
            DropTable("dbo.IdentityRole");
            DropTable("dbo.Property");
            DropTable("dbo.Mechanical");
            DropTable("dbo.Financial");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.ExComponent");
        }
    }
}
