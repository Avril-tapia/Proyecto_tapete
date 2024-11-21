/*
 * Created by SharpDevelop.
 * User: CC2_PC41
 * Date: 20/11/2024
 * Time: 02:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto_tapete
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCostoAserrin = new System.Windows.Forms.TextBox();
			this.txtCostoPintura = new System.Windows.Forms.TextBox();
			this.txtCostoFrutosSecos = new System.Windows.Forms.TextBox();
			this.txtCostoFlores = new System.Windows.Forms.TextBox();
			this.txtNumPersonas = new System.Windows.Forms.TextBox();
			this.txtCostoAlimentos = new System.Windows.Forms.TextBox();
			this.txtCostoAgua = new System.Windows.Forms.TextBox();
			this.txtTiempoDiseno = new System.Windows.Forms.TextBox();
			this.txtCostoManoObra = new System.Windows.Forms.TextBox();
			this.btncalcular = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(37, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Área:";
			// 
			// txtArea
			// 
			this.txtArea.Location = new System.Drawing.Point(345, 38);
			this.txtArea.Name = "txtArea";
			this.txtArea.Size = new System.Drawing.Size(116, 21);
			this.txtArea.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(37, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(198, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Costo del bulto de aserrín:";
			// 
			// txtCostoAserrin
			// 
			this.txtCostoAserrin.Location = new System.Drawing.Point(345, 79);
			this.txtCostoAserrin.Name = "txtCostoAserrin";
			this.txtCostoAserrin.Size = new System.Drawing.Size(116, 21);
			this.txtCostoAserrin.TabIndex = 3;
			// 
			// txtCostoPintura
			// 
			this.txtCostoPintura.Location = new System.Drawing.Point(345, 120);
			this.txtCostoPintura.Name = "txtCostoPintura";
			this.txtCostoPintura.Size = new System.Drawing.Size(116, 21);
			this.txtCostoPintura.TabIndex = 4;
			// 
			// txtCostoFrutosSecos
			// 
			this.txtCostoFrutosSecos.Location = new System.Drawing.Point(345, 166);
			this.txtCostoFrutosSecos.Name = "txtCostoFrutosSecos";
			this.txtCostoFrutosSecos.Size = new System.Drawing.Size(116, 21);
			this.txtCostoFrutosSecos.TabIndex = 5;
			// 
			// txtCostoFlores
			// 
			this.txtCostoFlores.Location = new System.Drawing.Point(345, 204);
			this.txtCostoFlores.Name = "txtCostoFlores";
			this.txtCostoFlores.Size = new System.Drawing.Size(116, 21);
			this.txtCostoFlores.TabIndex = 6;
			// 
			// txtNumPersonas
			// 
			this.txtNumPersonas.Location = new System.Drawing.Point(345, 253);
			this.txtNumPersonas.Name = "txtNumPersonas";
			this.txtNumPersonas.Size = new System.Drawing.Size(116, 21);
			this.txtNumPersonas.TabIndex = 7;
			// 
			// txtCostoAlimentos
			// 
			this.txtCostoAlimentos.Location = new System.Drawing.Point(345, 295);
			this.txtCostoAlimentos.Name = "txtCostoAlimentos";
			this.txtCostoAlimentos.Size = new System.Drawing.Size(116, 21);
			this.txtCostoAlimentos.TabIndex = 8;
			// 
			// txtCostoAgua
			// 
			this.txtCostoAgua.Location = new System.Drawing.Point(345, 337);
			this.txtCostoAgua.Name = "txtCostoAgua";
			this.txtCostoAgua.Size = new System.Drawing.Size(116, 21);
			this.txtCostoAgua.TabIndex = 9;
			// 
			// txtTiempoDiseno
			// 
			this.txtTiempoDiseno.Location = new System.Drawing.Point(345, 403);
			this.txtTiempoDiseno.Name = "txtTiempoDiseno";
			this.txtTiempoDiseno.Size = new System.Drawing.Size(116, 21);
			this.txtTiempoDiseno.TabIndex = 10;
			// 
			// txtCostoManoObra
			// 
			this.txtCostoManoObra.Location = new System.Drawing.Point(345, 447);
			this.txtCostoManoObra.Name = "txtCostoManoObra";
			this.txtCostoManoObra.Size = new System.Drawing.Size(116, 21);
			this.txtCostoManoObra.TabIndex = 11;
			// 
			// btncalcular
			// 
			this.btncalcular.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncalcular.Location = new System.Drawing.Point(155, 520);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(181, 46);
			this.btncalcular.TabIndex = 12;
			this.btncalcular.Text = "CALCULAR";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(37, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(198, 25);
			this.label3.TabIndex = 13;
			this.label3.Text = "Costo del litro de pintura:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(36, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(199, 25);
			this.label4.TabIndex = 14;
			this.label4.Text = "Costo de frutos secos por kg:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(37, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(198, 25);
			this.label5.TabIndex = 15;
			this.label5.Text = "Costo de flores por docena:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(37, 249);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(198, 25);
			this.label6.TabIndex = 16;
			this.label6.Text = "Número de personas:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(37, 291);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(238, 25);
			this.label7.TabIndex = 17;
			this.label7.Text = "Costo de alimentos por persona:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(37, 333);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(198, 25);
			this.label8.TabIndex = 18;
			this.label8.Text = "Costo del litro de agua:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(36, 399);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(238, 25);
			this.label9.TabIndex = 19;
			this.label9.Text = "Costo por hora de tiempo de diseño:";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(36, 443);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(238, 25);
			this.label10.TabIndex = 20;
			this.label10.Text = "Costo de mano de obra por persona:";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(36, 11);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(311, 23);
			this.label11.TabIndex = 21;
			this.label11.Text = "Una unidad de area requiere a un bulto, litro, kg, docena.";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(36, 376);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(186, 23);
			this.label12.TabIndex = 22;
			this.label12.Text = "tiempoDiseno * costoManoObra";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(492, 578);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.txtCostoManoObra);
			this.Controls.Add(this.txtTiempoDiseno);
			this.Controls.Add(this.txtCostoAgua);
			this.Controls.Add(this.txtCostoAlimentos);
			this.Controls.Add(this.txtNumPersonas);
			this.Controls.Add(this.txtCostoFlores);
			this.Controls.Add(this.txtCostoFrutosSecos);
			this.Controls.Add(this.txtCostoPintura);
			this.Controls.Add(this.txtCostoAserrin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.TextBox txtCostoManoObra;
		private System.Windows.Forms.TextBox txtTiempoDiseno;
		private System.Windows.Forms.TextBox txtCostoAgua;
		private System.Windows.Forms.TextBox txtCostoAlimentos;
		private System.Windows.Forms.TextBox txtNumPersonas;
		private System.Windows.Forms.TextBox txtCostoFlores;
		private System.Windows.Forms.TextBox txtCostoFrutosSecos;
		private System.Windows.Forms.TextBox txtCostoPintura;
		private System.Windows.Forms.TextBox txtCostoAserrin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.Label label1;
	}
}
