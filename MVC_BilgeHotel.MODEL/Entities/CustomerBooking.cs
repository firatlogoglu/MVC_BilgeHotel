﻿using MVC_BilgeHotel.CORE.Entity;
using System;

namespace MVC_BilgeHotel.MODEL.Entities
{
    public class CustomerBooking : CoreEntity
    {
        public Guid BookingID { get; set; }
        public Guid CustomerID { get; set; }

        public Booking Booking { get; set; }
        public Customer Customer { get; set; }
    }
}