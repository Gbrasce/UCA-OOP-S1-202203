using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_GAB
{
    internal class ObjVentaRep
    {
        private int _id;
        private string _articuloRep;
        private decimal _precioRep;
        private int _cantidadRep;

        public int Id { get { return _id; } set { _id = value; } }
        public string ArticuloRep { get { return _articuloRep; } set { _articuloRep = value; } }
        public decimal PrecioRep { get { return _precioRep; } set { _precioRep = value; } }
        public int CantidadRep { get { return _cantidadRep; } set { _cantidadRep = value; } }
    }
}
