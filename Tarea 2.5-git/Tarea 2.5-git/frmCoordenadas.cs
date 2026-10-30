/*
 * Creado por SharpDevelop.
 * Usuario: iadrd
 * Fecha: 30/10/2026
 * Hora: 12:18 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tarea_2.__git
{
	/// <summary>
	/// Description of frmCoordenadas.
	/// </summary>
	public partial class frmCoordenadas : Form
	{
		public frmCoordenadas()
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
			double x, y;

		    if (!double.TryParse(txtX.Text, out x) ||
		        !double.TryParse(txtY.Text, out y))
		    {
		        MessageBox.Show("Ingresa coordenadas válidas.");
		        return;
		    }
		
		    if (x > 0 && y > 0)
		    {
		        lblResultado.Text = "Cuadrante I";
		    }
		    else if (x < 0 && y > 0)
		    {
		        lblResultado.Text = "Cuadrante II";
		    }
		    else if (x < 0 && y < 0)
		    {
		        lblResultado.Text = "Cuadrante III";
		    }
		    else if (x > 0 && y < 0)
		    {
		        lblResultado.Text = "Cuadrante IV";
		    }
		    else if (x == 0 && y == 0)
		    {
		        lblResultado.Text = "Origen (0,0)";
		    }
		    else if (x == 0)
		    {
		        lblResultado.Text = "Eje Y";
		    }
		    else
		    {
		        lblResultado.Text = "Eje X";
		    }
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtX.Clear();
		    txtY.Clear();
		    lblResultado.Text = "Resultado:";
		    txtX.Focus();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
