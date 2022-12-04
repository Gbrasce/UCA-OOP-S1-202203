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
    public partial class FrmUsuarios : Form
    {
        DataTable _dt = new DataTable();
        private DataTable DT
        {
            get { return _dt; }
            set { _dt = value; }
        }

        public FrmUsuarios()
        {
            InitializeComponent();
            ButtonAnadirUsr.Enabled = false;

            DT.Columns.Add("id");
            DT.Columns.Add("Usuario");
            DT.Columns.Add("Contrasena");

            DT = CargarUsuarios(DT);


            GrdUsuarios.DataSource = DT;
        }

        public DataTable CargarUsuarios(DataTable dt)
        {
            string filepath = "../../../database/usuarios.json";
            StreamReader r = new StreamReader(filepath);
            //StreamReader r = new StreamReader("POS_GAB\\database\\usuarios.json");
            string jsonString = r.ReadToEnd();
            //cuidado con el JsonConvert y JsonConverter
            List<ObjUsuario> objUsuarios = JsonConvert.DeserializeObject<List<ObjUsuario>>(jsonString);

            foreach (var item in objUsuarios)
            {
                DataRow row = dt.NewRow();

                row["Id"] = item.Id;
                row["Usuario"] = item.Usuario;
                row["Contrasena"] = item.Contrasena;

                dt.Rows.Add(row);
            }

            return dt;

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonIdUsr_Click(object sender, EventArgs e)
        {
            int UltimaFila = GrdUsuarios.Rows.Count - 2;
            GrdUsuarios.Rows[UltimaFila].Selected = true;
            GrdUsuarios.CurrentCell = GrdUsuarios.Rows[UltimaFila].Cells[0];

            GrdUsuarios.Refresh();

            int UltimoId = Convert.ToInt32(GrdUsuarios.Rows[UltimaFila].Cells[0].Value) + 1;
            txtIdUsr.Text = UltimoId.ToString();

            ButtonAnadirUsr.Enabled = true;
        }

        private void ButtonAnadirUsr_Click(object sender, EventArgs e)
        {
            ObjUsuario objUsuario = new ObjUsuario();
            objUsuario.Id = Convert.ToInt32(txtIdUsr.Text);
            objUsuario.Usuario = txtNombreUsr.Text;
            objUsuario.Contrasena = txtContrasenaUsr.Text;

            DT.Rows.Add(objUsuario.Id, objUsuario.Usuario, objUsuario.Contrasena);
        }
    }
}
