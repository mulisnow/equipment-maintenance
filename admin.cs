﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 设备维修预约系统
{
	public partial class admin : Form
	{
		public admin()
		{
			InitializeComponent();
		}

		private void admin_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			admin2 admin2 = new admin2();
			this.Hide();
			admin2.ShowDialog();
			this.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			admin3 admin3 = new admin3();
			this.Hide();
			admin3.ShowDialog();
			this.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			admin4 admin3 = new admin4();
			this.Hide();
			admin3.ShowDialog();
			this.Show();
		}
	}
}
