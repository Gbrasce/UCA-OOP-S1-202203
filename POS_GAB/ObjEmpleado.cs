using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_GAB
{
    internal class ObjEmpleado
    {
        private int _id;
        private string _nombreEmpleado;
        private string _apellidoEmpleado;
        private string _telefonoEmpleado;
        private string _correoEmpleado;
        private decimal _salarioEmpleado;
        private string _puestoEmpleado;
        private string _horaEntradaEmpleado;
        private string _horaSalidaEmpleado;

        public int Id { get { return _id; } set { _id = value; } }
        public string NombreEmpleado { get { return _nombreEmpleado; } set { _nombreEmpleado = value; } }
        public string ApellidoEmpleado { get { return _apellidoEmpleado; } set { _apellidoEmpleado = value; } }
        public string TelefonoEmpleado { get { return _telefonoEmpleado; } set { _telefonoEmpleado = value; } }
        public string CorreoEmpleado { get { return _correoEmpleado; } set { _correoEmpleado = value; } }
        public decimal SalarioEmpleado { get { return _salarioEmpleado; } set { _salarioEmpleado = value; } }
        public string PuestoEmpleado { get { return _puestoEmpleado; } set { _puestoEmpleado = value; } }
        public string HoraEntradaEmpleado { get { return _horaEntradaEmpleado; } set { _horaEntradaEmpleado = value; } }
        public string HoraSalidaEmpleado { get { return _horaSalidaEmpleado; } set { _horaSalidaEmpleado = value; } }
    }
}
