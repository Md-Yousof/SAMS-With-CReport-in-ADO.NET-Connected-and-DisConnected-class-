namespace BankCReport
{
    partial class Deposit
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
            this.components = new System.ComponentModel.Container();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.label1AccChecked = new System.Windows.Forms.Label();
            this.label2BegBalance = new System.Windows.Forms.Label();
            this.label3DeBalance = new System.Windows.Forms.Label();
            this.label4EndBalance = new System.Windows.Forms.Label();
            this.label5ClienID = new System.Windows.Forms.Label();
            this.label6BranchID = new System.Windows.Forms.Label();
            this.comboBox1AccCheck = new System.Windows.Forms.ComboBox();
            this.textBox1BegBal = new System.Windows.Forms.TextBox();
            this.textBox2DeBal = new System.Windows.Forms.TextBox();
            this.textBox3EndBal = new System.Windows.Forms.TextBox();
            this.textBox4Clientid = new System.Windows.Forms.TextBox();
            this.textBox5Brnchid = new System.Windows.Forms.TextBox();
            this.button1Add = new System.Windows.Forms.Button();
            this.bttbgotohome = new System.Windows.Forms.Button();
            this.dataGridView1Deposit = new System.Windows.Forms.DataGridView();
            this.accNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accCheckedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.begBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankCrystalReportDataSet4 = new BankCReport.BankCrystalReportDataSet4();
            this.depositTableAdapter = new BankCReport.BankCrystalReportDataSet4TableAdapters.DepositTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4Withdraw = new System.Windows.Forms.Button();
            this.button3Branch = new System.Windows.Forms.Button();
            this.button1Client = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Deposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankCrystalReportDataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.Color.SeaShell;
            this.lblDeposit.Location = new System.Drawing.Point(560, 56);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(274, 29);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "This Table for Deposit";
            // 
            // label1AccChecked
            // 
            this.label1AccChecked.AutoSize = true;
            this.label1AccChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1AccChecked.Location = new System.Drawing.Point(323, 167);
            this.label1AccChecked.Name = "label1AccChecked";
            this.label1AccChecked.Size = new System.Drawing.Size(168, 25);
            this.label1AccChecked.TabIndex = 1;
            this.label1AccChecked.Text = "Account Checked";
            // 
            // label2BegBalance
            // 
            this.label2BegBalance.AutoSize = true;
            this.label2BegBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2BegBalance.Location = new System.Drawing.Point(767, 170);
            this.label2BegBalance.Name = "label2BegBalance";
            this.label2BegBalance.Size = new System.Drawing.Size(164, 25);
            this.label2BegBalance.TabIndex = 2;
            this.label2BegBalance.Text = "Begining Balance";
            // 
            // label3DeBalance
            // 
            this.label3DeBalance.AutoSize = true;
            this.label3DeBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3DeBalance.Location = new System.Drawing.Point(323, 219);
            this.label3DeBalance.Name = "label3DeBalance";
            this.label3DeBalance.Size = new System.Drawing.Size(154, 25);
            this.label3DeBalance.TabIndex = 3;
            this.label3DeBalance.Text = "Deposit Balance";
            // 
            // label4EndBalance
            // 
            this.label4EndBalance.AutoSize = true;
            this.label4EndBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4EndBalance.Location = new System.Drawing.Point(767, 216);
            this.label4EndBalance.Name = "label4EndBalance";
            this.label4EndBalance.Size = new System.Drawing.Size(149, 25);
            this.label4EndBalance.TabIndex = 4;
            this.label4EndBalance.Text = "Ending Balance";
            // 
            // label5ClienID
            // 
            this.label5ClienID.AutoSize = true;
            this.label5ClienID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5ClienID.Location = new System.Drawing.Point(323, 270);
            this.label5ClienID.Name = "label5ClienID";
            this.label5ClienID.Size = new System.Drawing.Size(86, 25);
            this.label5ClienID.TabIndex = 5;
            this.label5ClienID.Text = "Client ID";
            // 
            // label6BranchID
            // 
            this.label6BranchID.AutoSize = true;
            this.label6BranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6BranchID.Location = new System.Drawing.Point(767, 267);
            this.label6BranchID.Name = "label6BranchID";
            this.label6BranchID.Size = new System.Drawing.Size(98, 25);
            this.label6BranchID.TabIndex = 6;
            this.label6BranchID.Text = "Branch ID";
            // 
            // comboBox1AccCheck
            // 
            this.comboBox1AccCheck.FormattingEnabled = true;
            this.comboBox1AccCheck.Items.AddRange(new object[] {
            "1",
            "0"});
            this.comboBox1AccCheck.Location = new System.Drawing.Point(512, 167);
            this.comboBox1AccCheck.Name = "comboBox1AccCheck";
            this.comboBox1AccCheck.Size = new System.Drawing.Size(212, 30);
            this.comboBox1AccCheck.TabIndex = 9;
            this.comboBox1AccCheck.Text = "Select Yes=1 or No=0";
            // 
            // textBox1BegBal
            // 
            this.textBox1BegBal.Location = new System.Drawing.Point(944, 170);
            this.textBox1BegBal.Name = "textBox1BegBal";
            this.textBox1BegBal.Size = new System.Drawing.Size(223, 28);
            this.textBox1BegBal.TabIndex = 10;
            // 
            // textBox2DeBal
            // 
            this.textBox2DeBal.Location = new System.Drawing.Point(512, 217);
            this.textBox2DeBal.Name = "textBox2DeBal";
            this.textBox2DeBal.Size = new System.Drawing.Size(212, 28);
            this.textBox2DeBal.TabIndex = 11;
            // 
            // textBox3EndBal
            // 
            this.textBox3EndBal.Location = new System.Drawing.Point(944, 216);
            this.textBox3EndBal.Name = "textBox3EndBal";
            this.textBox3EndBal.Size = new System.Drawing.Size(223, 28);
            this.textBox3EndBal.TabIndex = 12;
            // 
            // textBox4Clientid
            // 
            this.textBox4Clientid.Location = new System.Drawing.Point(512, 267);
            this.textBox4Clientid.Name = "textBox4Clientid";
            this.textBox4Clientid.Size = new System.Drawing.Size(212, 28);
            this.textBox4Clientid.TabIndex = 13;
            // 
            // textBox5Brnchid
            // 
            this.textBox5Brnchid.Location = new System.Drawing.Point(944, 264);
            this.textBox5Brnchid.Name = "textBox5Brnchid";
            this.textBox5Brnchid.Size = new System.Drawing.Size(223, 28);
            this.textBox5Brnchid.TabIndex = 14;
            // 
            // button1Add
            // 
            this.button1Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Add.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1Add.Location = new System.Drawing.Point(677, 315);
            this.button1Add.Name = "button1Add";
            this.button1Add.Size = new System.Drawing.Size(122, 44);
            this.button1Add.TabIndex = 15;
            this.button1Add.Text = "Add";
            this.button1Add.UseVisualStyleBackColor = true;
            this.button1Add.Click += new System.EventHandler(this.button1Add_Click);
            // 
            // bttbgotohome
            // 
            this.bttbgotohome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttbgotohome.ForeColor = System.Drawing.Color.Maroon;
            this.bttbgotohome.Location = new System.Drawing.Point(13, 372);
            this.bttbgotohome.Name = "bttbgotohome";
            this.bttbgotohome.Size = new System.Drawing.Size(249, 45);
            this.bttbgotohome.TabIndex = 16;
            this.bttbgotohome.Text = "Click go to Home";
            this.bttbgotohome.UseVisualStyleBackColor = true;
            this.bttbgotohome.Click += new System.EventHandler(this.bttbgotohome_Click);
            // 
            // dataGridView1Deposit
            // 
            this.dataGridView1Deposit.AutoGenerateColumns = false;
            this.dataGridView1Deposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Deposit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accNumberDataGridViewTextBoxColumn,
            this.accCheckedDataGridViewCheckBoxColumn,
            this.begBalanceDataGridViewTextBoxColumn,
            this.deBalanceDataGridViewTextBoxColumn,
            this.endBalanceDataGridViewTextBoxColumn,
            this.clienIDDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn});
            this.dataGridView1Deposit.DataSource = this.depositBindingSource;
            this.dataGridView1Deposit.Location = new System.Drawing.Point(309, 380);
            this.dataGridView1Deposit.Name = "dataGridView1Deposit";
            this.dataGridView1Deposit.RowHeadersWidth = 62;
            this.dataGridView1Deposit.RowTemplate.Height = 28;
            this.dataGridView1Deposit.Size = new System.Drawing.Size(891, 211);
            this.dataGridView1Deposit.TabIndex = 17;
            this.dataGridView1Deposit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // accNumberDataGridViewTextBoxColumn
            // 
            this.accNumberDataGridViewTextBoxColumn.DataPropertyName = "AccNumber";
            this.accNumberDataGridViewTextBoxColumn.HeaderText = "AccNumber";
            this.accNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.accNumberDataGridViewTextBoxColumn.Name = "accNumberDataGridViewTextBoxColumn";
            this.accNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.accNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // accCheckedDataGridViewCheckBoxColumn
            // 
            this.accCheckedDataGridViewCheckBoxColumn.DataPropertyName = "AccChecked";
            this.accCheckedDataGridViewCheckBoxColumn.HeaderText = "AccChecked";
            this.accCheckedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.accCheckedDataGridViewCheckBoxColumn.Name = "accCheckedDataGridViewCheckBoxColumn";
            this.accCheckedDataGridViewCheckBoxColumn.Width = 150;
            // 
            // begBalanceDataGridViewTextBoxColumn
            // 
            this.begBalanceDataGridViewTextBoxColumn.DataPropertyName = "BegBalance";
            this.begBalanceDataGridViewTextBoxColumn.HeaderText = "BegBalance";
            this.begBalanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.begBalanceDataGridViewTextBoxColumn.Name = "begBalanceDataGridViewTextBoxColumn";
            this.begBalanceDataGridViewTextBoxColumn.Width = 150;
            // 
            // deBalanceDataGridViewTextBoxColumn
            // 
            this.deBalanceDataGridViewTextBoxColumn.DataPropertyName = "DeBalance";
            this.deBalanceDataGridViewTextBoxColumn.HeaderText = "DeBalance";
            this.deBalanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deBalanceDataGridViewTextBoxColumn.Name = "deBalanceDataGridViewTextBoxColumn";
            this.deBalanceDataGridViewTextBoxColumn.Width = 150;
            // 
            // endBalanceDataGridViewTextBoxColumn
            // 
            this.endBalanceDataGridViewTextBoxColumn.DataPropertyName = "EndBalance";
            this.endBalanceDataGridViewTextBoxColumn.HeaderText = "EndBalance";
            this.endBalanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endBalanceDataGridViewTextBoxColumn.Name = "endBalanceDataGridViewTextBoxColumn";
            this.endBalanceDataGridViewTextBoxColumn.Width = 150;
            // 
            // clienIDDataGridViewTextBoxColumn
            // 
            this.clienIDDataGridViewTextBoxColumn.DataPropertyName = "ClienID";
            this.clienIDDataGridViewTextBoxColumn.HeaderText = "ClienID";
            this.clienIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clienIDDataGridViewTextBoxColumn.Name = "clienIDDataGridViewTextBoxColumn";
            this.clienIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // depositBindingSource
            // 
            this.depositBindingSource.DataMember = "Deposit";
            this.depositBindingSource.DataSource = this.bankCrystalReportDataSet4;
            // 
            // bankCrystalReportDataSet4
            // 
            this.bankCrystalReportDataSet4.DataSetName = "BankCrystalReportDataSet4";
            this.bankCrystalReportDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depositTableAdapter
            // 
            this.depositTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.bttnX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 53);
            this.panel1.TabIndex = 18;
            // 
            // bttnX
            // 
            this.bttnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnX.Location = new System.Drawing.Point(1187, 1);
            this.bttnX.Name = "bttnX";
            this.bttnX.Size = new System.Drawing.Size(76, 51);
            this.bttnX.TabIndex = 1;
            this.bttnX.Text = "X";
            this.bttnX.UseVisualStyleBackColor = true;
            this.bttnX.Click += new System.EventHandler(this.bttnX_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.button4Withdraw);
            this.panel2.Controls.Add(this.button3Branch);
            this.panel2.Controls.Add(this.button1Client);
            this.panel2.Controls.Add(this.bttbgotohome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 581);
            this.panel2.TabIndex = 26;
            // 
            // button4Withdraw
            // 
            this.button4Withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Withdraw.ForeColor = System.Drawing.Color.IndianRed;
            this.button4Withdraw.Location = new System.Drawing.Point(13, 286);
            this.button4Withdraw.Name = "button4Withdraw";
            this.button4Withdraw.Size = new System.Drawing.Size(249, 46);
            this.button4Withdraw.TabIndex = 9;
            this.button4Withdraw.Text = "WithdrawTable";
            this.button4Withdraw.UseVisualStyleBackColor = true;
            this.button4Withdraw.Click += new System.EventHandler(this.button4Withdraw_Click);
            // 
            // button3Branch
            // 
            this.button3Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Branch.ForeColor = System.Drawing.Color.IndianRed;
            this.button3Branch.Location = new System.Drawing.Point(13, 114);
            this.button3Branch.Name = "button3Branch";
            this.button3Branch.Size = new System.Drawing.Size(249, 47);
            this.button3Branch.TabIndex = 8;
            this.button3Branch.Text = "Branch Table";
            this.button3Branch.UseVisualStyleBackColor = true;
            this.button3Branch.Click += new System.EventHandler(this.button3Branch_Click);
            // 
            // button1Client
            // 
            this.button1Client.BackColor = System.Drawing.Color.Transparent;
            this.button1Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Client.ForeColor = System.Drawing.Color.IndianRed;
            this.button1Client.Location = new System.Drawing.Point(13, 201);
            this.button1Client.Name = "button1Client";
            this.button1Client.Size = new System.Drawing.Size(249, 50);
            this.button1Client.TabIndex = 6;
            this.button1Client.Text = "Client Table";
            this.button1Client.UseVisualStyleBackColor = false;
            this.button1Client.Click += new System.EventHandler(this.button1Client_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1262, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1Deposit);
            this.Controls.Add(this.button1Add);
            this.Controls.Add(this.textBox5Brnchid);
            this.Controls.Add(this.textBox4Clientid);
            this.Controls.Add(this.textBox3EndBal);
            this.Controls.Add(this.textBox2DeBal);
            this.Controls.Add(this.textBox1BegBal);
            this.Controls.Add(this.comboBox1AccCheck);
            this.Controls.Add(this.label6BranchID);
            this.Controls.Add(this.label5ClienID);
            this.Controls.Add(this.label4EndBalance);
            this.Controls.Add(this.label3DeBalance);
            this.Controls.Add(this.label2BegBalance);
            this.Controls.Add(this.label1AccChecked);
            this.Controls.Add(this.lblDeposit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Deposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankCrystalReportDataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label label1AccChecked;
        private System.Windows.Forms.Label label2BegBalance;
        private System.Windows.Forms.Label label3DeBalance;
        private System.Windows.Forms.Label label4EndBalance;
        private System.Windows.Forms.Label label5ClienID;
        private System.Windows.Forms.Label label6BranchID;
        private System.Windows.Forms.ComboBox comboBox1AccCheck;
        private System.Windows.Forms.TextBox textBox1BegBal;
        private System.Windows.Forms.TextBox textBox2DeBal;
        private System.Windows.Forms.TextBox textBox3EndBal;
        private System.Windows.Forms.TextBox textBox4Clientid;
        private System.Windows.Forms.TextBox textBox5Brnchid;
        private System.Windows.Forms.Button button1Add;
        private System.Windows.Forms.Button bttbgotohome;
        private System.Windows.Forms.DataGridView dataGridView1Deposit;
        private BankCrystalReportDataSet4 bankCrystalReportDataSet4;
        private System.Windows.Forms.BindingSource depositBindingSource;
        private BankCrystalReportDataSet4TableAdapters.DepositTableAdapter depositTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn accCheckedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn begBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4Withdraw;
        private System.Windows.Forms.Button button3Branch;
        private System.Windows.Forms.Button button1Client;
        private System.Windows.Forms.Button bttnX;
    }
}