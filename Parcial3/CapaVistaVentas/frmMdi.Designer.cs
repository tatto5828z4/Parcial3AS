namespace CapaVistaVentas
{
    partial class frmMdi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoTipoPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.transaccionalToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.inicioToolStripMenuItem.Text = "Archivo";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoBodegaToolStripMenuItem,
            this.mantenimientoProductoToolStripMenuItem,
            this.mantenimientoClienteToolStripMenuItem,
            this.mantenimientoTipoPagoToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.mantenimientoToolStripMenuItem.Text = "Catalogo";
            // 
            // transaccionalToolStripMenuItem
            // 
            this.transaccionalToolStripMenuItem.Name = "transaccionalToolStripMenuItem";
            this.transaccionalToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.transaccionalToolStripMenuItem.Text = "Transaccional";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // mantenimientoBodegaToolStripMenuItem
            // 
            this.mantenimientoBodegaToolStripMenuItem.Name = "mantenimientoBodegaToolStripMenuItem";
            this.mantenimientoBodegaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.mantenimientoBodegaToolStripMenuItem.Text = "Mantenimiento Bodega";
            this.mantenimientoBodegaToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoBodegaToolStripMenuItem_Click);
            // 
            // mantenimientoProductoToolStripMenuItem
            // 
            this.mantenimientoProductoToolStripMenuItem.Name = "mantenimientoProductoToolStripMenuItem";
            this.mantenimientoProductoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.mantenimientoProductoToolStripMenuItem.Text = "Mantenimiento Producto";
            this.mantenimientoProductoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoProductoToolStripMenuItem_Click);
            // 
            // mantenimientoClienteToolStripMenuItem
            // 
            this.mantenimientoClienteToolStripMenuItem.Name = "mantenimientoClienteToolStripMenuItem";
            this.mantenimientoClienteToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.mantenimientoClienteToolStripMenuItem.Text = "Mantenimiento Cliente";
            this.mantenimientoClienteToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoClienteToolStripMenuItem_Click);
            // 
            // mantenimientoTipoPagoToolStripMenuItem
            // 
            this.mantenimientoTipoPagoToolStripMenuItem.Name = "mantenimientoTipoPagoToolStripMenuItem";
            this.mantenimientoTipoPagoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.mantenimientoTipoPagoToolStripMenuItem.Text = "Mantenimiento Tipo Pago";
            this.mantenimientoTipoPagoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoTipoPagoToolStripMenuItem_Click);
            // 
            // frmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMdi";
            this.Text = "frmMdi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoTipoPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}