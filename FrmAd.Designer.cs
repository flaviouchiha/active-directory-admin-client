namespace PShell
{
    partial class FrmAd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCriado = new System.Windows.Forms.TextBox();
            this.txtModificado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTrocaSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSenhaExp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAtivo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBloqueado = new System.Windows.Forms.TextBox();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtOU = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioExternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosAtivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosInativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosPorLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosPorGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordNeverExpiresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNome.Location = new System.Drawing.Point(93, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(317, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(15, 271);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(50, 48);
            this.btnOK.TabIndex = 1;
            this.btnOK.Tag = "";
            this.toolTip1.SetToolTip(this.btnOK, "Localizar");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome / Login / CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(93, 51);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(317, 20);
            this.txtUser.TabIndex = 4;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(506, 271);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(50, 48);
            this.btnLimpar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cmBox
            // 
            this.cmBox.AccessibleName = "";
            this.cmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmBox.FormattingEnabled = true;
            this.cmBox.Items.AddRange(new object[] {
            "Nome",
            "Login",
            "CPF"});
            this.cmBox.Location = new System.Drawing.Point(416, 50);
            this.cmBox.Name = "cmBox";
            this.cmBox.Size = new System.Drawing.Size(140, 21);
            this.cmBox.TabIndex = 6;
            this.cmBox.SelectedIndexChanged += new System.EventHandler(this.cmBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login:";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogin.Location = new System.Drawing.Point(93, 129);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(130, 20);
            this.txtLogin.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.Window;
            this.txtCpf.Location = new System.Drawing.Point(93, 155);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ReadOnly = true;
            this.txtCpf.Size = new System.Drawing.Size(129, 20);
            this.txtCpf.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.Window;
            this.txtMail.Location = new System.Drawing.Point(93, 103);
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = true;
            this.txtMail.Size = new System.Drawing.Size(235, 20);
            this.txtMail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pesquisar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Criado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(334, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Modificado:";
            // 
            // txtCriado
            // 
            this.txtCriado.BackColor = System.Drawing.SystemColors.Window;
            this.txtCriado.Location = new System.Drawing.Point(416, 104);
            this.txtCriado.Name = "txtCriado";
            this.txtCriado.ReadOnly = true;
            this.txtCriado.Size = new System.Drawing.Size(140, 20);
            this.txtCriado.TabIndex = 16;
            // 
            // txtModificado
            // 
            this.txtModificado.BackColor = System.Drawing.SystemColors.Window;
            this.txtModificado.Location = new System.Drawing.Point(416, 130);
            this.txtModificado.Name = "txtModificado";
            this.txtModificado.ReadOnly = true;
            this.txtModificado.Size = new System.Drawing.Size(140, 20);
            this.txtModificado.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Troca Senha:";
            // 
            // txtTrocaSenha
            // 
            this.txtTrocaSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtTrocaSenha.Location = new System.Drawing.Point(416, 156);
            this.txtTrocaSenha.Name = "txtTrocaSenha";
            this.txtTrocaSenha.ReadOnly = true;
            this.txtTrocaSenha.Size = new System.Drawing.Size(140, 20);
            this.txtTrocaSenha.TabIndex = 19;
            this.txtTrocaSenha.TextChanged += new System.EventHandler(this.txtTrocaSenha_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(334, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Senha Exp:";
            // 
            // txtSenhaExp
            // 
            this.txtSenhaExp.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenhaExp.Location = new System.Drawing.Point(416, 182);
            this.txtSenhaExp.Name = "txtSenhaExp";
            this.txtSenhaExp.ReadOnly = true;
            this.txtSenhaExp.Size = new System.Drawing.Size(140, 20);
            this.txtSenhaExp.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(334, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ativo:";
            // 
            // txtAtivo
            // 
            this.txtAtivo.BackColor = System.Drawing.SystemColors.Window;
            this.txtAtivo.Location = new System.Drawing.Point(416, 234);
            this.txtAtivo.Name = "txtAtivo";
            this.txtAtivo.ReadOnly = true;
            this.txtAtivo.Size = new System.Drawing.Size(140, 20);
            this.txtAtivo.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(334, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Bloqueado:";
            // 
            // txtBloqueado
            // 
            this.txtBloqueado.BackColor = System.Drawing.SystemColors.Window;
            this.txtBloqueado.Location = new System.Drawing.Point(416, 208);
            this.txtBloqueado.Name = "txtBloqueado";
            this.txtBloqueado.ReadOnly = true;
            this.txtBloqueado.Size = new System.Drawing.Size(140, 20);
            this.txtBloqueado.TabIndex = 25;
            // 
            // btnDesativar
            // 
            this.btnDesativar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesativar.Image")));
            this.btnDesativar.Location = new System.Drawing.Point(256, 271);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(50, 48);
            this.btnDesativar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnDesativar, "Desativar Usuário");
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtivar.Image")));
            this.btnAtivar.Location = new System.Drawing.Point(172, 271);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(50, 48);
            this.btnAtivar.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnAtivar, "Ativar Usuário");
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(93, 271);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 48);
            this.btnReset.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnReset, "Resetar Senha");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesbloquear.Image = ((System.Drawing.Image)(resources.GetObject("btnDesbloquear.Image")));
            this.btnDesbloquear.Location = new System.Drawing.Point(342, 271);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(50, 48);
            this.btnDesbloquear.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnDesbloquear, "Desbloquear Usuário");
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.Location = new System.Drawing.Point(425, 271);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(50, 48);
            this.btnDeletar.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnDeletar, "Deletar Usuário");
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // txtDomain
            // 
            this.txtDomain.BackColor = System.Drawing.SystemColors.Window;
            this.txtDomain.Location = new System.Drawing.Point(416, 77);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.ReadOnly = true;
            this.txtDomain.Size = new System.Drawing.Size(140, 20);
            this.txtDomain.TabIndex = 31;
            this.toolTip1.SetToolTip(this.txtDomain, "Domínio");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 32;
            this.label13.Text = "Cargo:";
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCargo.Location = new System.Drawing.Point(93, 207);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.ReadOnly = true;
            this.txtCargo.Size = new System.Drawing.Size(235, 20);
            this.txtCargo.TabIndex = 33;
            // 
            // txtOU
            // 
            this.txtOU.BackColor = System.Drawing.SystemColors.Window;
            this.txtOU.Location = new System.Drawing.Point(93, 233);
            this.txtOU.Name = "txtOU";
            this.txtOU.ReadOnly = true;
            this.txtOU.Size = new System.Drawing.Size(130, 20);
            this.txtOU.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "OU:";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataNasc.Location = new System.Drawing.Point(93, 181);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.ReadOnly = true;
            this.txtDataNasc.Size = new System.Drawing.Size(129, 20);
            this.txtDataNasc.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 37;
            this.label15.Text = "Data Nasc:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.validarSenhaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.usuárioExternoToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // usuárioExternoToolStripMenuItem
            // 
            this.usuárioExternoToolStripMenuItem.Name = "usuárioExternoToolStripMenuItem";
            this.usuárioExternoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.usuárioExternoToolStripMenuItem.Text = "Usuário Externo";
            // 
            // validarSenhaToolStripMenuItem
            // 
            this.validarSenhaToolStripMenuItem.Name = "validarSenhaToolStripMenuItem";
            this.validarSenhaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.validarSenhaToolStripMenuItem.Text = "Validar Senha";
            this.validarSenhaToolStripMenuItem.Click += new System.EventHandler(this.validarSenhaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosAtivosToolStripMenuItem,
            this.usuáriosInativosToolStripMenuItem,
            this.usuáriosPorLoginToolStripMenuItem,
            this.usuáriosPorGrupoToolStripMenuItem,
            this.passwordNeverExpiresToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.rellatórioToolStripMenuItem_Click);
            // 
            // usuáriosAtivosToolStripMenuItem
            // 
            this.usuáriosAtivosToolStripMenuItem.Name = "usuáriosAtivosToolStripMenuItem";
            this.usuáriosAtivosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.usuáriosAtivosToolStripMenuItem.Text = "Usuários Ativos";
            this.usuáriosAtivosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosAtivosToolStripMenuItem_Click);
            // 
            // usuáriosInativosToolStripMenuItem
            // 
            this.usuáriosInativosToolStripMenuItem.Name = "usuáriosInativosToolStripMenuItem";
            this.usuáriosInativosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.usuáriosInativosToolStripMenuItem.Text = "Usuários Inativos";
            this.usuáriosInativosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosInativosToolStripMenuItem_Click);
            // 
            // usuáriosPorLoginToolStripMenuItem
            // 
            this.usuáriosPorLoginToolStripMenuItem.Name = "usuáriosPorLoginToolStripMenuItem";
            this.usuáriosPorLoginToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.usuáriosPorLoginToolStripMenuItem.Text = "Usuários por Nome ou Login";
            this.usuáriosPorLoginToolStripMenuItem.Click += new System.EventHandler(this.usuáriosPorLoginToolStripMenuItem_Click);
            // 
            // usuáriosPorGrupoToolStripMenuItem
            // 
            this.usuáriosPorGrupoToolStripMenuItem.Name = "usuáriosPorGrupoToolStripMenuItem";
            this.usuáriosPorGrupoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.usuáriosPorGrupoToolStripMenuItem.Text = "Usuários por Grupo";
            this.usuáriosPorGrupoToolStripMenuItem.Click += new System.EventHandler(this.usuáriosPorGrupoToolStripMenuItem_Click);
            // 
            // passwordNeverExpiresToolStripMenuItem
            // 
            this.passwordNeverExpiresToolStripMenuItem.Name = "passwordNeverExpiresToolStripMenuItem";
            this.passwordNeverExpiresToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.passwordNeverExpiresToolStripMenuItem.Text = "Senha Nunca Expira";
            this.passwordNeverExpiresToolStripMenuItem.Click += new System.EventHandler(this.passwordNeverExpiresToolStripMenuItem_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvUsuarios.GridColor = System.Drawing.Color.LightGray;
            this.dgvUsuarios.Location = new System.Drawing.Point(15, 335);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.Size = new System.Drawing.Size(541, 177);
            this.dgvUsuarios.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 142.132F;
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 57.86803F;
            this.Column2.HeaderText = "Login";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FrmAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(570, 524);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.txtOU);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAtivar);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.txtBloqueado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAtivo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSenhaExp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTrocaSenha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtModificado);
            this.Controls.Add(this.txtCriado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmBox);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmAd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SisAD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCriado;
        private System.Windows.Forms.TextBox txtModificado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTrocaSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSenhaExp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAtivo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBloqueado;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtOU;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDataNasc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioExternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosAtivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosInativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordNeverExpiresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosPorLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarSenhaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripMenuItem usuáriosPorGrupoToolStripMenuItem;
    }
}

