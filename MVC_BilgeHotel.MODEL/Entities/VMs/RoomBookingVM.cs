using MVC_BilgeHotel.MODEL.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_BilgeHotel.MODEL.Entities.VMs
{
    public class RoomBookingVM
    {
        public Guid ID { get; set; }
        public string RoomNumber { get; set; }

        public int Capacity { get; set; }

        public RoomStatus RoomStatus { get; set; }

        public string ImagePath { get; set; }

        public RoomTypes RoomTypes { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime InDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OutDate { get; set; }

        public int CostomerCount { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal ExtraPrice { get; set; }


        public decimal TotalPrice { get; set; }

        public int TotalDays { get; set; }

        public BookingPackages Package { get; set; }


        public string Description { get; set; }


        public bool Paid { get; set; }


        public bool Entry { get; set; }

        public Guid RoomID { get; set; }
    }
}