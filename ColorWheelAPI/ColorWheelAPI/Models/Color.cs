using System;
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

        /// <summary>
        /// Navigation Properties
        /// </summary>
        //public Analogous Analogous { get; set; }
        //public Complimentary Complimentary { get; set; }
        //public Monochromatic Monochromatic { get; set; }
        //public SplitComplimentary SplitComplimentary { get; set; }
        //public Tetradic Tetradic { get; set; }
        //public Triadic Triadic { get; set; }
    }
}
