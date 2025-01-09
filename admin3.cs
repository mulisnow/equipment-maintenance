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
	public partial class admin3 : Form
	{
		public admin3()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void admin3_Load(object sender, EventArgs e)
		{
			Worker();
		}
		//从数据库读取数据
		public void Worker()
		{
			dataGridView1.Rows.Clear();
			Dao dao = new Dao();
			string sql = "select * from MaintenanceWorker";
			IDataReader dc = dao.read(sql);
			while (dc.Read())
			{

				int index = dataGridView1.Rows.Add();
				dataGridView1.Rows[index].Cells[0].Value = dc["WorkerID"].ToString();
				dataGridView1.Rows[index].Cells[1].Value = dc["WorkerName"].ToString();
				dataGridView1.Rows[index].Cells[2].Value = dc["Password"].ToString();
				dataGridView1.Rows[index].Cells[3].Value = dc["Gender"].ToString();
				dataGridView1.Rows[index].Cells[4].Value = dc["PhoneNumber"].ToString();
				dataGridView1.Rows[index].Cells[5].Value = dc["Expertise"].ToString();
			}
			dc.Close();
			dao.Sqlclose();
		}

		private void button3_Click(object sender, EventArgs e)
		{
	
		}

	


		private void button2_Click_1(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dr == DialogResult.OK)
			{

				Dao dao = new Dao();
				string sql = $"delete from MaintenanceWorker where WorkerID='{dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}'";
				int n = dao.Execute(sql);
				if (n > 0)
				{

					MessageBox.Show("删除成功！");
					Worker();
				}
				else
				{

					MessageBox.Show("删除失败！" + sql);
				}
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			admin3_1 admin3_1 = new admin3_1();
			this.Hide();
			admin3_1.Show();
			this.Show();
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			string pwd = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			string sex = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			string phone = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			string adress = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
			admin3_2 admin3_2 = new admin3_2(id, name, pwd, sex, phone, adress);
			admin3_2.ShowDialog();
			Worker();
		}
	}
}
