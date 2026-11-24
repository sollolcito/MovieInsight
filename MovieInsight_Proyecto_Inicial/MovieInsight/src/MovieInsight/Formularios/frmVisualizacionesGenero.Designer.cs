namespace MovieInsight.Formularios
{
    partial class frmVisualizacionesGenero
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
            this.lblGenero.Location = new System.Drawing.Point(35, 117);
            this.lblGenero.Size = new System.Drawing.Size(260, 24);
            this.lblGenero.Text = "Seleccionar género";
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Location = new System.Drawing.Point(35, 146);
            this.cmbGenero.Size = new System.Drawing.Size(365, 34);
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(232, 239, 248);
            this.cmbGenero.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.cmbGenero.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Location = new System.Drawing.Point(605, 143);
            this.cmdListar.Size = new System.Drawing.Size(165, 41);
            this.cmdListar.Text = "Listar";
            this.cmdListar.BackColor = System.Drawing.Color.FromArgb(244, 198, 93);
            this.cmdListar.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.cmdListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.cmdListar.UseVisualStyleBackColor = false;
            this.dgvVisualizaciones = new System.Windows.Forms.DataGridView();
            this.dgvVisualizaciones.Name = "dgvVisualizaciones";
            this.dgvVisualizaciones.Location = new System.Drawing.Point(35, 205);
            this.dgvVisualizaciones.Size = new System.Drawing.Size(735, 215);
            this.dgvVisualizaciones.BackgroundColor = System.Drawing.Color.FromArgb(21, 53, 80);
            this.dgvVisualizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisualizaciones.AllowUserToAddRows = false;
            this.dgvVisualizaciones.ReadOnly = true;
            this.dgvVisualizaciones.RowHeadersVisible = false;
            this.dgvVisualizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizaciones.Columns.Add("col0", "Mes");
            this.dgvVisualizaciones.Columns.Add("col1", "Cantidad");
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Location = new System.Drawing.Point(35, 435);
            this.lblTotal.Size = new System.Drawing.Size(330, 30);
            this.lblTotal.Text = "Total: -";
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Location = new System.Drawing.Point(410, 435);
            this.lblPromedio.Size = new System.Drawing.Size(340, 30);
            this.lblPromedio.Text = "Promedio: -";
            this.lblPromedio.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Location = new System.Drawing.Point(35, 476);
            this.lblMaximo.Size = new System.Drawing.Size(330, 30);
            this.lblMaximo.Text = "Máximo: -";
            this.lblMaximo.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblMaximo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Location = new System.Drawing.Point(410, 476);
            this.lblMinimo.Size = new System.Drawing.Size(340, 30);
            this.lblMinimo.Text = "Mínimo: -";
            this.lblMinimo.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblMinimo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Height = 88;
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(16, 43, 69);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(30, 16);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(244, 198, 93);
            this.lblTitulo.Text = "Visualizaciones de un género...";
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(32, 57);
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(196, 214, 232);
            this.lblSubtitulo.Text = "MOVIEINSIGHT  |  IES21 - LABORATORIO DE PROGRAMACIÓN 1";
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.dgvVisualizaciones);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.pnlEncabezado);
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.BackColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmVisualizacionesGenero";
            this.Text = "Visualizaciones de un género...";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridView dgvVisualizaciones;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
    }
}
