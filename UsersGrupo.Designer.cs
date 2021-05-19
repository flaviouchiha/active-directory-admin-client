namespace PShell
{
    partial class FrmUsersGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsersGrupo));
            this.btnUsuariosGrupos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstGrupos = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsuariosGrupos
            // 
            this.btnUsuariosGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosGrupos.Location = new System.Drawing.Point(95, 409);
            this.btnUsuariosGrupos.Name = "btnUsuariosGrupos";
            this.btnUsuariosGrupos.Size = new System.Drawing.Size(201, 31);
            this.btnUsuariosGrupos.TabIndex = 5;
            this.btnUsuariosGrupos.Text = "Gerar Relatório";
            this.btnUsuariosGrupos.UseVisualStyleBackColor = true;
            this.btnUsuariosGrupos.Click += new System.EventHandler(this.btnUsuariosGrupos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstGrupos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 380);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupos";
            // 
            // lstGrupos
            // 
            this.lstGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGrupos.Location = new System.Drawing.Point(6, 19);
            this.lstGrupos.Name = "lstGrupos";
            this.lstGrupos.Size = new System.Drawing.Size(347, 355);
            this.lstGrupos.TabIndex = 0;
            this.lstGrupos.Text = "";
            // 
            // FrmUsersGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 460);
            this.Controls.Add(this.btnUsuariosGrupos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsersGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários dos Grupos";
            this.Load += new System.EventHandler(this.FrmUsersGrupo_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUsuariosGrupos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox lstGrupos;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}