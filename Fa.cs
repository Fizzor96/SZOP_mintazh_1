using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZOP_mintazh_1
{
    class Fa
    {
        static Random rnd = new Random();

        private int hossz;

        public int Hossz
        {
            get { return hossz; }
            set { hossz = value; }
        }

        private int vastagsag;

        public int Vastagsag
        {
            get { return vastagsag; }
            set { vastagsag = value; }
        }

        private double suly;

        public double Suly
        {
            get { return suly; }
            set { suly = value; }
        }

        public Fa()
        {
            this.hossz = rnd.Next(30,141);
            this.vastagsag = rnd.Next(20,61);
            this.suly = (0.5 + rnd.NextDouble() + rnd.Next(0, 4)) + (rnd.NextDouble()/2);
        }
    }
}
