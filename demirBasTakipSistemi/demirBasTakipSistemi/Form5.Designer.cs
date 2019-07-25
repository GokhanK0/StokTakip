namespace demirBasTakipSistemi
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_usr_nme = new System.Windows.Forms.TextBox();
            this.txt_psswrd = new System.Windows.Forms.TextBox();
            this.lbl_usr_nme = new System.Windows.Forms.Label();
            this.lbl_psswrd = new System.Windows.Forms.Label();
            this.btn_sgn_in = new System.Windows.Forms.Button();
            this.btn_ext = new System.Windows.Forms.Button();
            this.chk_remember = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(33, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(33, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 1);
            this.panel3.TabIndex = 2;
            // 
            // txt_usr_nme
            // 
            this.txt_usr_nme.BackColor = System.Drawing.SystemColors.Control;
            this.txt_usr_nme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usr_nme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_usr_nme.Location = new System.Drawing.Point(33, 245);
            this.txt_usr_nme.Name = "txt_usr_nme";
            this.txt_usr_nme.Size = new System.Drawing.Size(226, 20);
            this.txt_usr_nme.TabIndex = 1;
            // 
            // txt_psswrd
            // 
            this.txt_psswrd.BackColor = System.Drawing.SystemColors.Control;
            this.txt_psswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_psswrd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_psswrd.Location = new System.Drawing.Point(33, 309);
            this.txt_psswrd.Name = "txt_psswrd";
            this.txt_psswrd.PasswordChar = '*';
            this.txt_psswrd.Size = new System.Drawing.Size(226, 20);
            this.txt_psswrd.TabIndex = 2;
            // 
            // lbl_usr_nme
            // 
            this.lbl_usr_nme.AutoSize = true;
            this.lbl_usr_nme.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_usr_nme.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_usr_nme.Location = new System.Drawing.Point(29, 223);
            this.lbl_usr_nme.Name = "lbl_usr_nme";
            this.lbl_usr_nme.Size = new System.Drawing.Size(69, 19);
            this.lbl_usr_nme.TabIndex = 4;
            this.lbl_usr_nme.Text = "Username";
            // 
            // lbl_psswrd
            // 
            this.lbl_psswrd.AutoSize = true;
            this.lbl_psswrd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_psswrd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_psswrd.Location = new System.Drawing.Point(29, 287);
            this.lbl_psswrd.Name = "lbl_psswrd";
            this.lbl_psswrd.Size = new System.Drawing.Size(65, 19);
            this.lbl_psswrd.TabIndex = 4;
            this.lbl_psswrd.Text = "Password";
            // 
            // btn_sgn_in
            // 
            this.btn_sgn_in.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_sgn_in.FlatAppearance.BorderSize = 0;
            this.btn_sgn_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sgn_in.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sgn_in.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sgn_in.Location = new System.Drawing.Point(33, 403);
            this.btn_sgn_in.Name = "btn_sgn_in";
            this.btn_sgn_in.Size = new System.Drawing.Size(101, 36);
            this.btn_sgn_in.TabIndex = 4;
            this.btn_sgn_in.Text = "Sign In";
            this.btn_sgn_in.UseVisualStyleBackColor = false;
            this.btn_sgn_in.Click += new System.EventHandler(this.Btn_sgn_in_Click);
            // 
            // btn_ext
            // 
            this.btn_ext.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ext.FlatAppearance.BorderSize = 0;
            this.btn_ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ext.Location = new System.Drawing.Point(158, 403);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(101, 36);
            this.btn_ext.TabIndex = 5;
            this.btn_ext.Text = "Exit";
            this.btn_ext.UseVisualStyleBackColor = false;
            this.btn_ext.Click += new System.EventHandler(this.Btn_ext_Click);
            // 
            // chk_remember
            // 
            this.chk_remember.AutoSize = true;
            this.chk_remember.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_remember.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chk_remember.Location = new System.Drawing.Point(33, 337);
            this.chk_remember.Name = "chk_remember";
            this.chk_remember.Size = new System.Drawing.Size(104, 20);
            this.chk_remember.TabIndex = 3;
            this.chk_remember.Text = "Remember Me";
            this.chk_remember.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::demirBasTakipSistemi.Properties.Resources.Login;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 185);
            this.panel1.TabIndex = 0;
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 470);
            this.Controls.Add(this.chk_remember);
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
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_usr_nme;
        private System.Windows.Forms.TextBox txt_psswrd;
        private System.Windows.Forms.Label lbl_usr_nme;
        private System.Windows.Forms.Label lbl_psswrd;
        private System.Windows.Forms.Button btn_sgn_in;
        private System.Windows.Forms.Button btn_ext;
        private System.Windows.Forms.CheckBox chk_remember;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}