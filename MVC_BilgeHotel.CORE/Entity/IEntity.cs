﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.CORE.Entity
{
    public interface IEntity <T>
    {
        T ID { get; set; }
    }
}
