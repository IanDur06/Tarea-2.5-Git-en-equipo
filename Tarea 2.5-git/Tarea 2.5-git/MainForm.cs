/*
 * Creado por SharpDevelop.
 * Usuario: iadrd
 * Fecha: 29/10/2026
 * Hora: 07:29 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tarea_2.__git
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(txtUsuario.Text == "Admin" && txtContraseña.Text == "12345"){
				Form1 f = new Form1();
				f.Show();
				this.Hide();
			}
			else{
				MessageBox.Show("Usuario y contraseña incorrectos. Revisar si esta bien.");
			}
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
		    {
		        txtContraseña.PasswordChar = '\0';
		        checkBox1.Text = "Ocultar contraseña";
		    }
		    else
		    {
		        txtContraseña.PasswordChar = '*';
		        checkBox1.Text = "Mostrar contraseña";
		    }
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
