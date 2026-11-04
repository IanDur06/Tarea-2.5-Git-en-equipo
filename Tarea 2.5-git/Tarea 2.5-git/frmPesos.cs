/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 04/11/2026
 * Hora: 07:25 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tarea_2.__git
{
	/// <summary>
	/// Description of frmPesos.
	/// </summary>
	public partial class frmPesos : Form
	{
		public frmPesos()
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
			double dolares = 18.66;
			double pesos = 0.054;
			double cantidad = Convert.ToDouble(txtCantidad.Text);
			double resultado;
			if (cmbMonedas.SelectedIndex == 1)
			{
				resultado = cantidad * dolares;
				lblRespuesta.Text = "$" + cantidad + " Dólares son: " + "$" + resultado + " pesos Mexicanos";
			}
			if (cmbMonedas.SelectedIndex == 2)
			{
				resultado = cantidad * pesos;
				lblRespuesta.Text = "$" + cantidad + " Pesos Mexicanos son: " + "$" + resultado + " Dólares";
			}
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtCantidad.Text = "";
			cmbMonedas.Text = "";
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
