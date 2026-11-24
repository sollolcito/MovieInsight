namespace MovieInsight.Formularios
{
    partial class frmRegistrarVisualizacion
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
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Location = new System.Drawing.Point(35, 120);
            this.lblGenero.Size = new System.Drawing.Size(210, 25);
            this.lblGenero.Text = "Género";
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Location = new System.Drawing.Point(35, 152);
            this.cmbGenero.Size = new System.Drawing.Size(305, 34);
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(232, 239, 248);
            this.cmbGenero.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.cmbGenero.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblMes = new System.Windows.Forms.Label();
            this.lblMes.Name = "lblMes";
            this.lblMes.Location = new System.Drawing.Point(365, 120);
            this.lblMes.Size = new System.Drawing.Size(180, 25);
            this.lblMes.Text = "Mes";
            this.lblMes.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblMes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Location = new System.Drawing.Point(365, 152);
            this.cmbMes.Size = new System.Drawing.Size(300, 34);
            this.cmbMes.BackColor = System.Drawing.Color.FromArgb(232, 239, 248);
            this.cmbMes.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.cmbMes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Location = new System.Drawing.Point(35, 221);
            this.lblCantidad.Size = new System.Drawing.Size(440, 25);
            this.lblCantidad.Text = "Cantidad de visualizaciones";
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Location = new System.Drawing.Point(35, 254);
            this.txtCantidad.Size = new System.Drawing.Size(300, 35);
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(232, 239, 248);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmdCargar = new System.Windows.Forms.Button();
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Location = new System.Drawing.Point(500, 249);
            this.cmdCargar.Size = new System.Drawing.Size(165, 44);
            this.cmdCargar.Text = "Registrar";
            this.cmdCargar.BackColor = System.Drawing.Color.FromArgb(244, 198, 93);
            this.cmdCargar.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.cmdCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCargar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.cmdCargar.UseVisualStyleBackColor = false;
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Height = 88;
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(16, 43, 69);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(30, 16);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(244, 198, 93);
            this.lblTitulo.Text = "Registrar visualización...";
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(32, 57);
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(196, 214, 232);
            this.lblSubtitulo.Text = "MOVIEINSIGHT  |  IES21 - LABORATORIO DE PROGRAMACIÓN 1";
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.pnlEncabezado);
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.BackColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmRegistrarVisualizacion";
            this.Text = "Registrar visualización...";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button cmdCargar;
    }
}
