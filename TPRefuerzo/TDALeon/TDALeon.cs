using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDALeon
{
    class TDALeon
    {
        private int tdaCuerpo;
        private int tdaPatas;
        private int tdaCabeza;
        private int tdaCola;

        public void TDACuerpo()
        {            
        }

        public int AddPatas()
        {
            tdaPatas += 1;
            return tdaPatas;
        }

        public int AddCola()
        {
            tdaCola += 1;
            return tdaCola;
        }

        public int AddCabeza()
        {
            tdaCabeza += 1;
            return tdaCabeza;
        }
        
        

    }
}
