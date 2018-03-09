namespace SingleCustomerList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLoginTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Region = c.String(),
                        Code = c.String(),
                        Category = c.String(),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MyCustomers", "OrganizationCategory", c => c.String());
            AddColumn("dbo.MyCustomers", "Code", c => c.String());
            DropColumn("dbo.MyCustomers", "OrganizationType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MyCustomers", "OrganizationType", c => c.String());
            DropColumn("dbo.MyCustomers", "Code");
            DropColumn("dbo.MyCustomers", "OrganizationCategory");
            DropTable("dbo.Logins");
        }
    }
}
