namespace MovieInsight.Formularios
{
    partial class frmConsultaGenero
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblElegir = new System.Windows.Forms.Label();
            this.lblElegir.Name = "lblElegir";
            this.lblElegir.Location = new System.Drawing.Point(35, 120);
            this.lblElegir.Size = new System.Drawing.Size(260, 26);
            this.lblElegir.Text = "Seleccionar género";
            this.lblElegir.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblElegir.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Location = new System.Drawing.Point(35, 153);
            this.cmbGenero.Size = new System.Drawing.Size(480, 34);
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(232, 239, 248);
            this.cmbGenero.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.cmbGenero.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Location = new System.Drawing.Point(550, 147);
            this.cmdConsultar.Size = new System.Drawing.Size(165, 43);
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.BackColor = System.Drawing.Color.FromArgb(244, 198, 93);
            this.cmdConsultar.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.cmdConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.cmdConsultar.UseVisualStyleBackColor = false;
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Location = new System.Drawing.Point(35, 228);
            this.lblCodigo.Size = new System.Drawing.Size(640, 35);
            this.lblCodigo.Text = "Código: -";
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Location = new System.Drawing.Point(35, 287);
            this.lblDescripcion.Size = new System.Drawing.Size(695, 120);
            this.lblDescripcion.Text = "Descripción: -";
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Height = 88;
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(16, 43, 69);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(30, 16);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(244, 198, 93);
            this.lblTitulo.Text = "Consulta de datos de un género...";
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(32, 57);
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(196, 214, 232);
            this.lblSubtitulo.Text = "MOVIEINSIGHT  |  IES21 - LABORATORIO DE PROGRAMACIÓN 1";
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblElegir);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.pnlEncabezado);
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.BackColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmConsultaGenero";
            this.Text = "Consulta de datos de un género...";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblElegir;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
    }
}
