namespace SingleCustomerList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameRegionToCategoryAndRefactoring : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginCategory = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        SurName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserStatus = c.String(),
                        UserIdINN = c.String(),
                        WorkingPosition = c.String(),
                        Phone = c.String(),
                        Detail = c.String(),
                        UserLoginId = c.Int(nullable: false),
                        MyOrganizationOrgCodeRC = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            DropTable("dbo.MyCustomers");
            DropTable("dbo.Regions");
        }
        
        public override void Down()
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
            
            CreateTable(
                "dbo.MyCustomers",
                c => new
                    {
                        MyCustomerId = c.Int(nullable: false, identity: true),
                        SurName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserStatus = c.String(),
                        UserIdINN = c.String(),
                        WorkingPosition = c.String(),
                        Region = c.String(),
                        Phone = c.String(),
                        Detail = c.String(),
                        UserLoginId = c.Int(nullable: false),
                        Code = c.String(),
                        MyOrganizationOrgCodeRC = c.String(),
                    })
                .PrimaryKey(t => t.MyCustomerId);
            
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}
