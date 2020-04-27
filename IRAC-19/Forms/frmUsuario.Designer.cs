namespace IRAC_19
{
	partial class frmUsuario
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.bntSair = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCadUserBusca = new System.Windows.Forms.TextBox();
			this.btnCadUserBusca = new System.Windows.Forms.Button();
			this.cbCadUserFiltro = new System.Windows.Forms.ComboBox();
			this.dtgCadUsuario = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCadUserUsuario = new System.Windows.Forms.TextBox();
			this.txtCadUserSenha = new System.Windows.Forms.TextBox();
			this.cbCadUserPerfil = new System.Windows.Forms.ComboBox();
			this.txtCadUserCod = new System.Windows.Forms.TextBox();
			this.btnListar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgCadUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNovo
			// 
			this.btnNovo.Location = new System.Drawing.Point(442, 31);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 23);
			this.btnNovo.TabIndex = 3;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(70, 440);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 23);
			this.btnEditar.TabIndex = 1;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(190, 440);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 3;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// bntSair
			// 
			this.bntSair.Location = new System.Drawing.Point(415, 440);
			this.bntSair.Name = "bntSair";
			this.bntSair.Size = new System.Drawing.Size(75, 23);
			this.bntSair.TabIndex = 4;
			this.bntSair.Text = "Sair";
			this.bntSair.UseVisualStyleBackColor = true;
			this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCadUserBusca);
			this.groupBox1.Controls.Add(this.btnCadUserBusca);
			this.groupBox1.Controls.Add(this.cbCadUserFiltro);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 151);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(566, 61);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtar Por:";
			// 
			// txtCadUserBusca
			// 
			this.txtCadUserBusca.Location = new System.Drawing.Point(153, 19);
			this.txtCadUserBusca.Name = "txtCadUserBusca";
			this.txtCadUserBusca.Size = new System.Drawing.Size(226, 22);
			this.txtCadUserBusca.TabIndex = 2;
			// 
			// btnCadUserBusca
			// 
			this.btnCadUserBusca.Location = new System.Drawing.Point(446, 18);
			this.btnCadUserBusca.Name = "btnCadUserBusca";
			this.btnCadUserBusca.Size = new System.Drawing.Size(75, 23);
			this.btnCadUserBusca.TabIndex = 1;
			this.btnCadUserBusca.Text = "Buscar";
			this.btnCadUserBusca.UseVisualStyleBackColor = true;
			this.btnCadUserBusca.Click += new System.EventHandler(this.btnCadUserBusca_Click);
			// 
			// cbCadUserFiltro
			// 
			this.cbCadUserFiltro.FormattingEnabled = true;
			this.cbCadUserFiltro.Items.AddRange(new object[] {
            "Nome",
            "Matricula"});
			this.cbCadUserFiltro.Location = new System.Drawing.Point(6, 19);
			this.cbCadUserFiltro.Name = "cbCadUserFiltro";
			this.cbCadUserFiltro.Size = new System.Drawing.Size(121, 24);
			this.cbCadUserFiltro.TabIndex = 0;
			// 
			// dtgCadUsuario
			// 
			this.dtgCadUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgCadUsuario.Location = new System.Drawing.Point(12, 218);
			this.dtgCadUsuario.Name = "dtgCadUsuario";
			this.dtgCadUsuario.ReadOnly = true;
			this.dtgCadUsuario.Size = new System.Drawing.Size(566, 198);
			this.dtgCadUsuario.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Cód:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Usuário:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Senha:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Perfil";
			// 
			// txtCadUserUsuario
			// 
			this.txtCadUserUsuario.Location = new System.Drawing.Point(70, 36);
			this.txtCadUserUsuario.Name = "txtCadUserUsuario";
			this.txtCadUserUsuario.Size = new System.Drawing.Size(125, 20);
			this.txtCadUserUsuario.TabIndex = 0;
			// 
			// txtCadUserSenha
			// 
			this.txtCadUserSenha.Location = new System.Drawing.Point(70, 73);
			this.txtCadUserSenha.Name = "txtCadUserSenha";
			this.txtCadUserSenha.Size = new System.Drawing.Size(125, 20);
			this.txtCadUserSenha.TabIndex = 1;
			// 
			// cbCadUserPerfil
			// 
			this.cbCadUserPerfil.FormattingEnabled = true;
			this.cbCadUserPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Recpcao",
            "Consultorio"});
			this.cbCadUserPerfil.Location = new System.Drawing.Point(70, 112);
			this.cbCadUserPerfil.Name = "cbCadUserPerfil";
			this.cbCadUserPerfil.Size = new System.Drawing.Size(121, 21);
			this.cbCadUserPerfil.TabIndex = 2;
			// 
			// txtCadUserCod
			// 
			this.txtCadUserCod.Location = new System.Drawing.Point(70, 6);
			this.txtCadUserCod.Name = "txtCadUserCod";
			this.txtCadUserCod.ReadOnly = true;
			this.txtCadUserCod.Size = new System.Drawing.Size(69, 20);
			this.txtCadUserCod.TabIndex = 13;
			// 
			// btnListar
			// 
			this.btnListar.Location = new System.Drawing.Point(306, 440);
			this.btnListar.Name = "btnListar";
			this.btnListar.Size = new System.Drawing.Size(75, 23);
			this.btnListar.TabIndex = 14;
			this.btnListar.Text = "Listar";
			this.btnListar.UseVisualStyleBackColor = true;
			this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
			// 
			// frmUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 475);
			this.Controls.Add(this.btnListar);
			this.Controls.Add(this.txtCadUserCod);
			this.Controls.Add(this.cbCadUserPerfil);
			this.Controls.Add(this.txtCadUserSenha);
			this.Controls.Add(this.txtCadUserUsuario);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtgCadUsuario);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.bntSair);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnNovo);
			this.Name = "frmUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Usuário";
			this.Load += new System.EventHandler(this.frmUsuario_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgCadUsuario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button bntSair;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbCadUserFiltro;
		private System.Windows.Forms.TextBox txtCadUserBusca;
		private System.Windows.Forms.Button btnCadUserBusca;
		private System.Windows.Forms.DataGridView dtgCadUsuario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCadUserUsuario;
		private System.Windows.Forms.TextBox txtCadUserSenha;
		private System.Windows.Forms.ComboBox cbCadUserPerfil;
		private System.Windows.Forms.TextBox txtCadUserCod;
		private System.Windows.Forms.Button btnListar;
	}
}