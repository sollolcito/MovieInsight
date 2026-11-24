namespace MovieInsight.Formularios
{
    partial class frmEstadisticasGenero
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
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.Location = new System.Drawing.Point(35, 122);
            this.dgvEstadisticas.Size = new System.Drawing.Size(760, 353);
            this.dgvEstadisticas.BackgroundColor = System.Drawing.Color.FromArgb(21, 53, 80);
            this.dgvEstadisticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstadisticas.AllowUserToAddRows = false;
            this.dgvEstadisticas.ReadOnly = true;
            this.dgvEstadisticas.RowHeadersVisible = false;
            this.dgvEstadisticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadisticas.Columns.Add("col0", "Género");
            this.dgvEstadisticas.Columns.Add("col1", "Cantidad");
            this.dgvEstadisticas.Columns.Add("col2", "Promedio");
            this.dgvEstadisticas.Columns.Add("col3", "Máximo");
            this.dgvEstadisticas.Columns.Add("col4", "Mínimo");
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Location = new System.Drawing.Point(614, 493);
            this.cmdListar.Size = new System.Drawing.Size(181, 44);
            this.cmdListar.Text = "Listar estadísticas";
            this.cmdListar.BackColor = System.Drawing.Color.FromArgb(244, 198, 93);
            this.cmdListar.ForeColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.cmdListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.cmdListar.UseVisualStyleBackColor = false;
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Height = 88;
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(16, 43, 69);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(30, 16);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(244, 198, 93);
            this.lblTitulo.Text = "Estadística de visualizaciones por género...";
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(32, 57);
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(196, 214, 232);
            this.lblSubtitulo.Text = "MOVIEINSIGHT  |  IES21 - LABORATORIO DE PROGRAMACIÓN 1";
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.dgvEstadisticas);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.pnlEncabezado);
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.BackColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmEstadisticasGenero";
            this.Text = "Estadística de visualizaciones por género...";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.DataGridView dgvEstadisticas;
        private System.Windows.Forms.Button cmdListar;
    }
}
