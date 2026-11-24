namespace MovieInsight
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistemaOpcion0 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistemaOpcion1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistemaOpcion2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGeneros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerosOpcion0 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerosOpcion1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerosOpcion2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisualizaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisualizacionesOpcion0 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisualizacionesOpcion1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisualizacionesOpcion2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisualizacionesOpcion3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisualizacionesOpcion4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisualizacionesOpcion5 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.barraEstado = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.barraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.menuPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(198)))), ((int)(((byte)(93)))));
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistema,
            this.mnuGeneros,
            this.mnuVisualizaciones});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1360, 36);
            this.menuPrincipal.TabIndex = 2;
            // 
            // mnuSistema
            // 
            this.mnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistemaOpcion0,
            this.mnuSistemaOpcion1,
            this.mnuSistemaOpcion2});
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(95, 32);
            this.mnuSistema.Text = "Sistema";
            // 
            // mnuSistemaOpcion0
            // 
            this.mnuSistemaOpcion0.Name = "mnuSistemaOpcion0";
            this.mnuSistemaOpcion0.Size = new System.Drawing.Size(349, 32);
            this.mnuSistemaOpcion0.Text = "Acerca de...";
            this.mnuSistemaOpcion0.Click += new System.EventHandler(this.mnuSistemaOpcion0_Click);
            // 
            // mnuSistemaOpcion1
            // 
            this.mnuSistemaOpcion1.Name = "mnuSistemaOpcion1";
            this.mnuSistemaOpcion1.Size = new System.Drawing.Size(349, 32);
            this.mnuSistemaOpcion1.Text = "Carga automática de datos...";
            this.mnuSistemaOpcion1.Click += new System.EventHandler(this.mnuSistemaOpcion1_Click);
            // 
            // mnuSistemaOpcion2
            // 
            this.mnuSistemaOpcion2.Name = "mnuSistemaOpcion2";
            this.mnuSistemaOpcion2.Size = new System.Drawing.Size(349, 32);
            this.mnuSistemaOpcion2.Text = "Salir";
            this.mnuSistemaOpcion2.Click += new System.EventHandler(this.mnuSistemaOpcion2_Click);
            // 
            // mnuGeneros
            // 
            this.mnuGeneros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerosOpcion0,
            this.mnuGenerosOpcion1,
            this.mnuGenerosOpcion2});
            this.mnuGeneros.Name = "mnuGeneros";
            this.mnuGeneros.Size = new System.Drawing.Size(100, 32);
            this.mnuGeneros.Text = "Géneros";
            // 
            // mnuGenerosOpcion0
            // 
            this.mnuGenerosOpcion0.Name = "mnuGenerosOpcion0";
            this.mnuGenerosOpcion0.Size = new System.Drawing.Size(401, 32);
            this.mnuGenerosOpcion0.Text = "Agregar nuevo género...";
            this.mnuGenerosOpcion0.Click += new System.EventHandler(this.mnuGenerosOpcion0_Click);
            // 
            // mnuGenerosOpcion1
            // 
            this.mnuGenerosOpcion1.Name = "mnuGenerosOpcion1";
            this.mnuGenerosOpcion1.Size = new System.Drawing.Size(401, 32);
            this.mnuGenerosOpcion1.Text = "Listado general de géneros...";
            this.mnuGenerosOpcion1.Click += new System.EventHandler(this.mnuGenerosOpcion1_Click);
            // 
            // mnuGenerosOpcion2
            // 
            this.mnuGenerosOpcion2.Name = "mnuGenerosOpcion2";
            this.mnuGenerosOpcion2.Size = new System.Drawing.Size(401, 32);
            this.mnuGenerosOpcion2.Text = "Consulta de datos de un género...";
            this.mnuGenerosOpcion2.Click += new System.EventHandler(this.mnuGenerosOpcion2_Click);
            // 
            // mnuVisualizaciones
            // 
            this.mnuVisualizaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVisualizacionesOpcion0,
            this.mnuVisualizacionesOpcion1,
            this.mnuVisualizacionesOpcion2,
            this.mnuVisualizacionesOpcion3,
            this.mnuVisualizacionesOpcion4,
            this.mnuVisualizacionesOpcion5});
            this.mnuVisualizaciones.Name = "mnuVisualizaciones";
            this.mnuVisualizaciones.Size = new System.Drawing.Size(160, 32);
            this.mnuVisualizaciones.Text = "Visualizaciones";
            // 
            // mnuVisualizacionesOpcion0
            // 
            this.mnuVisualizacionesOpcion0.Name = "mnuVisualizacionesOpcion0";
            this.mnuVisualizacionesOpcion0.Size = new System.Drawing.Size(476, 32);
            this.mnuVisualizacionesOpcion0.Text = "Registrar visualización...";
            this.mnuVisualizacionesOpcion0.Click += new System.EventHandler(this.mnuVisualizacionesOpcion0_Click);
            // 
            // mnuVisualizacionesOpcion1
            // 
            this.mnuVisualizacionesOpcion1.Name = "mnuVisualizacionesOpcion1";
            this.mnuVisualizacionesOpcion1.Size = new System.Drawing.Size(476, 32);
            this.mnuVisualizacionesOpcion1.Text = "Consulta de visualizaciones...";
            this.mnuVisualizacionesOpcion1.Click += new System.EventHandler(this.mnuVisualizacionesOpcion1_Click);
            // 
            // mnuVisualizacionesOpcion2
            // 
            this.mnuVisualizacionesOpcion2.Name = "mnuVisualizacionesOpcion2";
            this.mnuVisualizacionesOpcion2.Size = new System.Drawing.Size(476, 32);
            this.mnuVisualizacionesOpcion2.Text = "Visualizaciones de un mes...";
            this.mnuVisualizacionesOpcion2.Click += new System.EventHandler(this.mnuVisualizacionesOpcion2_Click);
            // 
            // mnuVisualizacionesOpcion3
            // 
            this.mnuVisualizacionesOpcion3.Name = "mnuVisualizacionesOpcion3";
            this.mnuVisualizacionesOpcion3.Size = new System.Drawing.Size(476, 32);
            this.mnuVisualizacionesOpcion3.Text = "Visualizaciones de un género...";
            this.mnuVisualizacionesOpcion3.Click += new System.EventHandler(this.mnuVisualizacionesOpcion3_Click);
            // 
            // mnuVisualizacionesOpcion4
            // 
            this.mnuVisualizacionesOpcion4.Name = "mnuVisualizacionesOpcion4";
            this.mnuVisualizacionesOpcion4.Size = new System.Drawing.Size(476, 32);
            this.mnuVisualizacionesOpcion4.Text = "Estadística de visualizaciones por mes...";
            this.mnuVisualizacionesOpcion4.Click += new System.EventHandler(this.mnuVisualizacionesOpcion4_Click);
            // 
            // mnuVisualizacionesOpcion5
            // 
            this.mnuVisualizacionesOpcion5.Name = "mnuVisualizacionesOpcion5";
            this.mnuVisualizacionesOpcion5.Size = new System.Drawing.Size(476, 32);
            this.mnuVisualizacionesOpcion5.Text = "Estadística de visualizaciones por género...";
            this.mnuVisualizacionesOpcion5.Click += new System.EventHandler(this.mnuVisualizacionesOpcion5_Click);
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblDescripcion);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 36);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1360, 120);
            this.pnlEncabezado.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 32F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(198)))), ((int)(((byte)(93)))));
            this.lblTitulo.Location = new System.Drawing.Point(46, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(423, 74);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MOVIEINSIGHT";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.lblDescripcion.Location = new System.Drawing.Point(50, 82);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(701, 31);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Análisis de visualizaciones cinematográficas  |  IES21 - Examen Final";
            // 
            // picBanner
            // 
            this.picBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBanner.Location = new System.Drawing.Point(0, 156);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1360, 547);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            // 
            // barraEstado
            // 
            this.barraEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.barraEstado.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.barraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.barraEstado.Location = new System.Drawing.Point(0, 703);
            this.barraEstado.Name = "barraEstado";
            this.barraEstado.Size = new System.Drawing.Size(1360, 28);
            this.barraEstado.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(198)))), ((int)(((byte)(93)))));
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(428, 23);
            this.lblEstado.Text = "MovieInsight v1.0 | IES21 - Examen Final 2026";
            // 
            // frmPrincipal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1360, 731);
            this.Controls.Add(this.picBanner);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.barraEstado);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "MovieInsight - Examen Final IES21";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.barraEstado.ResumeLayout(false);
            this.barraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.StatusStrip barraEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripMenuItem mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaOpcion0;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaOpcion1;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaOpcion2;
        private System.Windows.Forms.ToolStripMenuItem mnuGeneros;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerosOpcion0;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerosOpcion1;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerosOpcion2;
        private System.Windows.Forms.ToolStripMenuItem mnuVisualizaciones;
        private System.Windows.Forms.ToolStripMenuItem mnuVisualizacionesOpcion0;
        private System.Windows.Forms.ToolStripMenuItem mnuVisualizacionesOpcion1;
        private System.Windows.Forms.ToolStripMenuItem mnuVisualizacionesOpcion2;
        private System.Windows.Forms.ToolStripMenuItem mnuVisualizacionesOpcion3;
        private System.Windows.Forms.ToolStripMenuItem mnuVisualizacionesOpcion4;
        private System.Windows.Forms.ToolStripMenuItem mnuVisualizacionesOpcion5;
    }
}
