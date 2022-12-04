namespace POS_GAB
{
    partial class FrmUsuarios
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.GrdUsuarios = new System.Windows.Forms.DataGridView();
            this.ButtonIdUsr = new System.Windows.Forms.Button();
            this.txtIdUsr = new System.Windows.Forms.TextBox();
            this.txtNombreUsr = new System.Windows.Forms.TextBox();
            this.txtContrasenaUsr = new System.Windows.Forms.TextBox();
            this.ButtonAnadirUsr = new System.Windows.Forms.Button();
            this.labelIdUsr = new System.Windows.Forms.Label();
            this.labelNombreUsr = new System.Windows.Forms.Label();
            this.labelContraUsr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusLabel1.Text = "Control de usuarios";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // GrdUsuarios
            // 
            this.GrdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdUsuarios.Location = new System.Drawing.Point(265, 12);
            this.GrdUsuarios.Name = "GrdUsuarios";
            this.GrdUsuarios.RowTemplate.Height = 25;
            this.GrdUsuarios.Size = new System.Drawing.Size(523, 400);
            this.GrdUsuarios.TabIndex = 1;
            // 
            // ButtonIdUsr
            // 
            this.ButtonIdUsr.Location = new System.Drawing.Point(97, 14);
            this.ButtonIdUsr.Name = "ButtonIdUsr";
            this.ButtonIdUsr.Size = new System.Drawing.Size(79, 24);
            this.ButtonIdUsr.TabIndex = 2;
            this.ButtonIdUsr.Text = "Auto ID";
            this.ButtonIdUsr.UseVisualStyleBackColor = true;
            this.ButtonIdUsr.Click += new System.EventHandler(this.ButtonIdUsr_Click);
            // 
            // txtIdUsr
            // 
            this.txtIdUsr.Enabled = false;
            this.txtIdUsr.Location = new System.Drawing.Point(182, 15);
            this.txtIdUsr.Name = "txtIdUsr";
            this.txtIdUsr.PlaceholderText = "Id";
            this.txtIdUsr.Size = new System.Drawing.Size(65, 23);
            this.txtIdUsr.TabIndex = 3;
            // 
            // txtNombreUsr
            // 
            this.txtNombreUsr.Location = new System.Drawing.Point(97, 43);
            this.txtNombreUsr.Name = "txtNombreUsr";
            this.txtNombreUsr.PlaceholderText = "Nombre de usuario";
            this.txtNombreUsr.Size = new System.Drawing.Size(150, 23);
            this.txtNombreUsr.TabIndex = 4;
            // 
            // txtContrasenaUsr
            // 
            this.txtContrasenaUsr.Location = new System.Drawing.Point(97, 72);
            this.txtContrasenaUsr.Name = "txtContrasenaUsr";
            this.txtContrasenaUsr.PlaceholderText = "Contraseña";
            this.txtContrasenaUsr.Size = new System.Drawing.Size(150, 23);
            this.txtContrasenaUsr.TabIndex = 5;
            // 
            // ButtonAnadirUsr
            // 
            this.ButtonAnadirUsr.Location = new System.Drawing.Point(172, 101);
            this.ButtonAnadirUsr.Name = "ButtonAnadirUsr";
            this.ButtonAnadirUsr.Size = new System.Drawing.Size(75, 23);
            this.ButtonAnadirUsr.TabIndex = 6;
            this.ButtonAnadirUsr.Text = "Añadir";
            this.ButtonAnadirUsr.UseVisualStyleBackColor = true;
            this.ButtonAnadirUsr.Click += new System.EventHandler(this.ButtonAnadirUsr_Click);
            // 
            // labelIdUsr
            // 
            this.labelIdUsr.AutoSize = true;
            this.labelIdUsr.Location = new System.Drawing.Point(21, 19);
            this.labelIdUsr.Name = "labelIdUsr";
            this.labelIdUsr.Size = new System.Drawing.Size(17, 15);
            this.labelIdUsr.TabIndex = 7;
            this.labelIdUsr.Text = "Id";
            // 
            // labelNombreUsr
            // 
            this.labelNombreUsr.AutoSize = true;
            this.labelNombreUsr.Location = new System.Drawing.Point(21, 46);
            this.labelNombreUsr.Name = "labelNombreUsr";
            this.labelNombreUsr.Size = new System.Drawing.Size(47, 15);
            this.labelNombreUsr.TabIndex = 8;
            this.labelNombreUsr.Text = "Usuario";
            // 
            // labelContraUsr
            // 
            this.labelContraUsr.AutoSize = true;
            this.labelContraUsr.Location = new System.Drawing.Point(21, 75);
            this.labelContraUsr.Name = "labelContraUsr";
            this.labelContraUsr.Size = new System.Drawing.Size(67, 15);
            this.labelContraUsr.TabIndex = 9;
            this.labelContraUsr.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::POS_GAB.Properties.Resources.sinkopesolog;
            this.pictureBox1.Location = new System.Drawing.Point(21, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelContraUsr);
            this.Controls.Add(this.labelNombreUsr);
            this.Controls.Add(this.labelIdUsr);
            this.Controls.Add(this.ButtonAnadirUsr);
            this.Controls.Add(this.txtContrasenaUsr);
            this.Controls.Add(this.txtNombreUsr);
            this.Controls.Add(this.txtIdUsr);
            this.Controls.Add(this.ButtonIdUsr);
            this.Controls.Add(this.GrdUsuarios);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmUsuarios";
            this.Text = "Control de usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private DataGridView GrdUsuarios;
        private Button ButtonIdUsr;
        private TextBox txtIdUsr;
        private TextBox txtNombreUsr;
        private TextBox txtContrasenaUsr;
        private Button ButtonAnadirUsr;
        private Label labelIdUsr;
        private Label labelNombreUsr;
        private Label labelContraUsr;
        private PictureBox pictureBox1;
    }
}