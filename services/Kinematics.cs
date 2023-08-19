using RoboTerk_v01.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTerk_v01.services
{
    public class Kinematics : IKinematics
    {
        public double link1 { get; set; }
        public double link2 { get; set; }

        public double base_stant { get; set; }
        public double endeffec { get; set; }
        public double buffer_base { get; set; }

        public double buffer_x { get; set; }
        public double work_space_lan { get; set; }
        public double link2_and_ee { get; set; }

        public Kinematics(double _link1, double _link2, double _base_stant, double _endeffec, double _buffer_base, double _work_space_lan, double _buffer_x)
        {
            link1 = _link1;
            link2 = _link2;  //Math.Sqrt((_link2 * _link2) + (_endeffec * _endeffec));
            base_stant = _base_stant;
            endeffec = _endeffec;
            buffer_base = _buffer_base;
            work_space_lan = _work_space_lan;
            buffer_x = _buffer_x;
            link2_and_ee = Math.Sqrt((link2 * link2) + (endeffec * endeffec));
        }

        public AngleModel moveToPos(double x, double y, double z)
        {


            var _x = x;
            var _y = y;
            var _b = base_stant - z;

            //----------มุม ฐาน --------------------------------

            var _d = work_space_lan / 2;


            var r = Math.Sqrt((_x * _x) + (Math.Abs(_y - _d) * Math.Abs(_y - _d)));
            //  var _theta_base = Math.Acos(_x/r) * 180/Math.PI;
            var _theta_base = Math.Atan2((_y - _d), _x) * 180 / Math.PI;
            //----------มุม 1 --------------------------------
            r = Math.Abs(r - endeffec);
            var _theta = Math.Atan2(r, _b) * 180 / Math.PI;
            var _g = Math.Sqrt((r * r) + (_b * _b));
            var _affa = Math.Acos(((link1 * link1) + (_g * _g) - (link2 * link2)) / (2 * link1 * _g)) * 180 / Math.PI;
            var bata = _affa + _theta;

            //-----------มุม 2 ---------------------------------


            var free = Math.Acos(((link1 * link1) + (link2 * link2) - (_g * _g)) / (2 * link1 * link2)) * 180 / Math.PI;


            var result = new AngleModel();
            result.r = r;
            result.x = x;
            result.y = y;
            result.z = z;
            result.baseAngle = _theta_base;
            //result.theta1 = bata;
            //result.theta2 =  free ;
            result.theta1 = bata;
            result.theta2 = (180 - free - _affa) + (180 - 90 - _theta);
            return result;
        }

        public AngleModel startToPos(double x, double y, double z, double g)
        {
            var r = Math.Sqrt((x * x) + (y * y));
            var theta_y = Math.Atan(x / r);
            var theta = Math.Atan2(y, base_stant) * (180 / Math.PI);
            var g_l = Math.Sqrt(y * y + base_stant * base_stant);
            var affa = Math.Acos(((link1 * link1) + (g_l * g_l) - (link2 * link2)) / (2 * link1 * g_l)) * (180 / Math.PI);
            var bata = theta + affa; ;
            var xx = ((link1 * link1) + (link2 * link2) - (g_l * g_l));
            var yy = (2 * link1 * link2);
            var free = (Math.Acos(xx / yy) * (180 / Math.PI)) - 180;

            var result = new AngleModel();
            result.x = bata;
            result.y = theta_y;
            result.z = free;

            return result;
        }
    }
}
