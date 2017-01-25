namespace PPT.Formularios
{
    partial class FrmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacientes));
            this.gbPacientes = new System.Windows.Forms.GroupBox();
            this.tsControles = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAlfabetico = new System.Windows.Forms.ToolStripButton();
            this.btnReciente = new System.Windows.Forms.ToolStripButton();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.tbBusqueda = new wmgCMS.WaterMarkTextBox();
            this.tsControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPacientes
            // 
            this.gbPacientes.Location = new System.Drawing.Point(103, 43);
            this.gbPacientes.Name = "gbPacientes";
            this.gbPacientes.Size = new System.Drawing.Size(342, 328);
            this.gbPacientes.TabIndex = 0;
            this.gbPacientes.TabStop = false;
            this.gbPacientes.Text = "Pacientes";
            // 
            // tsControles
            // 
            this.tsControles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlfabetico,
            this.btnReciente,
            this.btnNuevo,
            this.toolStripSeparator1});
            this.tsControles.Location = new System.Drawing.Point(0, 0);
            this.tsControles.Name = "tsControles";
            this.tsControles.Size = new System.Drawing.Size(457, 25);
            this.tsControles.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAlfabetico
            // 
            this.btnAlfabetico.Image = ((System.Drawing.Image)(resources.GetObject("btnAlfabetico.Image")));
            this.btnAlfabetico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlfabetico.Name = "btnAlfabetico";
            this.btnAlfabetico.Size = new System.Drawing.Size(81, 22);
            this.btnAlfabetico.Text = "Alfabetico";
            // 
            // btnReciente
            // 
            this.btnReciente.Image = ((System.Drawing.Image)(resources.GetObject("btnReciente.Image")));
            this.btnReciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReciente.Name = "btnReciente";
            this.btnReciente.Size = new System.Drawing.Size(72, 22);
            this.btnReciente.Text = "Reciente";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 22);
            this.btnNuevo.Text = "Añadir paciente";
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbBusqueda.Location = new System.Drawing.Point(236, 2);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(100, 20);
            this.tbBusqueda.TabIndex = 3;
            this.tbBusqueda.WaterMarkColor = System.Drawing.Color.Gray;
            this.tbBusqueda.WaterMarkText = "Busqueda";
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 383);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.tsControles);
            this.Controls.Add(this.gbPacientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPacientes";
            this.Text = "Pacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsControles.ResumeLayout(false);
            this.tsControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPacientes;
        private System.Windows.Forms.ToolStrip tsControles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAlfabetico;
        private System.Windows.Forms.ToolStripButton btnReciente;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private wmgCMS.WaterMarkTextBox tbBusqueda;
    }
}