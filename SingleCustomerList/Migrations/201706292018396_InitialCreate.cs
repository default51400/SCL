namespace SingleCustomerList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
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
                        OrganizationType = c.String(),
                        Region = c.String(),
                        Phone = c.String(),
                        Detail = c.String(),
                        UserLogin = c.String(),
                        MyOrganizationOrgCodeRC = c.String(),
                    })
                .PrimaryKey(t => t.MyCustomerId);
            
            CreateTable(
                "dbo.MyOrganizations",
                c => new
                    {
                        MyOrganizationId = c.Int(nullable: false, identity: true),
                        OrgName = c.String(),
                        OrgShortName = c.String(),
                        OrgStatus = c.String(),
                        OrgCategory = c.String(),
                        OrgCodeRc = c.String(),
                        OrgRegion = c.String(),
                        OrgAdress = c.String(),
                        OrgPhone = c.String(),
                        OrgEDRPOY = c.String(),
                        OrgDetail = c.String(),
                    })
                .PrimaryKey(t => t.MyOrganizationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyOrganizations");
            DropTable("dbo.MyCustomers");
        }
    }
}
