using MVC_BilgeHotel.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Context
{
    public class SampleData : DropCreateDatabaseAlways<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {
            //TODO: SEED BASMAMA SORUNU
            IList<Room> rooms = new List<Room>();

            rooms.Add(new Room() { ID = Guid.NewGuid(), RoomNumber = "12", RoomStatus = Enums.RoomStatus.Full, Capacity = 12 }); 
            rooms.Add(new Room() { ID = Guid.NewGuid(), RoomNumber = "13", RoomStatus = Enums.RoomStatus.Full, Capacity = 12 }); 
            
            context.Rooms.AddRange(rooms);

            base.Seed(context);

            //
            //            SampleData data = new SampleData();
            //      data.InitializeDatabase(context);
        }
    }
}
