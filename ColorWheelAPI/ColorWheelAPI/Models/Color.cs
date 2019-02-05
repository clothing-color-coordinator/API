﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorWheelAPI.Models
{
    public class Color
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Properties
        /// </summary>
        public string ColorName { get; set; }
        public string HexCode { get; set; }

        public Color (int id)
        {
            ID = id;
        }
    }
}
