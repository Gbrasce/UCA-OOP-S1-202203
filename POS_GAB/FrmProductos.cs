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
    public partial class FrmProductos : Form
    {
        DataTable _dt = new DataTable();
        private DataTable DT
        {
            get { return _dt; }
            set { _dt = value; }
        }

        public FrmProductos()
        {
            InitializeComponent();

            buttonAnadirProd.Enabled = false;


            DT.Columns.Add("id");
            DT.Columns.Add("Nombre");
            DT.Columns.Add("Descripcion");
            DT.Columns.Add("Precio de venta");

            DT = CargarProductos(DT);

            grdProductos.DataSource = DT;
        }

        public DataTable CargarProductos(DataTable dt)
        {
            string filepath = "../../../database/productos.json";
            StreamReader r = new StreamReader(filepath);
            //StreamReader r = new StreamReader("POS_GAB\\database\\productos.json");
            string jsonString = r.ReadToEnd();
            //cuidado con el JsonConvert y JsonConverter
            List<ObjProducto> objProductos = JsonConvert.DeserializeObject<List<ObjProducto>>(jsonString);

            foreach (var item in objProductos)
            {
                DataRow row = dt.NewRow();

                row["Id"] = item.Id;
                row["Nombre"] = item.NombreProd;
                row["Descripcion"] = item.DescripcionProd;
                row["Precio de venta"] = item.PrecioVenta;

                dt.Rows.Add(row);
            }

            return dt;

        }

        private void buttonIdProd_Click(object sender, EventArgs e)
        {
            int UltimaFila = grdProductos.Rows.Count - 2;
            grdProductos.Rows[UltimaFila].Selected = true;
            grdProductos.CurrentCell = grdProductos.Rows[UltimaFila].Cells[0];

            grdProductos.Refresh();

            int UltimoId = Convert.ToInt32(grdProductos.Rows[UltimaFila].Cells[0].Value) + 1;
            txtIdProd.Text = UltimoId.ToString();

            buttonAnadirProd.Enabled = true;
        }

        private void buttonAnadirProd_Click(object sender, EventArgs e)
        {
            ObjProducto objProducto = new ObjProducto();
            objProducto.Id = Convert.ToInt32(txtIdProd.Text);
            objProducto.NombreProd = txtNombreProd.Text;
            objProducto.DescripcionProd = txtDescripcionProd.Text;
            objProducto.PrecioVenta = txtPrecioVentaProd.Text;

            DT.Rows.Add(objProducto.Id, objProducto.NombreProd, objProducto.DescripcionProd, objProducto.PrecioVenta);
        }
    }
}