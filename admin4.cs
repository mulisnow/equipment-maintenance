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
	public partial class admin4 : Form
	{
		public admin4()
		{
			InitializeComponent();
		}

		private void admin4_Load(object sender, EventArgs e)
		{
			Equipment();
		}
		public void Equipment()
		{
			dataGridView1.Rows.Clear();
			Dao dao = new Dao();
			string sql = "select * from MaintenanceAppointment";
			IDataReader dc = dao.read(sql);
			while (dc.Read())
			{

				int index = dataGridView1.Rows.Add();
				dataGridView1.Rows[index].Cells[0].Value = dc["CustomerID"].ToString();
				dataGridView1.Rows[index].Cells[1].Value = dc["EquipmentID"].ToString();
				dataGridView1.Rows[index].Cells[2].Value = dc["FaultDescription"].ToString();
				dataGridView1.Rows[index].Cells[3].Value = dc["WorkerID"].ToString();
				dataGridView1.Rows[index].Cells[4].Value = dc["AppointmentStatus"].ToString();
				//dataGridView1.Rows[index].Cells[5].Value = dc["AppointmentStatus"].ToString();
			}
			dc.Close();
			dao.Sqlclose();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			admin4_1 admin4_1 = new admin4_1();
			this.Hide();
			admin4_1.ShowDialog();
			this.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string id1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			string id2= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			string FaultDescription = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			string id3 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			string As = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
		
			admin4_2 admin2_2 = new admin4_2(id1,id2,FaultDescription,id3,  As);
			admin2_2.ShowDialog();
			Equipment();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dr == DialogResult.OK)
			{

				Dao dao = new Dao();
				string sql = $"delete from MaintenanceAppointment where CustomerID='{dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}'";
				int n = dao.Execute(sql);
				if (n > 0)
				{

					MessageBox.Show("删除成功！");
					Equipment();
				}
				else
				{

					MessageBox.Show("删除失败！" + sql);
				}
			}
		}
		public void Customer()
		{
			dataGridView1.Rows.Clear();
			Dao dao = new Dao();
			string sql = "select * from MaintenanceAppointment where CustomerID='{textBox1.Text}'";
			IDataReader dc = dao.read(sql);
			while (dc.Read())
			{
				
				int index = dataGridView1.Rows.Add();
				dataGridView1.Rows[index].Cells[0].Value = dc["CustomerID"].ToString();
				dataGridView1.Rows[index].Cells[1].Value = dc["EquipmentID"].ToString();
				dataGridView1.Rows[index].Cells[2].Value = dc["FaultDescription"].ToString();
				dataGridView1.Rows[index].Cells[3].Value = dc["WorkerID"].ToString();
				dataGridView1.Rows[index].Cells[4].Value = dc["AppointmentStatus"].ToString();
				//dataGridView1.Rows[index].Cells[5].Value = dc["AppointmentStatus"].ToString();
			}
		
		}
		private void button5_Click(object sender, EventArgs e)
		{
			Customer();

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
