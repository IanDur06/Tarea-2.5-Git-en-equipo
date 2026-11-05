/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 04/11/2026
 * Hora: 08:14 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tarea_2.__git
{
	/// <summary>
	/// Description of Distancia.
	/// </summary>
	public partial class Distancia : Form
	{
		public Distancia()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			Double lblX1, lblX2, lblY1, lblY2, distancia;
			lblX1 = Convert.ToDouble(txtX1.Text);
			lblX2 = Convert.ToDouble(txtX2.Text);
			lblY1 = Convert.ToDouble(txtY1.Text);
			lblY2 = Convert.ToDouble(txtY2.Text);
			
			distancia = Math.Sqrt(Math.Pow(lblX2 - lblX1, 2) + Math.Pow(lblY2 - lblY1,2));
            lblRespuesta.Text = "La distancia es de: " + Convert.ToString(Math.Round(distancia,3));
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtX1.Text = "";
			txtX2.Text = "";
			txtY1.Text = "";
			txtY2.Text = "";
			lblRespuesta.Text = "";
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Form1 f = new Form1();
			f.Show();
			this.Close();
		}
	}
}
