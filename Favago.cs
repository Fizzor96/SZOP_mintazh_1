using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SZOP_mintazh_1
{
    class Favago
    {
        private int felsoertek;

        public Favago(int felsoert)
        {
            this.felsoertek = felsoert;
        }

        public void Termel()
        {
            lock (typeof(Teherauto))
            {
                Teherauto.TermeloDB++;
                Console.WriteLine("Elindult egy termelő, a termelők darabszáma: " + Teherauto.TermeloDB);
            }

            for (int i = 0; i < felsoertek; i++)
            {
                lock (Teherauto.puffer)
                {
                    while (Teherauto.puffer.Count < 101)
                    {
                        Fa fa = new Fa();
                        Teherauto.puffer.Add(fa);
                        Console.WriteLine("Beraktam ezt a fát a teherautóba!: " + fa.Hossz + " " + fa.Vastagsag + " " + fa.Suly);
                        Monitor.PulseAll(Teherauto.puffer);
                    }
                }
            }

            lock (typeof(Teherauto))
            {
                Teherauto.FavagoCsokkent();
            }
        }
    }
}
