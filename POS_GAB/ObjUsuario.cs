using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_GAB
{
    internal class ObjUsuario
    {
        private int _id;
        private string _usuario;
        private string _contrasena;

        public int Id 
        { 
            get { return _id; } 
            set { _id = value; }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }
    }
}
