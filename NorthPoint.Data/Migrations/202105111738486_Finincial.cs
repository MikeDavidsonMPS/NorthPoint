namespace NorthPoint.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Finincial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Financial", "UserId", "dbo.ApplicationUser");
            DropIndex("dbo.Financial", new[] { "UserId" });
            AddColumn("dbo.Financial", "InterestRate", c => c.Int(nullable: false));
            AddColumn("dbo.Financial", "DownPayment", c => c.Int(nullable: false));
            AddColumn("dbo.Financial", "MonthlyPayments", c => c.Int(nullable: false));
            AddColumn("dbo.Property", "ListPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Property", "DownPayment", c => c.Int(nullable: false));
            AddColumn("dbo.Property", "MonthlyPayments", c => c.Int(nullable: false));
            AddColumn("dbo.Property", "TypeOfMortgages", c => c.Int(nullable: false));
            DropColumn("dbo.Financial", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Financial", "UserId", c => c.String(maxLength: 128));
            DropColumn("dbo.Property", "TypeOfMortgages");
            DropColumn("dbo.Property", "MonthlyPayments");
            DropColumn("dbo.Property", "DownPayment");
            DropColumn("dbo.Property", "ListPrice");
            DropColumn("dbo.Financial", "MonthlyPayments");
            DropColumn("dbo.Financial", "DownPayment");
            DropColumn("dbo.Financial", "InterestRate");
            CreateIndex("dbo.Financial", "UserId");
            AddForeignKey("dbo.Financial", "UserId", "dbo.ApplicationUser", "Id");
        }
    }
}
