﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ColorWheelAPI.Models
{
    public class Complementary
    {
        public int ID { get; set; }

        /// <summary>
        /// Foreign Keys
        /// </summary>
        [ForeignKey("ColorOneID")]
        public int ColorOneID { get; set; }

        [ForeignKey("ColorTwoID")]
        public int ColorTwoID { get; set; }

        /// <summary>
        /// Navigation
        /// </summary>
        public Color Color { get; set; }
    }
}
