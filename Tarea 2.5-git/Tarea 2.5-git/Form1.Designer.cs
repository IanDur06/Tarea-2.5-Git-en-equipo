/*
 * Creado por SharpDevelop.
 * Usuario: iadrd
 * Fecha: 29/10/2026
 * Hora: 07:37 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Tarea_2.__git
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.coordenadasDeUnPuntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem,
									this.programasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(502, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.regresarToolStripMenuItem,
									this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
			this.archivoToolStripMenuItem.Text = "&Archivo";
			// 
			// regresarToolStripMenuItem
			// 
			this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
			this.regresarToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
			this.regresarToolStripMenuItem.Text = "Regresar";
			this.regresarToolStripMenuItem.Click += new System.EventHandler(this.RegresarToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
			this.salirToolStripMenuItem.Text = "&Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// programasToolStripMenuItem
			// 
			this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.coordenadasDeUnPuntoToolStripMenuItem});
			this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
			this.programasToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
			this.programasToolStripMenuItem.Text = "&Programas";
			// 
			// coordenadasDeUnPuntoToolStripMenuItem
			// 
			this.coordenadasDeUnPuntoToolStripMenuItem.Name = "coordenadasDeUnPuntoToolStripMenuItem";
			this.coordenadasDeUnPuntoToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
			this.coordenadasDeUnPuntoToolStripMenuItem.Text = "&Coordenadas de un punto";
			this.coordenadasDeUnPuntoToolStripMenuItem.Click += new System.EventHandler(this.CoordenadasDeUnPuntoToolStripMenuItemClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 322);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem coordenadasDeUnPuntoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
