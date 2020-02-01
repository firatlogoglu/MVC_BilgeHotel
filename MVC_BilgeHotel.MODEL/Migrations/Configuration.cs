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

        //TODO: Seed Basmak i�in a�a��da yorum sat�r� i�erinde bulunan kodlar�n, Model katman� i�erisinde bulunan Migrations i�erisinede bulunan, Configuration class� i�erisine Seed metot i�erisine verilmesi gerekmektedir. Migrations sillerseniz tekrardan burdan yap��t�rabilirisiniz.

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
