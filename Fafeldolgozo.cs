using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SZOP_mintazh_1
{
    class Fafeldolgozo
    {
        public void feldolgoz()
        {
            lock (Teherauto.puffer)
            {
                while (Teherauto.puffer.Count != 0 || Teherauto.TermeloDB != 0)
                {
                    if (Teherauto.puffer.Count == 0)
                    {
                        Console.WriteLine("Várok egy fára!");
                        Monitor.Wait(Teherauto.puffer);
                        Console.WriteLine("Már nem várok egy fára!");
                    }

                    if (Teherauto.puffer.Count != 0)
                    {
                        Console.WriteLine("Feldolgoztam ezt a fát: " + Teherauto.puffer[0].Hossz + " " + Teherauto.puffer[0].Vastagsag + " " + Teherauto.puffer[0].Suly);
                        Teherauto.puffer.RemoveAt(0);
                        Monitor.PulseAll(Teherauto.puffer);
                    }

                    if (Teherauto.puffer.Count == 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A TEHERAUTÓ MEGTERLT!");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
