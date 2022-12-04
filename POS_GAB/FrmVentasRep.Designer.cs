namespace POS_GAB
{
    partial class FrmVentasRep
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
            this.GrdVentasRepR = new System.Windows.Forms.DataGridView();
            this.txtIdVentaR = new System.Windows.Forms.TextBox();
            this.txtArticuloVentaR = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaR = new System.Windows.Forms.TextBox();
            this.txtCantidadVentaR = new System.Windows.Forms.TextBox();
            this.buttonAutoIdVentaR = new System.Windows.Forms.Button();
            this.buttonAnadirVentaR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdVentasRepR)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdVentasRepR
            // 
            this.GrdVentasRepR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdVentasRepR.Location = new System.Drawing.Point(167, 0);
            this.GrdVentasRepR.Name = "GrdVentasRepR";
            this.GrdVentasRepR.RowTemplate.Height = 25;
            this.GrdVentasRepR.Size = new System.Drawing.Size(632, 449);
            this.GrdVentasRepR.TabIndex = 0;
            // 
            // txtIdVentaR
            // 
            this.txtIdVentaR.Enabled = false;
            this.txtIdVentaR.Location = new System.Drawing.Point(102, 15);
            this.txtIdVentaR.Name = "txtIdVentaR";
            this.txtIdVentaR.PlaceholderText = "Id";
            this.txtIdVentaR.Size = new System.Drawing.Size(59, 23);
            this.txtIdVentaR.TabIndex = 1;
            // 
            // txtArticuloVentaR
            // 
            this.txtArticuloVentaR.Location = new System.Drawing.Point(9, 44);
            this.txtArticuloVentaR.Name = "txtArticuloVentaR";
            this.txtArticuloVentaR.PlaceholderText = "Nombre de artículo";
            this.txtArticuloVentaR.Size = new System.Drawing.Size(152, 23);
            this.txtArticuloVentaR.TabIndex = 2;
            // 
            // txtPrecioVentaR
            // 
            this.txtPrecioVentaR.Location = new System.Drawing.Point(9, 73);
            this.txtPrecioVentaR.Name = "txtPrecioVentaR";
            this.txtPrecioVentaR.PlaceholderText = "Precio de un artículo";
            this.txtPrecioVentaR.Size = new System.Drawing.Size(152, 23);
            this.txtPrecioVentaR.TabIndex = 3;
            // 
            // txtCantidadVentaR
            // 
            this.txtCantidadVentaR.Location = new System.Drawing.Point(9, 102);
            this.txtCantidadVentaR.Name = "txtCantidadVentaR";
            this.txtCantidadVentaR.PlaceholderText = "Cantidad de artículos";
            this.txtCantidadVentaR.Size = new System.Drawing.Size(152, 23);
            this.txtCantidadVentaR.TabIndex = 4;
            // 
            // buttonAutoIdVentaR
            // 
            this.buttonAutoIdVentaR.Location = new System.Drawing.Point(9, 15);
            this.buttonAutoIdVentaR.Name = "buttonAutoIdVentaR";
            this.buttonAutoIdVentaR.Size = new System.Drawing.Size(87, 23);
            this.buttonAutoIdVentaR.TabIndex = 5;
            this.buttonAutoIdVentaR.Text = "Auto ID";
            this.buttonAutoIdVentaR.UseVisualStyleBackColor = true;
            this.buttonAutoIdVentaR.Click += new System.EventHandler(this.buttonAutoIdVentaR_Click);
            // 
            // buttonAnadirVentaR
            // 
            this.buttonAnadirVentaR.Location = new System.Drawing.Point(74, 131);
            this.buttonAnadirVentaR.Name = "buttonAnadirVentaR";
            this.buttonAnadirVentaR.Size = new System.Drawing.Size(87, 23);
            this.buttonAnadirVentaR.TabIndex = 6;
            this.buttonAnadirVentaR.Text = "Añadir";
            this.buttonAnadirVentaR.UseVisualStyleBackColor = true;
            this.buttonAnadirVentaR.Click += new System.EventHandler(this.buttonAnadirVentaR_Click);
            // 
            // FrmVentasRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnadirVentaR);
            this.Controls.Add(this.buttonAutoIdVentaR);
            this.Controls.Add(this.txtCantidadVentaR);
            this.Controls.Add(this.txtPrecioVentaR);
            this.Controls.Add(this.txtArticuloVentaR);
            this.Controls.Add(this.txtIdVentaR);
            this.Controls.Add(this.GrdVentasRepR);
            this.Name = "FrmVentasRep";
            this.Text = "FrmVentasRep";
            ((System.ComponentModel.ISupportInitialize)(this.GrdVentasRepR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GrdVentasRepR;
        private TextBox txtIdVentaR;
        private TextBox txtArticuloVentaR;
        private TextBox txtPrecioVentaR;
        private TextBox txtCantidadVentaR;
        private Button buttonAutoIdVentaR;
        private Button buttonAnadirVentaR;
    }
}