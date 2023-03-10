using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ActivSumasHilos
{
    internal class Suma
    {
        public int terminado = 0;
        public void SumasSecuenciales()
        {
            int res;
            Random r = new Random();
            for(int i=0; i< int.MaxValue;i++)
            {
                res = r.Next() + r.Next();
            }
        }

        public void SumasConcurrentes()
        {
            Thread t1 = new Thread(HiloSumas);
            Thread t2 = new Thread(HiloSumas);

            t1.Start();
            t2.Start();
        }

        public void HiloSumas()
        {
            int res;
            Random r = new Random();

            int total = int.MaxValue / 2;

            for (int i = 0; i < total ; i++)
                res = r.Next() + r.Next();

            terminado++;
        }
    }
}
