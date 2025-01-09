using System;
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
	public partial class admin2_1 : Form
	{
		public admin2_1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || textBox5.Text == "" || textBox6.Text == "")
			{

				MessageBox.Show("请填写完整信息！");
				
			}
			else
			{

				Dao dao = new Dao();
				string sql = $"insert into Customer values('{textBox1.Text}','{textBox2.Text}'" +
					$",'{textBox3.Text}','{comboBox1.Text}','{textBox5.Text}','{textBox6.Text}')";
				int n = dao.Execute(sql);
				if (n > 0)
				{

					MessageBox.Show("添加成功！");

				}
				else
				{

					MessageBox.Show("添加失败！");
				}
				textBox1.Text = "";
				textBox2.Text = "";
				textBox3.Text = "";
				textBox5.Text = "";
				textBox6.Text = "";
				comboBox1.Text = "";
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			admin2 admin2 = new admin2();
			this.Hide();
			admin2.Show();
			this.Show();
		}

		private void admin2_1_Load(object sender, EventArgs e)
		{

		}

		
	}
}
