using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDALeon
{
    class Program
    {
        static void Main(string[] args)
        {
            TDALeon l = new TDALeon();
            l.TDACuerpo();
            l.AddCabeza();
            l.AddCola();
            l.AddPatas();

            Console.Read();
        }
    }
}
