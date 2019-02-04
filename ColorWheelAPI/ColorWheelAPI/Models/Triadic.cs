using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ColorWheelAPI.Models
{
    public class Triadic
    {
        public int ID { get; set; }

        /// <summary>
        /// Foreign Keys
        /// </summary>
        [ForeignKey("ColorOneID")]
        public int ColorOneID { get; set; }

        [ForeignKey("ColorTwoID")]
        public int ColorTwoID { get; set; }

        [ForeignKey("ColorThreeID")]
        public int ColorThreeID { get; set; }
      

        //Navigation
        public Colors Color { get; set; }
    }
}
