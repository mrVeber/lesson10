using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class RadianCalc
    {
        int gradus;
        int min;
        int sec; 
       public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                    gradus = value % 360;   
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                min = value % 60;
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                Min += value / 60;
                sec = value % 60;
            }
        }
        public RadianCalc(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        public double ToRadiant()
        {
            return (double)(gradus * Math.PI / 180) + (min * Math.PI / 60 * 180) + (sec * Math.PI / 180 * 3600);

        }
    }
}
