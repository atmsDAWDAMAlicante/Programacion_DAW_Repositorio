﻿namespace Prog_Tema_2_Ej_05
	{
	partial class Prog_Tema_2_Ej_05
		{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
			{
			if (disposing && (components != null))
				{
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
			{
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.txtResulado = new System.Windows.Forms.TextBox();
			this.lblNum1 = new System.Windows.Forms.Label();
			this.lblNum2 = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSuma
			// 
			this.btnSuma.Location = new System.Drawing.Point(433, 38);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(177, 55);
			this.btnSuma.TabIndex = 4;
			this.btnSuma.Text = "Suma";
			this.btnSuma.UseVisualStyleBackColor = true;
			// 
			// btnResta
			// 
			this.btnResta.Location = new System.Drawing.Point(433, 131);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(177, 55);
			this.btnResta.TabIndex = 5;
			this.btnResta.Text = "Resta";
			this.btnResta.UseVisualStyleBackColor = true;
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(177, 32);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(154, 26);
			this.txtNum1.TabIndex = 1;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(177, 82);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(154, 26);
			this.txtNum2.TabIndex = 2;
			// 
			// txtResulado
			// 
			this.txtResulado.Location = new System.Drawing.Point(177, 176);
			this.txtResulado.Name = "txtResulado";
			this.txtResulado.Size = new System.Drawing.Size(154, 26);
			this.txtResulado.TabIndex = 3;
			// 
			// lblNum1
			// 
			this.lblNum1.AutoSize = true;
			this.lblNum1.Location = new System.Drawing.Point(56, 38);
			this.lblNum1.Name = "lblNum1";
			this.lblNum1.Size = new System.Drawing.Size(82, 20);
			this.lblNum1.TabIndex = 0;
			this.lblNum1.Text = "Número 1:";
			// 
			// lblNum2
			// 
			this.lblNum2.AutoSize = true;
			this.lblNum2.Location = new System.Drawing.Point(56, 88);
			this.lblNum2.Name = "lblNum2";
			this.lblNum2.Size = new System.Drawing.Size(82, 20);
			this.lblNum2.TabIndex = 0;
			this.lblNum2.Text = "Número 2:";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(56, 176);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(86, 20);
			this.lblResultado.TabIndex = 6;
			this.lblResultado.Text = "Resultado:";
			// 
			// Prog_Tema_2_Ej_05
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 242);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblNum2);
			this.Controls.Add(this.lblNum1);
			this.Controls.Add(this.txtResulado);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnSuma);
			this.Name = "Prog_Tema_2_Ej_05";
			this.Text = "Prog_Tema_2_Ej_05";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.TextBox txtResulado;
		private System.Windows.Forms.Label lblNum1;
		private System.Windows.Forms.Label lblNum2;
		private System.Windows.Forms.Label lblResultado;
		}
	}

