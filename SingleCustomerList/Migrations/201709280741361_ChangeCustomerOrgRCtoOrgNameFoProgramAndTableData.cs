namespace SingleCustomerList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCustomerOrgRCtoOrgNameFoProgramAndTableData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "OrganizationName", c => c.String());
            DropColumn("dbo.Customers", "OrganizationOrgCodeRC");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "OrganizationOrgCodeRC", c => c.String());
            DropColumn("dbo.Customers", "OrganizationName");
        }
    }
}
