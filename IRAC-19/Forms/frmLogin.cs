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
using System.Data.Sql;



namespace IRAC_19
{
	public partial class frmLogin : Form
	{
		private const bool V = false;
		SqlConnection sqlconn = null;
		private string strCoon =@"Data Source=DESKTOP-CL9A8O6\SQLEXPRESS;Initial Catalog=IRAC;Integrated Security=True";
		private string _Sql = string.Empty;

		public bool logado = V;

		public frmLogin()
		{
			InitializeComponent();
		}
		public void logar()
		{
			sqlconn = new SqlConnection(strCoon);
			string user, pwd;
			try
			{
				user = txtUsuario.Text;
				pwd = txtSenha.Text;

				_Sql = "select  count(Id) from tblUsuario where Nome = @Nome and Senha = @Senha";
				SqlCommand cmd = new SqlCommand(_Sql,sqlconn);

				cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = user;
				cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = pwd;

				sqlconn.Open();

				int verdade = (int)cmd.ExecuteScalar();
				if(verdade > 0)
				{
					
					logado = true;
				}
				else
				{
					MessageBox.Show("Erro ao Logar");
					logado = false;
				}
			}
			catch (SqlException erro)
			{
				MessageBox.Show(erro + "Erro no Banco");
				Application.Exit();
			}
		}

		private void BtnaSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnEntrar_Click(object sender, EventArgs e)
		{
			
				logar();
				this.Hide();
				frmPrincipal frmPrincipal = new frmPrincipal();
				frmPrincipal.Show();
			
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			lblVersao.Text = " " + Application.ProductVersion;
		}

		private void lblVersao_Click(object sender, EventArgs e)
		{
			//lblVersao.Text = " " + Application.ProductVersion;
			
		}

		
	}
}
