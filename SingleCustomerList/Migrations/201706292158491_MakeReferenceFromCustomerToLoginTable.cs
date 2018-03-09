namespace SingleCustomerList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeReferenceFromCustomerToLoginTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MyCustomers", "UserLoginId", c => c.Int(nullable: false));
            DropColumn("dbo.MyCustomers", "UserLogin");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MyCustomers", "UserLogin", c => c.String());
            DropColumn("dbo.MyCustomers", "UserLoginId");
        }
    }
}
