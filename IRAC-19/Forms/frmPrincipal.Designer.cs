namespace IRAC_19
{
	partial class frmPrincipal
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inserirParcienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inserirMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadastrarToolStripMenuItem
			// 
			this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirParcienteToolStripMenuItem,
            this.inserirMédicoToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
			this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
			this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.cadastrarToolStripMenuItem.Text = "Cadastrar";
			// 
			// inserirParcienteToolStripMenuItem
			// 
			this.inserirParcienteToolStripMenuItem.Name = "inserirParcienteToolStripMenuItem";
			this.inserirParcienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.inserirParcienteToolStripMenuItem.Text = "Paciente";
			this.inserirParcienteToolStripMenuItem.Click += new System.EventHandler(this.inserirParcienteToolStripMenuItem_Click);
			// 
			// inserirMédicoToolStripMenuItem
			// 
			this.inserirMédicoToolStripMenuItem.Name = "inserirMédicoToolStripMenuItem";
			this.inserirMédicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.inserirMédicoToolStripMenuItem.Text = "Médico";
			this.inserirMédicoToolStripMenuItem.Click += new System.EventHandler(this.inserirMédicoToolStripMenuItem_Click);
			// 
			// usuáriosToolStripMenuItem
			// 
			this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
			this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.usuáriosToolStripMenuItem.Text = "Usuários";
			this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::IRAC_19.Properties.Resources.BACK_GROUND;
			this.pictureBox1.Location = new System.Drawing.Point(0, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(800, 426);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "frmPrincipal";
			this.RightToLeftLayout = true;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IRAC-19";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inserirParcienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inserirMédicoToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
	}
}