namespace SingleCustomerList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteTablesFromWorkSqlServer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        OrganizationId = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.OrganizationId);
            
            AddColumn("dbo.Customers", "OrganizationOrgCodeRC", c => c.String());
            DropColumn("dbo.Customers", "MyOrganizationOrgCodeRC");
            DropTable("dbo.MyOrganizations");
        }
        
        public override void Down()
        {
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
            
            AddColumn("dbo.Customers", "MyOrganizationOrgCodeRC", c => c.String());
            DropColumn("dbo.Customers", "OrganizationOrgCodeRC");
            DropTable("dbo.Organizations");
        }
    }
}
