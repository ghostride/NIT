/*
 * Creado por SharpDevelop.
 * Usuario: GB
 * Fecha: 20/04/2015
 * Hora: 01:11 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calcular_NIT_DIAN
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		private CalculoNit oDigito;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.oDigito = new CalculoNit();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	
		void BtnCalculaClick(object sender, EventArgs e)
		{
			bool flag = this.txtNit.Text.Length > 0;
			if (flag)
			{
				this.txtDigito.Text = Convert.ToString(this.oDigito.CalculaNit(this.txtNit.Text));
			}
		}
		
		void BtnVerificaClick(object sender, EventArgs e)
		{
			bool flag = this.txtNitCompleto.Text.Length > 0;
			if (flag)
			{
				this.txtResultado.Text = Convert.ToString(this.oDigito.VerificaNit(this.txtNitCompleto.Text));
			}
		}
		
		void BtnVer2Click(object sender, EventArgs e)
		{
			bool flag = this.txtNitVer.Text.Length > 0 & this.txtDigVer.Text.Length > 0;
			if (flag)
			{
				this.txtResVer.Text = Convert.ToString(this.oDigito.VerificaNit(this.txtNitVer.Text, Convert.ToInt32(this.txtDigVer.Text)));
			}
		}
	}
}
