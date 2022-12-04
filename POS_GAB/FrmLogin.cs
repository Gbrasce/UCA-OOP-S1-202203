using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GAB
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAcceso_Click(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader("C:\\Users\\Gradv Heizd\\source\\repos\\POS_GAB\\database\\usuarios.json");
            string jsonString = r.ReadToEnd();
            //cuidado con el JsonConvert y JsonConverter
            List<ObjUsuario> objUsuarios = JsonConvert.DeserializeObject<List<ObjUsuario>>(jsonString);

            DataTable dtUsuarios = new DataTable();
            //defines las columnas del datatable
            dtUsuarios.Columns.Add("id");
            dtUsuarios.Columns.Add("Usuario");
            dtUsuarios.Columns.Add("Contrasena");

            foreach (var item in objUsuarios)
            {
                DataRow row = dtUsuarios.NewRow();

                row["Id"] = item.Id;
                row["Usuario"] = item.Usuario;
                row["Contrasena"] = item.Contrasena;

                dtUsuarios.Rows.Add(row);
            }

            bool Valido = false;
            foreach (DataRow row in dtUsuarios.Rows)
            {
                if (txtUsuario.Text == row["Usuario"].ToString() && txtContraseña.Text == row["Contrasena"].ToString()){
                    Valido = true;
                    break;
                }
            }

            if (Valido)
            {
                frmBienvenida frmBienvenida = new frmBienvenida();
                frmBienvenida.Show();
                this.Hide();
            }
            else
            {
                FrmCredencialesError CredencialesError = new FrmCredencialesError();
                CredencialesError.Show();
            }
        }
    }
}