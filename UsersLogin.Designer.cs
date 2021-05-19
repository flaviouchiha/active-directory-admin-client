namespace PShell
{
    partial class FrmUsersLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsersLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstUsuarios = new System.Windows.Forms.RichTextBox();
            this.btnUsuariosLogin = new System.Windows.Forms.Button();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.radLogin = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstUsuarios);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuários";
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsuarios.Location = new System.Drawing.Point(6, 19);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(347, 355);
            this.lstUsuarios.TabIndex = 0;
            this.lstUsuarios.Text = "";
            // 
            // btnUsuariosLogin
            // 
            this.btnUsuariosLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosLogin.Location = new System.Drawing.Point(92, 430);
            this.btnUsuariosLogin.Name = "btnUsuariosLogin";
            this.btnUsuariosLogin.Size = new System.Drawing.Size(201, 31);
            this.btnUsuariosLogin.TabIndex = 1;
            this.btnUsuariosLogin.Text = "Gerar Relatório";
            this.btnUsuariosLogin.UseVisualStyleBackColor = true;
            this.btnUsuariosLogin.Click += new System.EventHandler(this.btnUsuariosLogin_Click);
            // 
            // radNome
            // 
            this.radNome.AutoSize = true;
            this.radNome.Checked = true;
            this.radNome.Location = new System.Drawing.Point(98, 397);
            this.radNome.Name = "radNome";
            this.radNome.Size = new System.Drawing.Size(53, 17);
            this.radNome.TabIndex = 2;
            this.radNome.TabStop = true;
            this.radNome.Text = "Nome";
            this.radNome.UseVisualStyleBackColor = true;
            // 
            // radLogin
            // 
            this.radLogin.AutoSize = true;
            this.radLogin.Location = new System.Drawing.Point(242, 397);
            this.radLogin.Name = "radLogin";
            this.radLogin.Size = new System.Drawing.Size(51, 17);
            this.radLogin.TabIndex = 3;
            this.radLogin.Text = "Login";
            this.radLogin.UseVisualStyleBackColor = true;
            // 
            // FrmUsersLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 473);
            this.Controls.Add(this.radLogin);
            this.Controls.Add(this.radNome);
            this.Controls.Add(this.btnUsuariosLogin);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmUsersLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários do Active Directory";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUsuariosLogin;
        private System.Windows.Forms.RichTextBox lstUsuarios;
        private System.Windows.Forms.RadioButton radNome;
        private System.Windows.Forms.RadioButton radLogin;
    }
}