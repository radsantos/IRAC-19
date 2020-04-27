using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRAC_19.Classes
{
	public class Conexao
	{
		SqlConnection con = new SqlConnection();

		//Contrutor
		public Conexao() 
		{
			con.ConnectionString = @"Data Source=DESKTOP-CL9A8O6\SQLEXPRESS;Initial Catalog=IRAC;Integrated Security=True";



		}

		//Metodo Conextar
		public SqlConnection conectar() 
		{
			//vaerficando se a conexão do DB esta fechado, caso sim ele abri
			if(con.State == System.Data.ConnectionState.Closed)
			{
				con.Open();
			}
			
			return con;

		}

		//Metodo Desconectar
		public void desconetar()
		{
			//Se a conexão estive aberto. Fecha a conexão
			if (con.State == System.Data.ConnectionState.Open)
			{
				con.Close();
			}




		}




	}
}
