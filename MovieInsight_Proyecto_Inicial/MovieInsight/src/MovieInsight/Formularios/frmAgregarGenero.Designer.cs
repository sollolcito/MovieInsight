namespace MovieInsight.Formularios
{
    partial class frmAgregarGenero
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Location = new System.Drawing.Point(35, 112);
            this.lblCodigo.Size = new System.Drawing.Size(210, 25);
            this.lblCodigo.Text = "Código";
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Location = new System.Drawing.Point(35, 141);
            this.txtCodigo.Size = new System.Drawing.Size(230, 32);
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(232, 239, 248);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Location = new System.Drawing.Point(290, 112);
            this.lblNombre.Size = new System.Drawing.Size(250, 25);
            this.lblNombre.Text = "Nombre";
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Location = new System.Drawing.Point(290, 141);
            this.txtNombre.Size = new System.Drawing.Size(340, 32);
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(232, 239, 248);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Location = new System.Drawing.Point(35, 198);
            this.lblDescripcion.Size = new System.Drawing.Size(220, 25);
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Location = new System.Drawing.Point(35, 230);
            this.txtDescripcion.Size = new System.Drawing.Size(595, 85);
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(232, 239, 248);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescripcion.Multiline = true;
            this.cmdCargar = new System.Windows.Forms.Button();
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Location = new System.Drawing.Point(465, 348);
            this.cmdCargar.Size = new System.Drawing.Size(165, 44);
            this.cmdCargar.Text = "Cargar género";
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
            this.lblTitulo.Text = "Agregar nuevo género...";
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(32, 57);
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(196, 214, 232);
            this.lblSubtitulo.Text = "MOVIEINSIGHT  |  IES21 - LABORATORIO DE PROGRAMACIÓN 1";
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.pnlEncabezado);
            this.ClientSize = new System.Drawing.Size(720, 465);
            this.BackColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmAgregarGenero";
            this.Text = "Agregar nuevo género...";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button cmdCargar;
    }
}
