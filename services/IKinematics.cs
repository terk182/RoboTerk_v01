using RoboTerk_v01.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTerk_v01.services
{
    public interface IKinematics
    {
        AngleModel moveToPos(double x, double y, double z);
        AngleModel startToPos(double x, double y, double z, double g);
    }
}
