namespace SingleCustomerList.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SclContext> 
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SingleCustomerList.MyCustomersModel";
        }
        protected override void Seed(SclContext context)
        {
            Debug.WriteLine("Finished.");
        }
    }
}
