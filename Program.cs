using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivSumasHilos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Suma s = new Suma();

            DateTime inicio = DateTime.Now;

            //s.SumasSecuenciales();
            s.SumasConcurrentes();
            while (s.terminado < 2) { }
                
           

            DateTime fin = DateTime.Now;

            TimeSpan diff = fin -inicio;

            Console.WriteLine(diff.TotalMilliseconds);

            Console.ReadKey();  
        }
    }
}
