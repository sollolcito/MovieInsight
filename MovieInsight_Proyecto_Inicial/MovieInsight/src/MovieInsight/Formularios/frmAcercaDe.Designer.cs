namespace MovieInsight.Formularios
{
    partial class frmAcercaDe
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
            this.lblInstituto = new System.Windows.Forms.Label();
            this.lblInstituto.Name = "lblInstituto";
            this.lblInstituto.Location = new System.Drawing.Point(35, 115);
            this.lblInstituto.Size = new System.Drawing.Size(400, 28);
            this.lblInstituto.Text = "IES 21";
            this.lblInstituto.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblInstituto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Location = new System.Drawing.Point(35, 150);
            this.lblCarrera.Size = new System.Drawing.Size(500, 30);
            this.lblCarrera.Text = "Analista de Sistemas de Computación";
            this.lblCarrera.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblCarrera.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Location = new System.Drawing.Point(35, 185);
            this.lblMateria.Size = new System.Drawing.Size(480, 28);
            this.lblMateria.Text = "Laboratorio de Programación 1";
            this.lblMateria.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Location = new System.Drawing.Point(35, 220);
            this.lblNombre.Size = new System.Drawing.Size(500, 28);
            this.lblNombre.Text = "Alumno: Herrera González Esteban Gustavo";
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDni = new System.Windows.Forms.Label();
            this.lblDni.Name = "lblDni";
            this.lblDni.Location = new System.Drawing.Point(35, 255);
            this.lblDni.Size = new System.Drawing.Size(380, 28);
            this.lblDni.Text = "DNI: 34.118.456";
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Location = new System.Drawing.Point(35, 290);
            this.lblNombreProyecto.Size = new System.Drawing.Size(520, 28);
            this.lblNombreProyecto.Text = "Proyecto: MovieInsight | Examen Final";
            this.lblNombreProyecto.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblNombreProyecto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Location = new System.Drawing.Point(35, 325);
            this.lblVersion.Size = new System.Drawing.Size(200, 28);
            this.lblVersion.Text = "Versión 1.0";
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Location = new System.Drawing.Point(430, 385);
            this.btnCerrar.Size = new System.Drawing.Size(145, 42);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(244, 198, 93);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Height = 88;
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(16, 43, 69);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(30, 16);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(244, 198, 93);
            this.lblTitulo.Text = "Acerca de...";
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(32, 57);
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(196, 214, 232);
            this.lblSubtitulo.Text = "MOVIEINSIGHT  |  IES21 - LABORATORIO DE PROGRAMACIÓN 1";
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblInstituto);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombreProyecto);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pnlEncabezado);
            this.ClientSize = new System.Drawing.Size(650, 490);
            this.BackColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmAcercaDe";
            this.Text = "Acerca de...";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblInstituto;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnCerrar;
    }
}
