using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDACasa
{
    public class TDACasa
    {
        TDAPared p = new TDAPared();
        TDAVentana v = new TDAVentana();
        List<TDAVentana> cantVentanas = new List<TDAVentana>();
        List<TDAPared> cantParedes = new List<TDAPared>();

        public TDACasa(int Ventanas, int Paredes)
        {
            TDAPiso piso = new TDAPiso();
            TDATecho techo = new TDATecho();

            for (int i = 0; i < Paredes; i++)
            {
                p.AddPared();
            }

            for (int i = 0; i < Ventanas; i++)
            {
                v.AddVentana();
            }
        }


    }
}
