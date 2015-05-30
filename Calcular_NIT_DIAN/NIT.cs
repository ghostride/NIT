/*
 * Creado por SharpDevelop.
 * Usuario: GB
 * Fecha: 20/04/2015
 * Hora: 01:30 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace Calcular_NIT_DIAN
{
//	/// <summary>
//	/// Description of NIT.
//	/// </summary>
//	public class NIT
//	{
//		public NIT()
//		{
//		}
//	}
//	
//		
	public class CalculoNit
	{

		private string _mDocumento;
		private int _mDigito;
		private string mDocumento
		{

			get
			{
				return this._mDocumento;
			}
			set
			{
				this._mDocumento = value;
			}
		}
		private int mDigito
		{
			get
			{
				return this._mDigito;
			}
			set
			{
				this._mDigito = value;
			}
		}
		public CalculoNit()
		{
			string mDocumento = null;
			this.mDocumento = mDocumento;
		}
		public int CalculaNit(string Numero)
		{
			Numero = this.LimpiarSeparadores(Numero);
			this.mDocumento = Strings.Format(Conversion.Val(Numero), "000000000000000");
			this.CalcularDigito();
			return this.mDigito;
		}
		public bool VerificaNit(string Numero, int Digito)
		{
			Numero = this.LimpiarSeparadores(Numero);
			this.mDocumento = Strings.Format(Conversion.Val(Numero), "000000000000000");
			this.CalcularDigito();
			return this.mDigito == Digito;
		}
		public bool VerificaNit(string Numero)
		{
			Numero = this.LimpiarSeparadores(Numero);
			this.mDocumento = Strings.Format(Conversion.Val(Numero), "0000000000000000");
			int num = checked((int)Math.Round(Conversion.Val(Strings.Mid(this.mDocumento, 16, 1))));
			this.mDocumento = Strings.Mid(this.mDocumento, 1, 15);
			this.CalcularDigito();
			return this.mDigito == num;
		}
		private void CalcularDigito()
		{
			checked
			{
				long num = (long)Math.Round(unchecked(Conversion.Val(Strings.Mid(this.mDocumento, 1, 1)) * 71.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 2, 1)) * 67.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 3, 1)) * 59.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 4, 1)) * 53.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 5, 1)) * 47.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 6, 1)) * 43.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 7, 1)) * 41.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 8, 1)) * 37.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 9, 1)) * 29.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 10, 1)) * 23.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 11, 1)) * 19.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 12, 1)) * 17.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 13, 1)) * 13.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 14, 1)) * 7.0));
				num = (long)Math.Round(unchecked((double)num + Conversion.Val(Strings.Mid(this.mDocumento, 15, 1)) * 3.0));
				int num2 = (int)(num % 11L);
				switch (num2)
				{
				case 0:
					this.mDigito = 0;
					break;
				case 1:
					this.mDigito = 1;
					break;
				default:
					this.mDigito = 11 - num2;
					break;
				}
			}
		}
		private string LimpiarSeparadores(string Numero)
		{
			Numero = Strings.Replace(Numero, ",", "", 1, -1, CompareMethod.Binary);
			Numero = Strings.Replace(Numero, ".", "", 1, -1, CompareMethod.Binary);
			Numero = Strings.Replace(Numero, "-", "", 1, -1, CompareMethod.Binary);
			Numero = Strings.Replace(Numero, " ", "", 1, -1, CompareMethod.Binary);
			return Numero;
		}
	}
}

