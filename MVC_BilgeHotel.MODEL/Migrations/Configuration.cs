namespace MVC_BilgeHotel.MODEL.Migrations
{
    using MVC_BilgeHotel.MODEL.Context;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_BilgeHotel.MODEL.Context.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVC_BilgeHotel.MODEL.Context.ProjectContext context)
        {
            SampleData data = new SampleData();
            data.InitializeDatabase(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
