namespace SingleCustomerList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRegionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginCategory = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.MyCustomers", "OrganizationCategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MyCustomers", "OrganizationCategory", c => c.String());
            DropTable("dbo.Regions");
        }
    }
}
