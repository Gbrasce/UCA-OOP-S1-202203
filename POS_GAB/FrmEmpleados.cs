using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GAB
{
    public partial class FrmEmpleados : Form
    {
        DataTable _dt = new DataTable();
        private DataTable DT
        {
            get { return _dt; }
            set { _dt = value; }
        }

        public FrmEmpleados()
        {
            InitializeComponent();
            buttonAnadirEmpleado.Enabled = false;

            DT.Columns.Add("id");
            DT.Columns.Add("Nombre");
            DT.Columns.Add("Apellido");
            DT.Columns.Add("Telefono");
            DT.Columns.Add("Correo");
            DT.Columns.Add("Salario");
            DT.Columns.Add("Puesto");
            DT.Columns.Add("Entrada");
            DT.Columns.Add("Salida");

            DT = CargarEmpleados(DT);

            GrdEmpleados.DataSource = DT;
        }

        private void buttonIdEmpleado_Click(object sender, EventArgs e)
        {
            int UltimaFila = GrdEmpleados.Rows.Count - 2;
            GrdEmpleados.Rows[UltimaFila].Selected = true;
            GrdEmpleados.CurrentCell = GrdEmpleados.Rows[UltimaFila].Cells[0];

            GrdEmpleados.Refresh();

            int UltimoId = Convert.ToInt32(GrdEmpleados.Rows[UltimaFila].Cells[0].Value) + 1;
            txtIdEmpleado.Text = UltimoId.ToString();

            buttonAnadirEmpleado.Enabled = true;
        }

        public DataTable CargarEmpleados(DataTable dt)
        {
            string filepath = "../../../database/empleados.json";
            StreamReader r = new StreamReader(filepath);
            //StreamReader r = new StreamReader("POS_GAB\\database\\empleados.json");
            string jsonString = r.ReadToEnd();
            //cuidado con el JsonConvert y JsonConverter
            List<ObjEmpleado> objEmpleados = JsonConvert.DeserializeObject<List<ObjEmpleado>>(jsonString);

            foreach (var item in objEmpleados)
            {
                DataRow row = dt.NewRow();

                row["Id"] = item.Id;
                row["Nombre"] = item.NombreEmpleado;
                row["Apellido"] = item.ApellidoEmpleado;
                row["Telefono"] = item.TelefonoEmpleado;
                row["Correo"] = item.CorreoEmpleado;
                row["Salario"] = item.SalarioEmpleado;
                row["Puesto"] = item.PuestoEmpleado;
                row["Entrada"] = item.HoraEntradaEmpleado;
                row["Salida"] = item.HoraSalidaEmpleado;

                dt.Rows.Add(row);
            }

            return dt;

        }

        private void buttonAnadirEmpleado_Click(object sender, EventArgs e)
        {
            ObjEmpleado objEmpleado = new ObjEmpleado();
            objEmpleado.Id = Convert.ToInt32(txtIdEmpleado.Text);
            objEmpleado.NombreEmpleado = txtNombreEmpleado.Text;
            objEmpleado.ApellidoEmpleado = txtApellidoEmpleado.Text;
            objEmpleado.TelefonoEmpleado = txtTelefonoEmpleado.Text;
            objEmpleado.CorreoEmpleado = txtCorreoEmpleado.Text;
            objEmpleado.SalarioEmpleado = Convert.ToDecimal(txtSalarioEmpleadoR.Text);
            objEmpleado.PuestoEmpleado = txtPuestoEmpleado.Text;
            objEmpleado.HoraEntradaEmpleado = txtHoraEntradaEmpleado.Text;

            DT.Rows.Add(
                objEmpleado.Id, 
                objEmpleado.NombreEmpleado, 
                objEmpleado.ApellidoEmpleado, 
                objEmpleado.TelefonoEmpleado,
                objEmpleado.CorreoEmpleado,
                objEmpleado.SalarioEmpleado,
                objEmpleado.PuestoEmpleado,
                objEmpleado.HoraEntradaEmpleado,
                objEmpleado.HoraSalidaEmpleado
            );
        }
    }
}
