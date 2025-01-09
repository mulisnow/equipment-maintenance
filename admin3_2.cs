using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 设备维修预约系统
{
	public partial class admin3_2 : Form
	{
		public admin3_2()
		{
			InitializeComponent();
		}
		string ID = "";

		public admin3_2(string id, string name, string pwd, string sex, string phone, string exp)
		{
			InitializeComponent();
			ID = textBox1.Text = id;
			textBox2.Text = name;
			textBox3.Text = pwd;
			comboBox1.Text = sex;
			textBox5.Text = phone;
			textBox6.Text = exp;

		}
		private void admin3_2cs_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string sql = $"update MaintenanceAppointment set CustomerID='{textBox1.Text}',[EquipmentID]='{textBox2.Text}',FaultDescription='{textBox3.Text}'," +
													$"WorkerID='{textBox5.Text}',AppointmentStatus='{comboBox1.Text}' where  CustomerID='{ID}'";
			Dao dao = new Dao();
			if (dao.Execute(sql) > 0)
			{

				MessageBox.Show("修改成功！");
				this.Close();
			}
			else
			{

				MessageBox.Show("修改失败！");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
