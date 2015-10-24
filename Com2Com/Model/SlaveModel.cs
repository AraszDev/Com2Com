﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com2Com.Model
{
    class SlaveModel
    {
        public List<bool> DigitalValues { get; set; } = new List<bool>();

        public int AnalogValue { get; set; } = 0;

        public int SlaveID { get; set; } = 255;

    }
}
