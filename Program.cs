using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SZOP_mintazh_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Favago f1 = new Favago(65);
            Favago f2 = new Favago(90);

            Fafeldolgozo fd1 = new Fafeldolgozo();
            Fafeldolgozo fd2 = new Fafeldolgozo();
            Fafeldolgozo fd3 = new Fafeldolgozo();

            Thread tf1 = new Thread(f1.Termel);
            Thread tf2 = new Thread(f2.Termel);

            Thread tfd1 = new Thread(fd1.feldolgoz);
            Thread tfd2 = new Thread(fd2.feldolgoz);
            Thread tfd3 = new Thread(fd3.feldolgoz);

            tf1.Start();
            tf2.Start();
            tfd1.Start();
            tfd2.Start();
            tfd3.Start();

            tf1.Join();
            tf2.Join();
            tfd1.Join();
            tfd2.Join();
            tfd3.Join();


            Console.WriteLine("A listaelem száma: " + Teherauto.puffer.Count);

            Console.ReadKey();
        }
    }
}
