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
	public partial class admin2_2 : Form
	{
		string ID = "";
		public admin2_2()
		{
			InitializeComponent();
		}
		public admin2_2(string id, string name, string pwd, string sex, string phone, string adress)
		{
			InitializeComponent();
			ID=textBox1.Text = id;
			textBox2.Text = name;
			textBox3.Text = pwd;
			comboBox1.Text = sex;
			textBox5.Text = phone;
			textBox6.Text = adress;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string sql = $"update Customer set CustomerID='{textBox1.Text}',[CustomerName]='{textBox2.Text}',Password='{textBox3.Text}'," +
								$"Gender='{comboBox1.Text}',PhoneNumber='{textBox5.Text}',Address='{textBox6.Text}' where  CustomerID='{ID}'";
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

		private void admin2_2_Load(object sender, EventArgs e)
		{

		}
	}

	}

