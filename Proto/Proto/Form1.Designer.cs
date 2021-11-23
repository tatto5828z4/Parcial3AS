namespace Proto
{
    partial class Form1
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
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoTipoPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.transaccionalesToolStripMenuItem,
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
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoProductoToolStripMenuItem,
            this.mantenimientoBodegaToolStripMenuItem,
            this.mantenimientoClienteToolStripMenuItem,
            this.mantenimientoTipoPagoToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // transaccionalesToolStripMenuItem
            // 
            this.transaccionalesToolStripMenuItem.Name = "transaccionalesToolStripMenuItem";
            this.transaccionalesToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.transaccionalesToolStripMenuItem.Text = "Transaccionales";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // mantenimientoProductoToolStripMenuItem
            // 
            this.mantenimientoProductoToolStripMenuItem.Name = "mantenimientoProductoToolStripMenuItem";
            this.mantenimientoProductoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.mantenimientoProductoToolStripMenuItem.Text = "Mantenimiento Producto";
            // 
            // mantenimientoBodegaToolStripMenuItem
            // 
            this.mantenimientoBodegaToolStripMenuItem.Name = "mantenimientoBodegaToolStripMenuItem";
            this.mantenimientoBodegaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.mantenimientoBodegaToolStripMenuItem.Text = "Mantenimiento Bodega";
            // 
            // mantenimientoClienteToolStripMenuItem
            // 
            this.mantenimientoClienteToolStripMenuItem.Name = "mantenimientoClienteToolStripMenuItem";
            this.mantenimientoClienteToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.mantenimientoClienteToolStripMenuItem.Text = "Mantenimiento Cliente";
            // 
            // mantenimientoTipoPagoToolStripMenuItem
            // 
            this.mantenimientoTipoPagoToolStripMenuItem.Name = "mantenimientoTipoPagoToolStripMenuItem";
            this.mantenimientoTipoPagoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.mantenimientoTipoPagoToolStripMenuItem.Text = "Mantenimiento Tipo Pago";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoTipoPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

