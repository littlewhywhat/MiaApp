﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIA_Main
{
    class Device
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public Device();
        public Device(int id)
        {
            Id = id;
        }
        
    }
}
