namespace BankCReport
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.bttn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginpicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginpicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(312, 329);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(110, 25);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(312, 388);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(511, 329);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(208, 26);
            this.txtBoxUserName.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(511, 388);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(208, 26);
            this.txtBoxPassword.TabIndex = 4;
            // 
            // bttnLogin
            // 
            this.bttnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogin.Location = new System.Drawing.Point(381, 462);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(221, 34);
            this.bttnLogin.TabIndex = 5;
            this.bttnLogin.Text = "Log in";
            this.bttnLogin.UseVisualStyleBackColor = false;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // bttn
            // 
            this.bttn.BackColor = System.Drawing.Color.RosyBrown;
            this.bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttn.Location = new System.Drawing.Point(855, 516);
            this.bttn.Name = "bttn";
            this.bttn.Size = new System.Drawing.Size(108, 44);
            this.bttn.TabIndex = 6;
            this.bttn.Text = "Exit";
            this.bttn.UseVisualStyleBackColor = false;
            this.bttn.Click += new System.EventHandler(this.bttn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankCReport.Properties.Resources.R__1_2;
            this.pictureBox1.Location = new System.Drawing.Point(422, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginpicBox
            // 
            this.LoginpicBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoginpicBox.Image = ((System.Drawing.Image)(resources.GetObject("LoginpicBox.Image")));
            this.LoginpicBox.Location = new System.Drawing.Point(266, 114);
            this.LoginpicBox.Name = "LoginpicBox";
            this.LoginpicBox.Size = new System.Drawing.Size(465, 187);
            this.LoginpicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginpicBox.TabIndex = 0;
            this.LoginpicBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttn);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.LoginpicBox);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginpicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginpicBox;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Button bttn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

