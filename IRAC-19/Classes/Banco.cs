using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IRAC_19.Classes
{
	public static class Banco
	{
		public static SqlConnection abrir()
		{
			string strcon = @"Data Source=DESKTOP-CL9A8O6\SQLEXPRESS;Initial Catalog=IRAC;Integrated Security=True";
			SqlConnection cn = new SqlConnection(strcon);
			cn.Open();
			return cn;

		}


	}
}
