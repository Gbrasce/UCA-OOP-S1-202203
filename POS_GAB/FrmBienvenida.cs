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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }
        
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.MdiParent = this;
            frmProductos.MdiParent = this;
            frmProductos.Show();
        }

        private void usuariiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.MdiParent = this;
            frmEmpleados.Show();
        }

        private void ventasRepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentasRep frmVentasRep = new FrmVentasRep();
            frmVentasRep.MdiParent = this;
            frmVentasRep.Show();
        }
    }
}
