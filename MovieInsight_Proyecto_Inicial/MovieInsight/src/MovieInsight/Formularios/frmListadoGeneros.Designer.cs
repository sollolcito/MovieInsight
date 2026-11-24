namespace MovieInsight.Formularios
{
    partial class frmListadoGeneros
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
            this.dgvGeneros = new System.Windows.Forms.DataGridView();
            this.dgvGeneros.Name = "dgvGeneros";
            this.dgvGeneros.Location = new System.Drawing.Point(35, 115);
            this.dgvGeneros.Size = new System.Drawing.Size(755, 300);
            this.dgvGeneros.BackgroundColor = System.Drawing.Color.FromArgb(21, 53, 80);
            this.dgvGeneros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGeneros.AllowUserToAddRows = false;
            this.dgvGeneros.ReadOnly = true;
            this.dgvGeneros.RowHeadersVisible = false;
            this.dgvGeneros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGeneros.Columns.Add("col0", "Código");
            this.dgvGeneros.Columns.Add("col1", "Nombre");
            this.dgvGeneros.Columns.Add("col2", "Descripción");
            this.lblContador = new System.Windows.Forms.Label();
            this.lblContador.Name = "lblContador";
            this.lblContador.Location = new System.Drawing.Point(35, 445);
            this.lblContador.Size = new System.Drawing.Size(390, 32);
            this.lblContador.Text = "Géneros cargados: 0";
            this.lblContador.ForeColor = System.Drawing.Color.FromArgb(229, 237, 247);
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Location = new System.Drawing.Point(625, 435);
            this.cmdListar.Size = new System.Drawing.Size(165, 44);
            this.cmdListar.Text = "Listar";
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
            this.lblTitulo.Text = "Listado general de géneros...";
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(32, 57);
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(196, 214, 232);
            this.lblSubtitulo.Text = "MOVIEINSIGHT  |  IES21 - LABORATORIO DE PROGRAMACIÓN 1";
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.dgvGeneros);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.pnlEncabezado);
            this.ClientSize = new System.Drawing.Size(810, 525);
            this.BackColor = System.Drawing.Color.FromArgb(8, 24, 39);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmListadoGeneros";
            this.Text = "Listado general de géneros...";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.DataGridView dgvGeneros;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button cmdListar;
    }
}
