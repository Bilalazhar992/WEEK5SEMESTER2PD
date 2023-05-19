using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdweek5lab
{
    public class Angle
    {
        public int degrees;
        public float minutes;
        public string direction;
        public Angle(int degree1,float minute1,string direction1)
        {
            degrees = degree1;
            minutes = minute1;
            direction = direction1;
        }
    }
}
