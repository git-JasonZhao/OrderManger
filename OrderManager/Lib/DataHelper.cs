using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace OrderManager.Lib
{
	public class DataHelper
	{
		public static string ConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}/OrderManger.accdb", AppDomain.CurrentDomain.BaseDirectory);

		public static DataTable GetData(string sql, string connstr = null)
		{
			if (string.IsNullOrWhiteSpace(connstr))
			{
				connstr = ConnectionString;
			}
			DataTable result = new DataTable();
			using (OleDbConnection conn = new OleDbConnection(connstr))
			{
				var cmd = conn.CreateCommand();
				cmd.CommandText = sql;
				var adp = new OleDbDataAdapter(cmd);
				adp.Fill(result);
			}
			return result;
		}
	}
}
