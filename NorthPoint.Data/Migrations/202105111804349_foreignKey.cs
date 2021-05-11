namespace NorthPoint.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Property", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Property", "UserId");
            AddForeignKey("dbo.Property", "UserId", "dbo.ApplicationUser", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Property", "UserId", "dbo.ApplicationUser");
            DropIndex("dbo.Property", new[] { "UserId" });
            DropColumn("dbo.Property", "UserId");
        }
    }
}
