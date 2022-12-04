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
    public partial class FrmVentasRep : Form
    {
        DataTable _dt = new DataTable();
        private DataTable DT
        {
            get { return _dt; }
            set { _dt = value; }
        }
        public FrmVentasRep()
        {
            InitializeComponent();

            buttonAnadirVentaR.Enabled = false;

            DT.Columns.Add("id");
            DT.Columns.Add("Articulo");
            DT.Columns.Add("Precio");
            DT.Columns.Add("Cantidad");

            DT = CargarVentasRep(DT);

            GrdVentasRepR.DataSource = DT;
        }

        public DataTable CargarVentasRep(DataTable dt)
        {
            string filepath = "../../../database/ventasRep.json";
            StreamReader r = new StreamReader(filepath);
            //StreamReader r = new StreamReader("POS_GAB\\database\\ventasRep.json"); //evitar conflicto de directorio
            string jsonString = r.ReadToEnd();
            //cuidado con el JsonConvert y JsonConverter
            List<ObjVentaRep> objVentasRep = JsonConvert.DeserializeObject<List<ObjVentaRep>>(jsonString);

            foreach (var item in objVentasRep)
            {
                DataRow row = dt.NewRow();

                row["Id"] = item.Id;
                row["Articulo"] = item.ArticuloRep;
                row["Precio"] = item.PrecioRep;
                row["Cantidad"] = item.CantidadRep;

                dt.Rows.Add(row);
            }

            return dt;

        }

        private void buttonAutoIdVentaR_Click(object sender, EventArgs e)
        {
            int UltimaFila = GrdVentasRepR.Rows.Count - 2;
            GrdVentasRepR.Rows[UltimaFila].Selected = true;
            GrdVentasRepR.CurrentCell = GrdVentasRepR.Rows[UltimaFila].Cells[0];

            GrdVentasRepR.Refresh();

            int UltimoId = Convert.ToInt32(GrdVentasRepR.Rows[UltimaFila].Cells[0].Value) + 1;
            txtIdVentaR.Text = UltimoId.ToString();

            buttonAnadirVentaR.Enabled = true;
        }

        private void buttonAnadirVentaR_Click(object sender, EventArgs e)
        {
            ObjVentaRep objVentaRep = new ObjVentaRep();
            objVentaRep.Id = Convert.ToInt32(txtIdVentaR.Text);
            objVentaRep.ArticuloRep = txtArticuloVentaR.Text;
            objVentaRep.PrecioRep = Convert.ToDecimal(txtPrecioVentaR.Text);
            objVentaRep.CantidadRep = Convert.ToInt32(txtCantidadVentaR.Text);

            DT.Rows.Add(
                objVentaRep.Id,
                objVentaRep.ArticuloRep,
                objVentaRep.PrecioRep,
                objVentaRep.CantidadRep);
        }
    }
}
