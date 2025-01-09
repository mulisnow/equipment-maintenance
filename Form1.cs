using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 设备维修预约系统
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "")
			{
			
				MessageBox.Show("请输入用户名和密码！");
			}
			else
			{
			
				Login();
			}
		}
		public void Login()
		{
			if (radioButton1.Checked==true)
			{
				Dao dao = new Dao();
				string sql = "select * from Customer where CustomerID='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
				IDataReader dc = dao.read(sql);
				if (dc.Read())
				{
					Data.Uid = dc["CustomerID"].ToString();
					Data.Uname = dc["CustomerName"].ToString();
					MessageBox.Show("登录成功！");
					User user =new User();
					this.Hide();
					user.ShowDialog();
					this.Show();
				}
				else
				{
					MessageBox.Show("登录失败！");
					
				}
			
			}
			if (radioButton2.Checked == true)
			{
			
							Dao dao = new Dao();
							string sql = "select * from MaintenanceWorker where WorkerID='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
							IDataReader dc = dao.read(sql);
							if (dc.Read())
								{
					Data.Wid = dc["WorkerID"].ToString();
					Data.Wname = dc["WorkerName"].ToString();
					MessageBox.Show("登录成功！");
					worker wk = new worker();
					this.Hide();
					wk.ShowDialog();
					this.Show();

				}
							else
								{
				
									MessageBox.Show("登录失败！");
									
								}
							dao.Sqlclose();
			}
			if	(radioButton3.Checked == true)
			{
			
							Dao dao = new Dao();
							string sql = $"select * from Administrator where AdministratorID='{textBox1.Text}' and  Password='{textBox2.Text}'";
							IDataReader dc = dao.read(sql);
							if (dc.Read())
							{
			
									MessageBox.Show("登录成功！");
				
					admin ad = new admin();
					this.Hide();
					ad.ShowDialog();
					this.Show();
				}
								else
								{
				
									MessageBox.Show("登录失败！");
								
								}
							dao.Sqlclose();
			}
		
		}

		private void button2_Click(object sender, EventArgs e)
		{
			注册 vu = new 注册();
			this.Hide();
			vu.ShowDialog();
			this.Show();
		}
	}
}
