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

	public partial class admin4_2 : Form
	{
		string ID = "";
		public admin4_2()
		{
			InitializeComponent();
		}
		public admin4_2(string id1, string id2, string FaultDescription, string id3, string As)
		{
			InitializeComponent();
			ID = textBox1.Text = id1;
			textBox2.Text = id2;
			textBox3.Text = FaultDescription;
			textBox5.Text = id3;
			comboBox1.Text = As;
		

		}
		private void button1_Click(object sender, EventArgs e)
		{
			string sql = $"update  Customer set CustomerID='{textBox1.Text}',[EquipmentID]='{textBox2.Text}',FaultDescription'{textBox3.Text}'," +
								$"WorkerID='{textBox5.Text}',AppointmentStatus='{comboBox1.Text}',where  CustomerID='{ID}'";
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

		private void admin4_2_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			admin4 admin = new admin4();
		
			this.Hide();
			admin.ShowDialog();
			this.Show();
		}

		private void admin4_2_Load_1(object sender, EventArgs e)
		{

		}
	}
}
