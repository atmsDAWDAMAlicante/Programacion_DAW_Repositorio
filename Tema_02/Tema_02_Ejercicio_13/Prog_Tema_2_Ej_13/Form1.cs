﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_13
	{
	public partial class Prog_Tema_2_Ej_13 : Form
		{
		public Prog_Tema_2_Ej_13()
			{
			InitializeComponent();
			}

		private void btnCalcular_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "Resultado:\n";
			try
				{
				double horas = 0;
				}
			catch (FormatException) 
				{
				MessageBox.Show("Introduzca números");
				}
			}
		}
	}
