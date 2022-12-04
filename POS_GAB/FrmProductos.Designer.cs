namespace POS_GAB
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtDescripcionProd = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaProd = new System.Windows.Forms.TextBox();
            this.buttonIdProd = new System.Windows.Forms.Button();
            this.buttonAnadirProd = new System.Windows.Forms.Button();
            this.labelIdProd = new System.Windows.Forms.Label();
            this.labelNombreProd = new System.Windows.Forms.Label();
            this.labelDescripcionProd = new System.Windows.Forms.Label();
            this.labelPrecioVentaProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProductos
            // 
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Location = new System.Drawing.Point(253, 40);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.RowTemplate.Height = 25;
            this.grdProductos.Size = new System.Drawing.Size(560, 370);
            this.grdProductos.TabIndex = 0;
            // 
            // txtIdProd
            // 
            this.txtIdProd.AccessibleDescription = "Id Producto";
            this.txtIdProd.AccessibleName = "Id";
            this.txtIdProd.Enabled = false;
            this.txtIdProd.Location = new System.Drawing.Point(117, 41);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.PlaceholderText = "Id";
            this.txtIdProd.Size = new System.Drawing.Size(50, 23);
            this.txtIdProd.TabIndex = 1;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(117, 70);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.PlaceholderText = "Nombre de producto";
            this.txtNombreProd.Size = new System.Drawing.Size(120, 23);
            this.txtNombreProd.TabIndex = 2;
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Location = new System.Drawing.Point(117, 99);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.PlaceholderText = "Descripción breve";
            this.txtDescripcionProd.Size = new System.Drawing.Size(120, 23);
            this.txtDescripcionProd.TabIndex = 3;
            // 
            // txtPrecioVentaProd
            // 
            this.txtPrecioVentaProd.Location = new System.Drawing.Point(117, 128);
            this.txtPrecioVentaProd.Name = "txtPrecioVentaProd";
            this.txtPrecioVentaProd.PlaceholderText = "Precio de venta";
            this.txtPrecioVentaProd.Size = new System.Drawing.Size(120, 23);
            this.txtPrecioVentaProd.TabIndex = 4;
            this.txtPrecioVentaProd.Tag = "";
            // 
            // buttonIdProd
            // 
            this.buttonIdProd.Location = new System.Drawing.Point(173, 40);
            this.buttonIdProd.Name = "buttonIdProd";
            this.buttonIdProd.Size = new System.Drawing.Size(64, 24);
            this.buttonIdProd.TabIndex = 5;
            this.buttonIdProd.Text = "Auto ID";
            this.buttonIdProd.UseVisualStyleBackColor = true;
            this.buttonIdProd.Click += new System.EventHandler(this.buttonIdProd_Click);
            // 
            // buttonAnadirProd
            // 
            this.buttonAnadirProd.Location = new System.Drawing.Point(162, 157);
            this.buttonAnadirProd.Name = "buttonAnadirProd";
            this.buttonAnadirProd.Size = new System.Drawing.Size(75, 23);
            this.buttonAnadirProd.TabIndex = 6;
            this.buttonAnadirProd.Text = "Añadir";
            this.buttonAnadirProd.UseVisualStyleBackColor = true;
            this.buttonAnadirProd.Click += new System.EventHandler(this.buttonAnadirProd_Click);
            // 
            // labelIdProd
            // 
            this.labelIdProd.AutoSize = true;
            this.labelIdProd.Location = new System.Drawing.Point(38, 44);
            this.labelIdProd.Name = "labelIdProd";
            this.labelIdProd.Size = new System.Drawing.Size(17, 15);
            this.labelIdProd.TabIndex = 7;
            this.labelIdProd.Text = "Id";
            // 
            // labelNombreProd
            // 
            this.labelNombreProd.AutoSize = true;
            this.labelNombreProd.Location = new System.Drawing.Point(38, 73);
            this.labelNombreProd.Name = "labelNombreProd";
            this.labelNombreProd.Size = new System.Drawing.Size(51, 15);
            this.labelNombreProd.TabIndex = 8;
            this.labelNombreProd.Text = "Nombre";
            // 
            // labelDescripcionProd
            // 
            this.labelDescripcionProd.AutoSize = true;
            this.labelDescripcionProd.Location = new System.Drawing.Point(38, 102);
            this.labelDescripcionProd.Name = "labelDescripcionProd";
            this.labelDescripcionProd.Size = new System.Drawing.Size(69, 15);
            this.labelDescripcionProd.TabIndex = 9;
            this.labelDescripcionProd.Text = "Descripción";
            // 
            // labelPrecioVentaProd
            // 
            this.labelPrecioVentaProd.AutoSize = true;
            this.labelPrecioVentaProd.Location = new System.Drawing.Point(38, 131);
            this.labelPrecioVentaProd.Name = "labelPrecioVentaProd";
            this.labelPrecioVentaProd.Size = new System.Drawing.Size(40, 15);
            this.labelPrecioVentaProd.TabIndex = 10;
            this.labelPrecioVentaProd.Text = "Precio";
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.labelPrecioVentaProd);
            this.Controls.Add(this.labelDescripcionProd);
            this.Controls.Add(this.labelNombreProd);
            this.Controls.Add(this.labelIdProd);
            this.Controls.Add(this.buttonAnadirProd);
            this.Controls.Add(this.buttonIdProd);
            this.Controls.Add(this.txtPrecioVentaProd);
            this.Controls.Add(this.txtDescripcionProd);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.grdProductos);
            this.Name = "FrmProductos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdProductos;
        private TextBox txtIdProd;
        private TextBox txtNombreProd;
        private TextBox txtDescripcionProd;
        private TextBox txtPrecioVentaProd;
        private Button buttonIdProd;
        private Button buttonAnadirProd;
        private Label labelIdProd;
        private Label labelNombreProd;
        private Label labelDescripcionProd;
        private Label labelPrecioVentaProd;
    }
}