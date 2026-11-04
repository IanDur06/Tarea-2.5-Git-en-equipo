/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 04/11/2026
 * Hora: 07:25 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Tarea_2.__git
{
	partial class frmPesos
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
			this.label3 = new System.Windows.Forms.Label();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.cmbMonedas = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(312, 59);
			this.label1.TabIndex = 0;
			this.label1.Text = "Conversión de dinero";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(34, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Conversión";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(34, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Cantidad:";
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRespuesta.Location = new System.Drawing.Point(34, 184);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(328, 68);
			this.lblRespuesta.TabIndex = 3;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(154, 139);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(121, 22);
			this.txtCantidad.TabIndex = 5;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(368, 9);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(131, 68);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(368, 93);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(131, 68);
			this.btnLimpiar.TabIndex = 7;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(368, 184);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(131, 68);
			this.btnRegresar.TabIndex = 8;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// cmbMonedas
			// 
			this.cmbMonedas.FormattingEnabled = true;
			this.cmbMonedas.Items.AddRange(new object[] {
									"",
									"Dólares a Pesos Mexicanos",
									"Pesos Mexicanos a Dólares"});
			this.cmbMonedas.Location = new System.Drawing.Point(154, 80);
			this.cmbMonedas.Name = "cmbMonedas";
			this.cmbMonedas.Size = new System.Drawing.Size(208, 24);
			this.cmbMonedas.TabIndex = 9;
			// 
			// frmPesos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 275);
			this.Controls.Add(this.cmbMonedas);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmPesos";
			this.Text = "frmPesos";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox cmbMonedas;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
