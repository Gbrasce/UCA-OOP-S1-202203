using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_GAB
{
    internal class ObjProducto
    {
        private int _id;
        private string _nombreProd;
        private string _descripcionProd;
        private string _precioVenta;

        public int Id
        { 
            get { return _id; }
            set { _id = value; }
        }

        public string NombreProd
        {
            get { return _nombreProd; }
            set { _nombreProd = value; }
        }

        public string DescripcionProd
        {
            get { return _descripcionProd; }
            set { _descripcionProd = value; }
        }

        public string PrecioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }
    }
}
