namespace IRAC_19
{
	partial class frmLogin
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnEntrar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblVersao = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEntrar
			// 
			this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.Location = new System.Drawing.Point(57, 402);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(75, 35);
			this.btnEntrar.TabIndex = 3;
			this.btnEntrar.Text = "Acessar";
			this.btnEntrar.UseVisualStyleBackColor = true;
			this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(167, 402);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 35);
			this.btnSair.TabIndex = 4;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnaSair_Click);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(78, 308);
			this.txtUsuario.MaxLength = 10;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(185, 20);
			this.txtUsuario.TabIndex = 0;
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(4, 306);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(68, 20);
			this.lblUsuario.TabIndex = 4;
			this.lblUsuario.Text = "Usuário:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::IRAC_19.Properties.Resources.LOGIN;
			this.pictureBox1.Location = new System.Drawing.Point(7, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(272, 272);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(78, 344);
			this.txtSenha.MaxLength = 10;
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(185, 20);
			this.txtSenha.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 344);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Senha:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Enabled = false;
			this.label2.Location = new System.Drawing.Point(100, 460);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Versão:";
			// 
			// lblVersao
			// 
			this.lblVersao.AutoSize = true;
			this.lblVersao.Enabled = false;
			this.lblVersao.Location = new System.Drawing.Point(141, 460);
			this.lblVersao.Name = "lblVersao";
			this.lblVersao.Size = new System.Drawing.Size(40, 13);
			this.lblVersao.TabIndex = 10;
			this.lblVersao.Text = "Versao";
			this.lblVersao.Click += new System.EventHandler(this.lblVersao_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(288, 482);
			this.Controls.Add(this.lblVersao);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnEntrar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Logar no Sistema";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblUsuario;
		//private System.Windows.Forms.Label txtSenha;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblVersao;
	}
}

