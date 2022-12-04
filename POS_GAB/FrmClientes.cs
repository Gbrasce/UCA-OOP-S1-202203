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
    public partial class frmClientes : Form
    {
        DataTable _dt = new DataTable();
        private DataTable DT
        {
            get { return _dt; }
            set { _dt = value; }
        }

        public frmClientes()
        {
            InitializeComponent();

            btnAnadir.Enabled = false;

            DT.Columns.Add("id");
            DT.Columns.Add("Nombre");
            DT.Columns.Add("Apellido");
            DT.Columns.Add("Telefono");
            DT.Columns.Add("Correo");

            DT = CargarClientes(DT);

            grdClientes.DataSource = DT;
        }

        public DataTable CargarClientes(DataTable dt)
        {
            string filepath = "../../../database/clientes.json";
            StreamReader r = new StreamReader(filepath);
            //StreamReader r = new StreamReader("POS_GAB\\database\\clientes.json");
            string jsonString = r.ReadToEnd();
            //cuidado con el JsonConvert y JsonConverter
            List<ObjCliente> objClientes = JsonConvert.DeserializeObject<List<ObjCliente>>(jsonString);

            foreach (var item in objClientes)
            {
                DataRow row = dt.NewRow();

                row["Id"] = item.Id;
                row["Nombre"] = item.NombreCliente;
                row["Apellido"] = item.ApellidoCliente;
                row["Telefono"] = item.TelefonoCliente;
                row["Correo"] = item.CorreoCliente;

                dt.Rows.Add(row);
            }

            return dt;

        }

        private void btnNuevoId_Click(object sender, EventArgs e)
        {
            int UltimaFila = grdClientes.Rows.Count - 2;
            grdClientes.Rows[UltimaFila].Selected = true;
            grdClientes.CurrentCell = grdClientes.Rows[UltimaFila].Cells[0];

            grdClientes.Refresh();

            int UltimoId = Convert.ToInt32(grdClientes.Rows[UltimaFila].Cells[0].Value) + 1;
            txtId.Text = UltimoId.ToString();

            btnAnadir.Enabled = true;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            ObjCliente objCliente = new ObjCliente();
            objCliente.Id = Convert.ToInt32(txtId.Text);
            objCliente.NombreCliente = txtNombre.Text;
            objCliente.ApellidoCliente = txtApellido.Text;
            objCliente.TelefonoCliente = txtTelefono.Text;
            objCliente.CorreoCliente = txtCorreo.Text;

            DT.Rows.Add(objCliente.Id,objCliente.NombreCliente,objCliente.ApellidoCliente,objCliente.TelefonoCliente,objCliente.CorreoCliente);
        }
    }
}
