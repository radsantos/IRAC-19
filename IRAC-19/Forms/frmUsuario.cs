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
using IRAC_19.Classes;

namespace IRAC_19
{
	public partial class frmUsuario : Form
	{
		private string strcon = @"Data Source=DESKTOP-CL9A8O6\SQLEXPRESS;Initial Catalog=IRAC;Integrated Security=True";
		SqlConnection objConect = null;
		SqlCommand objCommand = null;

		public frmUsuario()
		{
			InitializeComponent();
		}

		private void btnCadUserBusca_Click(object sender, EventArgs e)
		{
			
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			SqlCommand comm = new SqlCommand();
			comm.Connection = Banco.abrir();

			comm.CommandText = "insert into tblUsuario  values ('"+txtCadUserUsuario.Text+"','"+txtCadUserSenha.Text+"','"+cbCadUserPerfil.SelectedItem+"')";
			comm.ExecuteNonQuery(); // grava registro na tabela

			// pegando o valor que foi gravado no campo Id como key primary
			comm.CommandText = "select @@identity";

			txtCadUserCod.Text = comm.ExecuteScalar().ToString();

			comm.Connection.Close();

			
			txtCadUserUsuario.Text = "";
			txtCadUserSenha.Text = "";
			txtCadUserUsuario.Focus();

			MessageBox.Show("Usuário gravado!");
		}

		private void bntSair_Click(object sender, EventArgs e)
		{
			//DialogResult dialog = DialogResult();
			if (MessageBox.Show("Deseja Sair?", "CONFIRMAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
			{
				this.Close();
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			



		}

		private void frmUsuario_Load(object sender, EventArgs e)
		{

		}

		private void btnListar_Click(object sender, EventArgs e)
		{
			listaGrid();
		}
		public void listaGrid()
		{
			string strSQL = "select Nome, Perfil from tblUsuario ";

			
			objConect = new SqlConnection(strcon);
			objCommand = new SqlCommand(strSQL, objConect);

			try
			{
				SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
				DataTable dtLista = new DataTable();

				objAdp.Fill(dtLista);
				dtgCadUsuario.DataSource = dtLista;


			}

			catch
			{
				MessageBox.Show("Deu erro");
			}
			

		}

	}
}
