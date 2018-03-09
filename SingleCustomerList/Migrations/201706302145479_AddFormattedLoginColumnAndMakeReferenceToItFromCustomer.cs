namespace SingleCustomerList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFormattedLoginColumnAndMakeReferenceToItFromCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Login_Id", c => c.Int());
            AddColumn("dbo.Logins", "FormatLogin", c => c.String());
            CreateIndex("dbo.Customers", "Login_Id");
            AddForeignKey("dbo.Customers", "Login_Id", "dbo.Logins", "Id");
            DropColumn("dbo.Customers", "UserLoginId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "UserLoginId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Customers", "Login_Id", "dbo.Logins");
            DropIndex("dbo.Customers", new[] { "Login_Id" });
            DropColumn("dbo.Logins", "FormatLogin");
            DropColumn("dbo.Customers", "Login_Id");
        }
    }
}
