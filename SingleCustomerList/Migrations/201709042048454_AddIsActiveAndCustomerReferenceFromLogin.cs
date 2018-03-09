namespace SingleCustomerList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsActiveAndCustomerReferenceFromLogin : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Login_Id", "dbo.Logins");
            DropIndex("dbo.Customers", new[] { "Login_Id" });
            AddColumn("dbo.Logins", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Logins", "Customer_CustomerId", c => c.Int());
            CreateIndex("dbo.Logins", "Customer_CustomerId");
            AddForeignKey("dbo.Logins", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            DropColumn("dbo.Customers", "Login_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Login_Id", c => c.Int());
            DropForeignKey("dbo.Logins", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Logins", new[] { "Customer_CustomerId" });
            DropColumn("dbo.Logins", "Customer_CustomerId");
            DropColumn("dbo.Logins", "IsActive");
            CreateIndex("dbo.Customers", "Login_Id");
            AddForeignKey("dbo.Customers", "Login_Id", "dbo.Logins", "Id");
        }
    }
}
