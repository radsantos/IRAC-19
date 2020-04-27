namespace IRAC_19
{
	partial class frmPaciente
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNomePaciente = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mktCPF = new System.Windows.Forms.MaskedTextBox();
			this.txtDateNacimento = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIdCod = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDateCadastro = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnConsultaPaciente = new System.Windows.Forms.Button();
			this.txtIdade = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtRG = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtUF = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.mktCelular = new System.Windows.Forms.MaskedTextBox();
			this.mktTelefone = new System.Windows.Forms.MaskedTextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtProfissao = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.rdbMaculino = new System.Windows.Forms.RadioButton();
			this.rdbFeminino = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdbConvencioSim = new System.Windows.Forms.RadioButton();
			this.rdbConvenioNao = new System.Windows.Forms.RadioButton();
			this.label17 = new System.Windows.Forms.Label();
			this.txtConvenio = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rdbSituacaoInativo = new System.Windows.Forms.RadioButton();
			this.rdbSituacaoAtivo = new System.Windows.Forms.RadioButton();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbFeminino);
			this.groupBox1.Controls.Add(this.rdbMaculino);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.txtProfissao);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.mktTelefone);
			this.groupBox1.Controls.Add(this.mktCelular);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtCidade);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtUF);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtBairro);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtNumero);
			this.groupBox1.Controls.Add(this.txtEndereco);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtRG);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtIdade);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtDateNacimento);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.mktCPF);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtNomePaciente);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 76);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(573, 291);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados do Paciente:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome:";
			// 
			// txtNomePaciente
			// 
			this.txtNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomePaciente.Location = new System.Drawing.Point(118, 26);
			this.txtNomePaciente.Name = "txtNomePaciente";
			this.txtNomePaciente.Size = new System.Drawing.Size(236, 22);
			this.txtNomePaciente.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(379, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "CPF:";
			// 
			// mktCPF
			// 
			this.mktCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mktCPF.Location = new System.Drawing.Point(431, 26);
			this.mktCPF.Mask = "000.000.000-00";
			this.mktCPF.Name = "mktCPF";
			this.mktCPF.Size = new System.Drawing.Size(136, 22);
			this.mktCPF.TabIndex = 2;
			// 
			// txtDateNacimento
			// 
			this.txtDateNacimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDateNacimento.Location = new System.Drawing.Point(118, 58);
			this.txtDateNacimento.Name = "txtDateNacimento";
			this.txtDateNacimento.Size = new System.Drawing.Size(98, 22);
			this.txtDateNacimento.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nacimento:";
			// 
			// txtIdCod
			// 
			this.txtIdCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdCod.Location = new System.Drawing.Point(23, 29);
			this.txtIdCod.Name = "txtIdCod";
			this.txtIdCod.Size = new System.Drawing.Size(61, 22);
			this.txtIdCod.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(23, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "Cód:";
			// 
			// txtDateCadastro
			// 
			this.txtDateCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDateCadastro.Location = new System.Drawing.Point(130, 29);
			this.txtDateCadastro.Name = "txtDateCadastro";
			this.txtDateCadastro.Size = new System.Drawing.Size(96, 22);
			this.txtDateCadastro.TabIndex = 30;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(130, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 16);
			this.label6.TabIndex = 29;
			this.label6.Text = "Cadastro:";
			// 
			// btnConsultaPaciente
			// 
			this.btnConsultaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultaPaciente.Location = new System.Drawing.Point(381, 29);
			this.btnConsultaPaciente.Name = "btnConsultaPaciente";
			this.btnConsultaPaciente.Size = new System.Drawing.Size(159, 23);
			this.btnConsultaPaciente.TabIndex = 31;
			this.btnConsultaPaciente.Text = "Consultar Paciente";
			this.btnConsultaPaciente.UseVisualStyleBackColor = true;
			// 
			// txtIdade
			// 
			this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdade.Location = new System.Drawing.Point(291, 61);
			this.txtIdade.Name = "txtIdade";
			this.txtIdade.Size = new System.Drawing.Size(63, 22);
			this.txtIdade.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(232, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Idade:";
			// 
			// txtRG
			// 
			this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRG.Location = new System.Drawing.Point(431, 61);
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(136, 22);
			this.txtRG.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(379, 67);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(34, 16);
			this.label8.TabIndex = 8;
			this.label8.Text = "RG:";
			// 
			// txtEndereco
			// 
			this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEndereco.Location = new System.Drawing.Point(118, 130);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(236, 22);
			this.txtEndereco.TabIndex = 11;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 136);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 16);
			this.label9.TabIndex = 10;
			this.label9.Text = "Endereço:";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(450, 130);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(117, 22);
			this.txtNumero.TabIndex = 12;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(409, 136);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 16);
			this.label10.TabIndex = 13;
			this.label10.Text = "Nº:";
			// 
			// txtBairro
			// 
			this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(118, 173);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(121, 22);
			this.txtBairro.TabIndex = 15;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 176);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(54, 16);
			this.label11.TabIndex = 14;
			this.label11.Text = "Bairro:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(250, 176);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 16);
			this.label12.TabIndex = 16;
			this.label12.Text = "UF:";
			// 
			// txtUF
			// 
			this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUF.Location = new System.Drawing.Point(291, 173);
			this.txtUF.Name = "txtUF";
			this.txtUF.Size = new System.Drawing.Size(63, 22);
			this.txtUF.TabIndex = 17;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(379, 179);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(62, 16);
			this.label13.TabIndex = 18;
			this.label13.Text = "Cidade:";
			// 
			// txtCidade
			// 
			this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(450, 176);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(117, 22);
			this.txtCidade.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 220);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 16);
			this.label4.TabIndex = 20;
			this.label4.Text = "Telefone:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(250, 223);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(35, 16);
			this.label14.TabIndex = 22;
			this.label14.Text = "Cel:";
			// 
			// mktCelular
			// 
			this.mktCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mktCelular.Location = new System.Drawing.Point(291, 214);
			this.mktCelular.Mask = "(99) 00000-0000";
			this.mktCelular.Name = "mktCelular";
			this.mktCelular.Size = new System.Drawing.Size(136, 22);
			this.mktCelular.TabIndex = 23;
			// 
			// mktTelefone
			// 
			this.mktTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mktTelefone.Location = new System.Drawing.Point(118, 214);
			this.mktTelefone.Mask = "(99) 0000-0000";
			this.mktTelefone.Name = "mktTelefone";
			this.mktTelefone.Size = new System.Drawing.Size(121, 22);
			this.mktTelefone.TabIndex = 24;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(8, 265);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(78, 16);
			this.label15.TabIndex = 25;
			this.label15.Text = "Profissão:";
			// 
			// txtProfissao
			// 
			this.txtProfissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProfissao.Location = new System.Drawing.Point(118, 259);
			this.txtProfissao.Name = "txtProfissao";
			this.txtProfissao.Size = new System.Drawing.Size(205, 22);
			this.txtProfissao.TabIndex = 26;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(8, 98);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(47, 16);
			this.label16.TabIndex = 27;
			this.label16.Text = "Sexo:";
			// 
			// rdbMaculino
			// 
			this.rdbMaculino.AutoSize = true;
			this.rdbMaculino.Location = new System.Drawing.Point(130, 98);
			this.rdbMaculino.Name = "rdbMaculino";
			this.rdbMaculino.Size = new System.Drawing.Size(88, 20);
			this.rdbMaculino.TabIndex = 28;
			this.rdbMaculino.TabStop = true;
			this.rdbMaculino.Text = "Maculino";
			this.rdbMaculino.UseVisualStyleBackColor = true;
			// 
			// rdbFeminino
			// 
			this.rdbFeminino.AutoSize = true;
			this.rdbFeminino.Location = new System.Drawing.Point(241, 98);
			this.rdbFeminino.Name = "rdbFeminino";
			this.rdbFeminino.Size = new System.Drawing.Size(89, 20);
			this.rdbFeminino.TabIndex = 29;
			this.rdbFeminino.TabStop = true;
			this.rdbFeminino.Text = "Feminino";
			this.rdbFeminino.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtConvenio);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.rdbConvenioNao);
			this.groupBox2.Controls.Add(this.rdbConvencioSim);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 389);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(323, 153);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Convêncio Médico:";
			// 
			// rdbConvencioSim
			// 
			this.rdbConvencioSim.AutoSize = true;
			this.rdbConvencioSim.Checked = true;
			this.rdbConvencioSim.Location = new System.Drawing.Point(14, 35);
			this.rdbConvencioSim.Name = "rdbConvencioSim";
			this.rdbConvencioSim.Size = new System.Drawing.Size(55, 22);
			this.rdbConvencioSim.TabIndex = 0;
			this.rdbConvencioSim.TabStop = true;
			this.rdbConvencioSim.Text = "Sim";
			this.rdbConvencioSim.UseVisualStyleBackColor = true;
			// 
			// rdbConvenioNao
			// 
			this.rdbConvenioNao.AutoSize = true;
			this.rdbConvenioNao.Location = new System.Drawing.Point(157, 35);
			this.rdbConvenioNao.Name = "rdbConvenioNao";
			this.rdbConvenioNao.Size = new System.Drawing.Size(57, 22);
			this.rdbConvenioNao.TabIndex = 1;
			this.rdbConvenioNao.Text = "Não";
			this.rdbConvenioNao.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(6, 98);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(84, 18);
			this.label17.TabIndex = 30;
			this.label17.Text = "Convênio:";
			// 
			// txtConvenio
			// 
			this.txtConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConvenio.Location = new System.Drawing.Point(96, 92);
			this.txtConvenio.Name = "txtConvenio";
			this.txtConvenio.Size = new System.Drawing.Size(205, 24);
			this.txtConvenio.TabIndex = 30;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rdbSituacaoInativo);
			this.groupBox3.Controls.Add(this.rdbSituacaoAtivo);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(341, 389);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(238, 153);
			this.groupBox3.TabIndex = 33;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Situção do Convênio:";
			// 
			// rdbSituacaoInativo
			// 
			this.rdbSituacaoInativo.AutoSize = true;
			this.rdbSituacaoInativo.Location = new System.Drawing.Point(157, 35);
			this.rdbSituacaoInativo.Name = "rdbSituacaoInativo";
			this.rdbSituacaoInativo.Size = new System.Drawing.Size(75, 22);
			this.rdbSituacaoInativo.TabIndex = 1;
			this.rdbSituacaoInativo.Text = "Inativo";
			this.rdbSituacaoInativo.UseVisualStyleBackColor = true;
			// 
			// rdbSituacaoAtivo
			// 
			this.rdbSituacaoAtivo.AutoSize = true;
			this.rdbSituacaoAtivo.Checked = true;
			this.rdbSituacaoAtivo.Location = new System.Drawing.Point(14, 35);
			this.rdbSituacaoAtivo.Name = "rdbSituacaoAtivo";
			this.rdbSituacaoAtivo.Size = new System.Drawing.Size(63, 22);
			this.rdbSituacaoAtivo.TabIndex = 0;
			this.rdbSituacaoAtivo.TabStop = true;
			this.rdbSituacaoAtivo.Text = "Ativo";
			this.rdbSituacaoAtivo.UseVisualStyleBackColor = true;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(108, 566);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 34;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(318, 566);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 35;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(424, 566);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 36;
			this.btnCancelar.Text = "Sair";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnNovo
			// 
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.Location = new System.Drawing.Point(219, 566);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 23);
			this.btnNovo.TabIndex = 37;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			// 
			// frmPaciente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 604);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnConsultaPaciente);
			this.Controls.Add(this.txtDateCadastro);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtIdCod);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPaciente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Paciente";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtProfissao;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.MaskedTextBox mktTelefone;
		private System.Windows.Forms.MaskedTextBox mktCelular;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtUF;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtRG;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtIdade;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDateNacimento;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox mktCPF;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNomePaciente;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIdCod;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDateCadastro;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnConsultaPaciente;
		private System.Windows.Forms.RadioButton rdbFeminino;
		private System.Windows.Forms.RadioButton rdbMaculino;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtConvenio;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.RadioButton rdbConvenioNao;
		private System.Windows.Forms.RadioButton rdbConvencioSim;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rdbSituacaoInativo;
		private System.Windows.Forms.RadioButton rdbSituacaoAtivo;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnNovo;
	}
}