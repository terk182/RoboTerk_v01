using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTerk_v01.models
{
    public class Gcode
    {
        public string gcode_cmd {get;set;}
        public bool ik { get; set; }
    }

    public class position_rec
    {


        public int x_start { get; set; }
        public int y_start { get; set; }
        public int x_end { get; set; }
        public int y_end { get; set; }

        public int x2_start { get; set; }
        public int y2_start { get; set; }

    }
}
