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
	public partial class admin3_1 : Form
	{
		public admin3_1()
		{
			InitializeComponent();
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
				string sql = $"insert into MaintenanceWorker values('{textBox1.Text}','{textBox2.Text}'" +
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

		private void button2_Click(object sender, EventArgs e)
		{
			admin3 admin3 = new admin3();
			this.Hide();
			admin3.Show();
			this.Show();
		}

		private void admin3_1_Load(object sender, EventArgs e)
		{

		}
	}
}
