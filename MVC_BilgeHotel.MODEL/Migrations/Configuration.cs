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

        //TODO: Seed Basmak için aþaðýda yorum satýrý içerinde bulunan kodlarýn, Model katmaný içerisinde bulunan Migrations içerisinede bulunan, Configuration classý içerisine Seed metot içerisine verilmesi gerekmektedir. Migrations sillerseniz tekrardan burdan yapýþtýrabilirisiniz.

        //
        //            SampleData data = new SampleData();
        //      data.InitializeDatabase(context);


        protected override void Seed(MVC_BilgeHotel.MODEL.Context.ProjectContext context)
        {
            SampleData data = new SampleData();
            data.InitializeDatabase(context);
        }
    }
}
