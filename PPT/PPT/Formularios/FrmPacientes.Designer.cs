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
            this.gbPacientes = new System.Windows.Forms.GroupBox();
            this.tsControles = new System.Windows.Forms.ToolStrip();
            this.lbTodos = new System.Windows.Forms.ToolStripLabel();
            this.lbRecientes = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
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
            this.tsControles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbTodos,
            this.lbRecientes,
            this.toolStripSeparator1,
            this.tbBuscar,
            this.toolStripLabel4});
            this.tsControles.Location = new System.Drawing.Point(0, 0);
            this.tsControles.Name = "tsControles";
            this.tsControles.Size = new System.Drawing.Size(457, 25);
            this.tsControles.TabIndex = 2;
            // 
            // lbTodos
            // 
            this.lbTodos.Name = "lbTodos";
            this.lbTodos.Size = new System.Drawing.Size(39, 22);
            this.lbTodos.Text = "Todos";
            this.lbTodos.Click += new System.EventHandler(this.lbTodos_Click);
            // 
            // lbRecientes
            // 
            this.lbRecientes.Name = "lbRecientes";
            this.lbRecientes.Size = new System.Drawing.Size(57, 22);
            this.lbRecientes.Text = "Recientes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(97, 22);
            this.toolStripLabel4.Text = "Agregar Paciente";
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 383);
            this.Controls.Add(this.tsControles);
            this.Controls.Add(this.gbPacientes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPacientes";
            this.Text = "FrmPacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsControles.ResumeLayout(false);
            this.tsControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPacientes;
        private System.Windows.Forms.ToolStrip tsControles;
        private System.Windows.Forms.ToolStripLabel lbTodos;
        private System.Windows.Forms.ToolStripLabel lbRecientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tbBuscar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
    }
}