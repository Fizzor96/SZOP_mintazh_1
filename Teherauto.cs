using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SZOP_mintazh_1
{
    class Teherauto
    {
        public static List<Fa> puffer = new List<Fa>();
        public static int TermeloDB = 0;

        public static void FavagoCsokkent()
        {
            lock (typeof(Teherauto))
            {
                TermeloDB--;
                Console.WriteLine("Egy favágó leállt!");
                if (TermeloDB == 0)
                {
                    lock (puffer)
                    {
                        Monitor.PulseAll(puffer);
                        Console.WriteLine("Minden favágó leállt!");
                    }
                }
            }
        }


    }
}
