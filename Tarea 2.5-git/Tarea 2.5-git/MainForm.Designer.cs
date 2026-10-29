/*
 * Creado por SharpDevelop.
 * Usuario: iadrd
 * Fecha: 29/10/2026
 * Hora: 07:29 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Tarea_2.__git
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(26, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuario:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(26, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(204, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contraseña:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(237, 50);
			this.txtUsuario.Multiline = true;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(252, 35);
			this.txtUsuario.TabIndex = 2;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(236, 114);
			this.txtContraseña.Multiline = true;
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(252, 35);
			this.txtContraseña.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(367, 174);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 38);
			this.button1.TabIndex = 4;
			this.button1.Text = "Ingresar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkRed;
			this.ClientSize = new System.Drawing.Size(526, 249);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Tarea 2.5-git";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
