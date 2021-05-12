namespace NorthPoint.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExComponent", "Address", c => c.String(nullable: false));
            AddColumn("dbo.Financial", "Address", c => c.String());
            AddColumn("dbo.Financial", "City", c => c.String());
            AddColumn("dbo.Financial", "State", c => c.String());
            AddColumn("dbo.Financial", "RemainingYearsOnLoan", c => c.String(nullable: false));
            AddColumn("dbo.Mechanical", "Address", c => c.String(nullable: false));
            AddColumn("dbo.Property", "RemainingYearOnLoan", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Property", "RemainingYearOnLoan");
            DropColumn("dbo.Mechanical", "Address");
            DropColumn("dbo.Financial", "RemainingYearsOnLoan");
            DropColumn("dbo.Financial", "State");
            DropColumn("dbo.Financial", "City");
            DropColumn("dbo.Financial", "Address");
            DropColumn("dbo.ExComponent", "Address");
        }
    }
}
