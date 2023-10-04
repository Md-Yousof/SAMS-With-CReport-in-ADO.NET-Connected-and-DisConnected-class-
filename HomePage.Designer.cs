namespace BankCReport
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.tab_DepositAboutMe = new System.Windows.Forms.TabPage();
            this.tab_Home = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3Deposit = new System.Windows.Forms.Button();
            this.bttnHomeExit = new System.Windows.Forms.Button();
            this.button2Client = new System.Windows.Forms.Button();
            this.button1Branch = new System.Windows.Forms.Button();
            this.bttnCrystalR = new System.Windows.Forms.Button();
            this.button4Withdraw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnExit = new System.Windows.Forms.Button();
            this.tab_Home.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_DepositAboutMe
            // 
            this.tab_DepositAboutMe.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tab_DepositAboutMe.ForeColor = System.Drawing.Color.LightCoral;
            this.tab_DepositAboutMe.Location = new System.Drawing.Point(4, 34);
            this.tab_DepositAboutMe.Name = "tab_DepositAboutMe";
            this.tab_DepositAboutMe.Size = new System.Drawing.Size(967, 483);
            this.tab_DepositAboutMe.TabIndex = 3;
            this.tab_DepositAboutMe.Text = "About Project";
            // 
            // tab_Home
            // 
            this.tab_Home.BackColor = System.Drawing.Color.RosyBrown;
            this.tab_Home.Controls.Add(this.panel2);
            this.tab_Home.Controls.Add(this.label2);
            this.tab_Home.Controls.Add(this.pictureBox1);
            this.tab_Home.Controls.Add(this.label1);
            this.tab_Home.Location = new System.Drawing.Point(4, 34);
            this.tab_Home.Name = "tab_Home";
            this.tab_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Home.Size = new System.Drawing.Size(967, 483);
            this.tab_Home.TabIndex = 0;
            this.tab_Home.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Controls.Add(this.bttnExit);
            this.panel2.Controls.Add(this.button3Deposit);
            this.panel2.Controls.Add(this.bttnHomeExit);
            this.panel2.Controls.Add(this.button2Client);
            this.panel2.Controls.Add(this.button1Branch);
            this.panel2.Controls.Add(this.bttnCrystalR);
            this.panel2.Controls.Add(this.button4Withdraw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 477);
            this.panel2.TabIndex = 9;
            // 
            // button3Deposit
            // 
            this.button3Deposit.BackColor = System.Drawing.Color.LimeGreen;
            this.button3Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Deposit.Location = new System.Drawing.Point(24, 143);
            this.button3Deposit.Name = "button3Deposit";
            this.button3Deposit.Size = new System.Drawing.Size(168, 46);
            this.button3Deposit.TabIndex = 6;
            this.button3Deposit.Text = "DepositTable";
            this.button3Deposit.UseVisualStyleBackColor = false;
            this.button3Deposit.Click += new System.EventHandler(this.button3Deposit_Click);
            // 
            // bttnHomeExit
            // 
            this.bttnHomeExit.BackColor = System.Drawing.Color.Firebrick;
            this.bttnHomeExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHomeExit.ForeColor = System.Drawing.Color.Black;
            this.bttnHomeExit.Location = new System.Drawing.Point(24, 336);
            this.bttnHomeExit.Name = "bttnHomeExit";
            this.bttnHomeExit.Size = new System.Drawing.Size(168, 46);
            this.bttnHomeExit.TabIndex = 3;
            this.bttnHomeExit.Text = "Log out";
            this.bttnHomeExit.UseVisualStyleBackColor = false;
            this.bttnHomeExit.Click += new System.EventHandler(this.bttnHomeExit_Click);
            // 
            // button2Client
            // 
            this.button2Client.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Client.Location = new System.Drawing.Point(24, 79);
            this.button2Client.Name = "button2Client";
            this.button2Client.Size = new System.Drawing.Size(168, 46);
            this.button2Client.TabIndex = 5;
            this.button2Client.Text = "ClientTabl";
            this.button2Client.UseVisualStyleBackColor = false;
            this.button2Client.Click += new System.EventHandler(this.button2Client_Click);
            // 
            // button1Branch
            // 
            this.button1Branch.BackColor = System.Drawing.Color.Peru;
            this.button1Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Branch.Location = new System.Drawing.Point(24, 14);
            this.button1Branch.Name = "button1Branch";
            this.button1Branch.Size = new System.Drawing.Size(168, 46);
            this.button1Branch.TabIndex = 4;
            this.button1Branch.Text = "Branch Table";
            this.button1Branch.UseVisualStyleBackColor = false;
            this.button1Branch.Click += new System.EventHandler(this.button1Branch_Click);
            // 
            // bttnCrystalR
            // 
            this.bttnCrystalR.BackColor = System.Drawing.Color.Teal;
            this.bttnCrystalR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCrystalR.Location = new System.Drawing.Point(24, 271);
            this.bttnCrystalR.Name = "bttnCrystalR";
            this.bttnCrystalR.Size = new System.Drawing.Size(168, 46);
            this.bttnCrystalR.TabIndex = 8;
            this.bttnCrystalR.Text = "Crystal  Report";
            this.bttnCrystalR.UseVisualStyleBackColor = false;
            this.bttnCrystalR.Click += new System.EventHandler(this.bttnCrystalR_Click);
            // 
            // button4Withdraw
            // 
            this.button4Withdraw.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button4Withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Withdraw.Location = new System.Drawing.Point(24, 209);
            this.button4Withdraw.Name = "button4Withdraw";
            this.button4Withdraw.Size = new System.Drawing.Size(168, 46);
            this.button4Withdraw.TabIndex = 7;
            this.button4Withdraw.Text = "WithdrawTable";
            this.button4Withdraw.UseVisualStyleBackColor = false;
            this.button4Withdraw.Click += new System.EventHandler(this.button4Withdraw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Turquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(367, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to My Windows From CReport Project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(261, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "IsDB-BISEW IT SCHOLARSHIP PROPGRAME";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Home);
            this.tabControl1.Controls.Add(this.tab_DepositAboutMe);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 82);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.Location = new System.Drawing.Point(24, 401);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(168, 42);
            this.bttnExit.TabIndex = 0;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.tab_Home.ResumeLayout(false);
            this.tab_Home.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tab_DepositAboutMe;
        private System.Windows.Forms.TabPage tab_Home;
        private System.Windows.Forms.Button bttnHomeExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button4Withdraw;
        private System.Windows.Forms.Button button3Deposit;
        private System.Windows.Forms.Button button2Client;
        private System.Windows.Forms.Button button1Branch;
        private System.Windows.Forms.Button bttnCrystalR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnExit;
    }
}