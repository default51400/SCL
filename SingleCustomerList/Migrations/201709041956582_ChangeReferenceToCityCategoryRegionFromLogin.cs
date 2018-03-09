namespace SingleCustomerList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeReferenceToCityCategoryRegionFromLogin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Logins", "Category_Id", c => c.Int());
            AddColumn("dbo.Logins", "City_Id", c => c.Int());
            AddColumn("dbo.Logins", "Region_Id", c => c.Int());
            CreateIndex("dbo.Logins", "Category_Id");
            CreateIndex("dbo.Logins", "City_Id");
            CreateIndex("dbo.Logins", "Region_Id");
            AddForeignKey("dbo.Logins", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Logins", "City_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Logins", "Region_Id", "dbo.Regions", "Id");
            DropColumn("dbo.Logins", "Region");
            DropColumn("dbo.Logins", "Code");
            DropColumn("dbo.Logins", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Logins", "Category", c => c.String());
            AddColumn("dbo.Logins", "Code", c => c.String());
            AddColumn("dbo.Logins", "Region", c => c.String());
            DropForeignKey("dbo.Logins", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.Logins", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Logins", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Logins", new[] { "Region_Id" });
            DropIndex("dbo.Logins", new[] { "City_Id" });
            DropIndex("dbo.Logins", new[] { "Category_Id" });
            DropColumn("dbo.Logins", "Region_Id");
            DropColumn("dbo.Logins", "City_Id");
            DropColumn("dbo.Logins", "Category_Id");
        }
    }
}
