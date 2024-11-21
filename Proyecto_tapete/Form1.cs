/*
 * Created by SharpDevelop.
 * User: CC2_PC41
 * Date: 20/11/2024
 * Time: 02:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_tapete
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			// datos de los TextBoxes :) (:
            int area = int.Parse(txtArea.Text); 
            int costoAserrin = int.Parse(txtCostoAserrin.Text); 
            int costoPintura = int.Parse(txtCostoPintura.Text); 
            int costoFrutosSecos = int.Parse(txtCostoFrutosSecos.Text); 
            int costoFlores = int.Parse(txtCostoFlores.Text); 
            int numPersonas = int.Parse(txtNumPersonas.Text); 
            int costoAlimentos = int.Parse(txtCostoAlimentos.Text); 
            int costoAgua = int.Parse(txtCostoAgua.Text); 
            int tiempoDiseno = int.Parse(txtTiempoDiseno.Text);
            int costoManoObra = int.Parse(txtCostoManoObra.Text); 
            
            // Calcular la cantidad de materiales necesarios
            int cantidadAserrin = area; // 1 unidad de área requiere 1 bulto de aserrín :)
            int cantidadPintura = area; // 1 unidad de área requiere 1 litro de pintura :/
            int cantidadFrutosSecos = area; //1 unidad de área requiere 1 kg de frutos secos :(
            int cantidadFlores = area; //1 unidad de área requiere 1 docena de flores :<
            int cantidadAgua = area; //1 unidad de área requiere 1 litro de agua :>
            
            // Calcular el costo total de los materiales :(
            int totalCostoAserrin = cantidadAserrin * costoAserrin; 
            int totalCostoPintura = cantidadPintura * costoPintura; 
            int totalCostoFrutosSecos = cantidadFrutosSecos * costoFrutosSecos; 
            int totalCostoFlores = cantidadFlores * costoFlores;
            int totalCostoAlimentos = numPersonas * costoAlimentos; 
            int totalCostoAgua = cantidadAgua * costoAgua; 
            int totalCostoDiseno = tiempoDiseno * costoManoObra; 
            int totalCostoManoObra = numPersonas * costoManoObra; 
            int costoTotal = totalCostoAserrin + totalCostoPintura + totalCostoFrutosSecos + totalCostoFlores + totalCostoAlimentos + totalCostoAgua + totalCostoDiseno + totalCostoManoObra;
            
            // Mostrar el resultado en un MessageBox :>
            MessageBox.Show("El costo total de realizar el tapete de aserrín es: $" + costoTotal.ToString("F2"));

		}
	}
}
