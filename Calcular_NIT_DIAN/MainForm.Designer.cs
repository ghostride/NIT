/*
 * Creado por SharpDevelop.
 * Usuario: GB
 * Fecha: 20/04/2015
 * Hora: 01:11 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Calcular_NIT_DIAN
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
			this.btnCalcula = new System.Windows.Forms.Button();
			this.btnVerifica = new System.Windows.Forms.Button();
			this.btnVer2 = new System.Windows.Forms.Button();
			this.txtNit = new System.Windows.Forms.TextBox();
			this.txtDigito = new System.Windows.Forms.TextBox();
			this.txtNitCompleto = new System.Windows.Forms.TextBox();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.txtNitVer = new System.Windows.Forms.TextBox();
			this.txtDigVer = new System.Windows.Forms.TextBox();
			this.txtResVer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCalcula
			// 
			this.btnCalcula.Location = new System.Drawing.Point(521, 74);
			this.btnCalcula.Name = "btnCalcula";
			this.btnCalcula.Size = new System.Drawing.Size(110, 23);
			this.btnCalcula.TabIndex = 0;
			this.btnCalcula.Text = "Calcular";
			this.btnCalcula.UseVisualStyleBackColor = true;
			this.btnCalcula.Click += new System.EventHandler(this.BtnCalculaClick);
			// 
			// btnVerifica
			// 
			this.btnVerifica.Location = new System.Drawing.Point(521, 111);
			this.btnVerifica.Name = "btnVerifica";
			this.btnVerifica.Size = new System.Drawing.Size(110, 23);
			this.btnVerifica.TabIndex = 1;
			this.btnVerifica.Text = "Verificar";
			this.btnVerifica.UseVisualStyleBackColor = true;
			this.btnVerifica.Click += new System.EventHandler(this.BtnVerificaClick);
			// 
			// btnVer2
			// 
			this.btnVer2.Location = new System.Drawing.Point(521, 150);
			this.btnVer2.Name = "btnVer2";
			this.btnVer2.Size = new System.Drawing.Size(110, 23);
			this.btnVer2.TabIndex = 2;
			this.btnVer2.Text = "Verificar";
			this.btnVer2.UseVisualStyleBackColor = true;
			this.btnVer2.Click += new System.EventHandler(this.BtnVer2Click);
			// 
			// txtNit
			// 
			this.txtNit.Location = new System.Drawing.Point(236, 76);
			this.txtNit.Name = "txtNit";
			this.txtNit.Size = new System.Drawing.Size(187, 20);
			this.txtNit.TabIndex = 3;
			// 
			// txtDigito
			// 
			this.txtDigito.Location = new System.Drawing.Point(428, 77);
			this.txtDigito.Name = "txtDigito";
			this.txtDigito.ReadOnly = true;
			this.txtDigito.Size = new System.Drawing.Size(79, 20);
			this.txtDigito.TabIndex = 4;
			// 
			// txtNitCompleto
			// 
			this.txtNitCompleto.Location = new System.Drawing.Point(236, 114);
			this.txtNitCompleto.Name = "txtNitCompleto";
			this.txtNitCompleto.Size = new System.Drawing.Size(187, 20);
			this.txtNitCompleto.TabIndex = 5;
			// 
			// txtResultado
			// 
			this.txtResultado.Location = new System.Drawing.Point(428, 115);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.ReadOnly = true;
			this.txtResultado.Size = new System.Drawing.Size(79, 20);
			this.txtResultado.TabIndex = 6;
			// 
			// txtNitVer
			// 
			this.txtNitVer.Location = new System.Drawing.Point(236, 151);
			this.txtNitVer.Name = "txtNitVer";
			this.txtNitVer.Size = new System.Drawing.Size(112, 20);
			this.txtNitVer.TabIndex = 7;
			// 
			// txtDigVer
			// 
			this.txtDigVer.Location = new System.Drawing.Point(352, 152);
			this.txtDigVer.Name = "txtDigVer";
			this.txtDigVer.Size = new System.Drawing.Size(69, 20);
			this.txtDigVer.TabIndex = 8;
			// 
			// txtResVer
			// 
			this.txtResVer.Location = new System.Drawing.Point(428, 154);
			this.txtResVer.Name = "txtResVer";
			this.txtResVer.ReadOnly = true;
			this.txtResVer.Size = new System.Drawing.Size(79, 20);
			this.txtResVer.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(73, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(523, 52);
			this.label1.TabIndex = 10;
			this.label1.Text = "Aplicación ejemplo para el uso de la clase de cálculo de NIT, deben usar solament" +
			"e números sin comas puntos o rayas. se puede invocar de tres maneras diferentes." +
			"";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(-3, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Digite solamente el NIT";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(-3, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(231, 21);
			this.label3.TabIndex = 12;
			this.label3.Text = "Digite NIT con el digito de verificación";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(-3, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(231, 21);
			this.label4.TabIndex = 13;
			this.label4.Text = "Digite NIT y el digito de verificación separados";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 250);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtResVer);
			this.Controls.Add(this.txtDigVer);
			this.Controls.Add(this.txtNitVer);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.txtNitCompleto);
			this.Controls.Add(this.txtDigito);
			this.Controls.Add(this.txtNit);
			this.Controls.Add(this.btnVer2);
			this.Controls.Add(this.btnVerifica);
			this.Controls.Add(this.btnCalcula);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calcular NIT DIAN";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtResVer;
		private System.Windows.Forms.TextBox txtDigVer;
		private System.Windows.Forms.TextBox txtNitVer;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.TextBox txtNitCompleto;
		private System.Windows.Forms.TextBox txtDigito;
		private System.Windows.Forms.TextBox txtNit;
		private System.Windows.Forms.Button btnVer2;
		private System.Windows.Forms.Button btnVerifica;
		private System.Windows.Forms.Button btnCalcula;
	}
}
