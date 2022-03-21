using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;
        double a, b, c = 0;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        public void setNumber(double a, double b, double c)
        {
            this.a = a;
            this.b = b; 
            this.c = c; 
        }
        public double Delta()
        {
            double delta;
            delta = this.b*this.b - 4 * this.a * this.c;
            return delta;
        }

        public double SqrtDelta()
        {
            return Math.Sqrt(Delta());
        }
    }
}
