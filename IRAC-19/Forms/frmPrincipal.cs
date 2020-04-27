using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRAC_19
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void inserirParcienteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPaciente frmPaciente = new frmPaciente();
			frmPaciente.ShowDialog();
		}

		private void inserirMédicoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCadastroMedico frmCadastroMedico = new frmCadastroMedico();
			frmCadastroMedico.ShowDialog();
		}

		private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmUsuario Usuariofrm = new frmUsuario();
			Usuariofrm.ShowDialog();
		}
	}
}
