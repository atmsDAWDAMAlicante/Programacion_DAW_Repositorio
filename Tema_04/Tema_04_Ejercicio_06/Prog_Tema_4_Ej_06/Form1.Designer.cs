﻿namespace Prog_Tema_4_Ej_06_
{
    partial class Prog_Tema_4_Ej_06
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.btnAccion = new System.Windows.Forms.Button();
			this.lblTitulo1 = new System.Windows.Forms.Label();
			this.lblTitulo2 = new System.Windows.Forms.Label();
			this.lblResultadoDivision = new System.Windows.Forms.Label();
			this.lblResto = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
			this.lblTitulo.Location = new System.Drawing.Point(19, 25);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(428, 40);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ƒ División entera y resto";
			// 
			// txtNumero1
			// 
			this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero1.ForeColor = System.Drawing.Color.Navy;
			this.txtNumero1.Location = new System.Drawing.Point(31, 90);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(119, 35);
			this.txtNumero1.TabIndex = 1;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero2.ForeColor = System.Drawing.Color.Navy;
			this.txtNumero2.Location = new System.Drawing.Point(328, 90);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(119, 35);
			this.txtNumero2.TabIndex = 2;
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.Navy;
			this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.ForeColor = System.Drawing.Color.White;
			this.btnAccion.Location = new System.Drawing.Point(175, 84);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(129, 52);
			this.btnAccion.TabIndex = 3;
			this.btnAccion.Text = "Acción";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// lblTitulo1
			// 
			this.lblTitulo1.AutoSize = true;
			this.lblTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo1.ForeColor = System.Drawing.Color.Navy;
			this.lblTitulo1.Location = new System.Drawing.Point(27, 175);
			this.lblTitulo1.Name = "lblTitulo1";
			this.lblTitulo1.Size = new System.Drawing.Size(248, 70);
			this.lblTitulo1.TabIndex = 0;
			this.lblTitulo1.Text = "El resultado de la\ndivisión entera es:";
			// 
			// lblTitulo2
			// 
			this.lblTitulo2.AutoSize = true;
			this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo2.ForeColor = System.Drawing.Color.Navy;
			this.lblTitulo2.Location = new System.Drawing.Point(27, 293);
			this.lblTitulo2.Name = "lblTitulo2";
			this.lblTitulo2.Size = new System.Drawing.Size(160, 35);
			this.lblTitulo2.TabIndex = 0;
			this.lblTitulo2.Text = "El resto es:";
			// 
			// lblResultadoDivision
			// 
			this.lblResultadoDivision.AutoSize = true;
			this.lblResultadoDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultadoDivision.ForeColor = System.Drawing.Color.Navy;
			this.lblResultadoDivision.Location = new System.Drawing.Point(260, 205);
			this.lblResultadoDivision.Name = "lblResultadoDivision";
			this.lblResultadoDivision.Size = new System.Drawing.Size(31, 29);
			this.lblResultadoDivision.TabIndex = 0;
			this.lblResultadoDivision.Text = "...";
			// 
			// lblResto
			// 
			this.lblResto.AutoSize = true;
			this.lblResto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResto.ForeColor = System.Drawing.Color.Navy;
			this.lblResto.Location = new System.Drawing.Point(183, 294);
			this.lblResto.Name = "lblResto";
			this.lblResto.Size = new System.Drawing.Size(31, 29);
			this.lblResto.TabIndex = 0;
			this.lblResto.Text = "...";
			// 
			// Prog_Tema_4_Ej_06_
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(506, 369);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblResto);
			this.Controls.Add(this.lblResultadoDivision);
			this.Controls.Add(this.lblTitulo2);
			this.Controls.Add(this.lblTitulo1);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Name = "Prog_Tema_4_Ej_06";
			this.Text = "Prog_Tema_4_Ej_06";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblResultadoDivision;
        private System.Windows.Forms.Label lblResto;
		}
}

