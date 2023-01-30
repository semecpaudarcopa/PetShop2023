namespace PetShop2023
{
    partial class ADM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.btnLogOut = new Syncfusion.WinForms.Controls.SfButton();
            this.btnPerfilUser = new Syncfusion.WinForms.Controls.SfButton();
            this.btnListarUser = new Syncfusion.WinForms.Controls.SfButton();
            this.btnAddUsuarios = new Syncfusion.WinForms.Controls.SfButton();
            this.btnPPrincipal = new Syncfusion.WinForms.Controls.SfButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_AddUsuario1 = new PetShop2023.Administradores.UC_AddUsuario();
            this.btnSair = new Syncfusion.WinForms.Controls.SfButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnPerfilUser);
            this.panel1.Controls.Add(this.btnListarUser);
            this.panel1.Controls.Add(this.btnAddUsuarios);
            this.panel1.Controls.Add(this.btnPPrincipal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 723);
            this.panel1.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userLabel.Location = new System.Drawing.Point(62, 620);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(104, 32);
            this.userLabel.TabIndex = 7;
            this.userLabel.Text = "Usuário";
            // 
            // btnLogOut
            // 
            this.btnLogOut.AccessibleName = "Button";
            this.btnLogOut.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogOut.Location = new System.Drawing.Point(38, 539);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(184, 53);
            this.btnLogOut.Style.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogOut.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnPerfilUser
            // 
            this.btnPerfilUser.AccessibleName = "Button";
            this.btnPerfilUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPerfilUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnPerfilUser.Location = new System.Drawing.Point(38, 480);
            this.btnPerfilUser.Name = "btnPerfilUser";
            this.btnPerfilUser.Size = new System.Drawing.Size(184, 53);
            this.btnPerfilUser.Style.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPerfilUser.TabIndex = 5;
            this.btnPerfilUser.Text = "Perfil do Usuário";
            this.btnPerfilUser.UseVisualStyleBackColor = false;
            // 
            // btnListarUser
            // 
            this.btnListarUser.AccessibleName = "Button";
            this.btnListarUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListarUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnListarUser.Location = new System.Drawing.Point(38, 421);
            this.btnListarUser.Name = "btnListarUser";
            this.btnListarUser.Size = new System.Drawing.Size(184, 53);
            this.btnListarUser.Style.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListarUser.TabIndex = 4;
            this.btnListarUser.Text = "Listar Usuários";
            this.btnListarUser.UseVisualStyleBackColor = false;
            // 
            // btnAddUsuarios
            // 
            this.btnAddUsuarios.AccessibleName = "Button";
            this.btnAddUsuarios.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnAddUsuarios.Location = new System.Drawing.Point(38, 362);
            this.btnAddUsuarios.Name = "btnAddUsuarios";
            this.btnAddUsuarios.Size = new System.Drawing.Size(184, 53);
            this.btnAddUsuarios.Style.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddUsuarios.TabIndex = 3;
            this.btnAddUsuarios.Text = "Add Usuários";
            this.btnAddUsuarios.UseVisualStyleBackColor = false;
            this.btnAddUsuarios.Click += new System.EventHandler(this.btnAddUsuarios_Click);
            // 
            // btnPPrincipal
            // 
            this.btnPPrincipal.AccessibleName = "Button";
            this.btnPPrincipal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPPrincipal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnPPrincipal.Location = new System.Drawing.Point(38, 303);
            this.btnPPrincipal.Name = "btnPPrincipal";
            this.btnPPrincipal.Size = new System.Drawing.Size(184, 53);
            this.btnPPrincipal.Style.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPPrincipal.TabIndex = 2;
            this.btnPPrincipal.Text = "Painel Principal";
            this.btnPPrincipal.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(38, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetShop2023.Properties.Resources.admin3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uC_AddUsuario1
            // 
            this.uC_AddUsuario1.Location = new System.Drawing.Point(266, 0);
            this.uC_AddUsuario1.Name = "uC_AddUsuario1";
            this.uC_AddUsuario1.Size = new System.Drawing.Size(929, 684);
            this.uC_AddUsuario1.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.AccessibleName = "Button";
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSair.Location = new System.Drawing.Point(1159, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 35);
            this.btnSair.Style.Image = global::PetShop2023.Properties.Resources.icone_sair_25_x_25;
            this.btnSair.TabIndex = 3;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 723);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.uC_AddUsuario1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADM";
            this.Text = "ADM";
            this.Load += new System.EventHandler(this.ADM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton btnLogOut;
        private Syncfusion.WinForms.Controls.SfButton btnPerfilUser;
        private Syncfusion.WinForms.Controls.SfButton btnListarUser;
        private Syncfusion.WinForms.Controls.SfButton btnAddUsuarios;
        private Syncfusion.WinForms.Controls.SfButton btnPPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userLabel;
        private Administradores.UC_AddUsuario uC_AddUsuario1;
        private Syncfusion.WinForms.Controls.SfButton btnSair;
    }
}