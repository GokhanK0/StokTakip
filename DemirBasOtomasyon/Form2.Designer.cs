namespace DemirBasOtomasyon
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.linklbl_create_accnt = new System.Windows.Forms.LinkLabel();
            this.btn_ext = new System.Windows.Forms.Button();
            this.btn_sgn_in = new System.Windows.Forms.Button();
            this.lbl_psswrd = new System.Windows.Forms.Label();
            this.lbl_usr_nme = new System.Windows.Forms.Label();
            this.txt_psswrd = new System.Windows.Forms.TextBox();
            this.txt_usr_nme = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chk_remember = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linklbl_create_accnt
            // 
            this.linklbl_create_accnt.AutoSize = true;
            this.linklbl_create_accnt.BackColor = System.Drawing.SystemColors.Control;
            this.linklbl_create_accnt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklbl_create_accnt.LinkColor = System.Drawing.Color.ForestGreen;
            this.linklbl_create_accnt.Location = new System.Drawing.Point(175, 440);
            this.linklbl_create_accnt.Name = "linklbl_create_accnt";
            this.linklbl_create_accnt.Size = new System.Drawing.Size(87, 14);
            this.linklbl_create_accnt.TabIndex = 17;
            this.linklbl_create_accnt.TabStop = true;
            this.linklbl_create_accnt.Text = "Create Account";
            this.linklbl_create_accnt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linklbl_create_accnt_LinkClicked);
            // 
            // btn_ext
            // 
            this.btn_ext.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ext.FlatAppearance.BorderSize = 0;
            this.btn_ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ext.Location = new System.Drawing.Point(149, 387);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(101, 36);
            this.btn_ext.TabIndex = 16;
            this.btn_ext.Text = "Exit";
            this.btn_ext.UseVisualStyleBackColor = false;
            this.btn_ext.Click += new System.EventHandler(this.Btn_ext_Click);
            // 
            // btn_sgn_in
            // 
            this.btn_sgn_in.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_sgn_in.FlatAppearance.BorderSize = 0;
            this.btn_sgn_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sgn_in.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sgn_in.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sgn_in.Location = new System.Drawing.Point(42, 387);
            this.btn_sgn_in.Name = "btn_sgn_in";
            this.btn_sgn_in.Size = new System.Drawing.Size(101, 36);
            this.btn_sgn_in.TabIndex = 13;
            this.btn_sgn_in.Text = "Sign In";
            this.btn_sgn_in.UseVisualStyleBackColor = false;
            this.btn_sgn_in.Click += new System.EventHandler(this.Btn_sgn_in_Click);
            // 
            // lbl_psswrd
            // 
            this.lbl_psswrd.AutoSize = true;
            this.lbl_psswrd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_psswrd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_psswrd.Location = new System.Drawing.Point(29, 291);
            this.lbl_psswrd.Name = "lbl_psswrd";
            this.lbl_psswrd.Size = new System.Drawing.Size(65, 19);
            this.lbl_psswrd.TabIndex = 14;
            this.lbl_psswrd.Text = "Password";
            // 
            // lbl_usr_nme
            // 
            this.lbl_usr_nme.AutoSize = true;
            this.lbl_usr_nme.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_usr_nme.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_usr_nme.Location = new System.Drawing.Point(29, 227);
            this.lbl_usr_nme.Name = "lbl_usr_nme";
            this.lbl_usr_nme.Size = new System.Drawing.Size(69, 19);
            this.lbl_usr_nme.TabIndex = 15;
            this.lbl_usr_nme.Text = "Username";
            // 
            // txt_psswrd
            // 
            this.txt_psswrd.BackColor = System.Drawing.SystemColors.Control;
            this.txt_psswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_psswrd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_psswrd.Location = new System.Drawing.Point(33, 313);
            this.txt_psswrd.Name = "txt_psswrd";
            this.txt_psswrd.PasswordChar = '*';
            this.txt_psswrd.Size = new System.Drawing.Size(226, 20);
            this.txt_psswrd.TabIndex = 10;
            // 
            // txt_usr_nme
            // 
            this.txt_usr_nme.BackColor = System.Drawing.SystemColors.Control;
            this.txt_usr_nme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usr_nme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_usr_nme.Location = new System.Drawing.Point(33, 249);
            this.txt_usr_nme.Name = "txt_usr_nme";
            this.txt_usr_nme.Size = new System.Drawing.Size(226, 20);
            this.txt_usr_nme.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(33, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 1);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(33, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 1);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 481);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 25);
            this.panel4.TabIndex = 18;
            // 
            // chk_remember
            // 
            this.chk_remember.AutoSize = true;
            this.chk_remember.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_remember.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chk_remember.Location = new System.Drawing.Point(33, 341);
            this.chk_remember.Name = "chk_remember";
            this.chk_remember.Size = new System.Drawing.Size(104, 20);
            this.chk_remember.TabIndex = 19;
            this.chk_remember.Text = "Remember Me";
            this.chk_remember.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DemirBasOtomasyon.Properties.Resources.Login3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 185);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 506);
            this.Controls.Add(this.chk_remember);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.linklbl_create_accnt);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.btn_sgn_in);
            this.Controls.Add(this.lbl_psswrd);
            this.Controls.Add(this.lbl_usr_nme);
            this.Controls.Add(this.txt_psswrd);
            this.Controls.Add(this.txt_usr_nme);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_Form_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklbl_create_accnt;
        private System.Windows.Forms.Button btn_ext;
        private System.Windows.Forms.Button btn_sgn_in;
        private System.Windows.Forms.Label lbl_psswrd;
        private System.Windows.Forms.Label lbl_usr_nme;
        private System.Windows.Forms.TextBox txt_psswrd;
        private System.Windows.Forms.TextBox txt_usr_nme;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chk_remember;
    }
}