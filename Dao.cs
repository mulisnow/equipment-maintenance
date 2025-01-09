using System.Data.SqlClient;

namespace 设备维修预约系统
{
	internal class Dao
	{
		private SqlConnection sc;

		// 建立数据库连接
		public SqlConnection connect()
		{
			string str = @"Data Source=LAPTOP-QFEJ83MI;Initial Catalog=equipment_maintenance;Integrated Security=True";
			sc = new SqlConnection(str);
			sc.Open();
			return sc;
		}

		// 创建 SQL 命令对象
		public SqlCommand command(string sql)
		{
			if (sc == null)
			{
				connect();
			}
			SqlCommand cmd = new SqlCommand(sql, sc);
			return cmd;
		}

		// 执行 SQL 语句并返回受影响的行数
		public int Execute(string sql)
		{
			return command(sql).ExecuteNonQuery();
		}

		// 读取 SQL 查询结果
		public SqlDataReader read(string sql)
		{
			using (SqlCommand cmd = command(sql))
			{
				return cmd.ExecuteReader();
			}
		}

		// 关闭数据库连接
		public void Sqlclose()
		{
			if (sc != null && sc.State == System.Data.ConnectionState.Open)
			{
				sc.Close();
			}
		}
	}
}