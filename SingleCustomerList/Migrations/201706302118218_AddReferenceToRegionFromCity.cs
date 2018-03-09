namespace SingleCustomerList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReferenceToRegionFromCity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "Region_Id", c => c.Int());
            CreateIndex("dbo.Cities", "Region_Id");
            AddForeignKey("dbo.Cities", "Region_Id", "dbo.Regions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Region_Id", "dbo.Regions");
            DropIndex("dbo.Cities", new[] { "Region_Id" });
            DropColumn("dbo.Cities", "Region_Id");
        }
    }
}
