namespace BankCReport
{
    partial class withdraw
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnGotoHome = new System.Windows.Forms.Button();
            this.lblWitamount = new System.Windows.Forms.Label();
            this.lblAccNo = new System.Windows.Forms.Label();
            this.textBox1WitAmount = new System.Windows.Forms.TextBox();
            this.textBox2AccNo = new System.Windows.Forms.TextBox();
            this.dataGridView1Witdraw = new System.Windows.Forms.DataGridView();
            this.withdrawIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.witAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.withdrawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankCrystalReportDataSet5 = new BankCReport.BankCrystalReportDataSet5();
            this.withdrawTableAdapter = new BankCReport.BankCrystalReportDataSet5TableAdapters.WithdrawTableAdapter();
            this.bankCrystalReportDataSet1 = new BankCReport.BankCrystalReportDataSet();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3Deposit = new System.Windows.Forms.Button();
            this.button1Branch = new System.Windows.Forms.Button();
            this.button2Client = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Witdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankCrystalReportDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankCrystalReportDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(468, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "This Table For Withdraw";
            // 
            // bttnSave
            // 
            this.bttnSave.BackColor = System.Drawing.Color.MediumTurquoise;
            this.bttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.ForeColor = System.Drawing.Color.Blue;
            this.bttnSave.Location = new System.Drawing.Point(553, 236);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(106, 38);
            this.bttnSave.TabIndex = 1;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = false;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnGotoHome
            // 
            this.bttnGotoHome.BackColor = System.Drawing.Color.LightBlue;
            this.bttnGotoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGotoHome.ForeColor = System.Drawing.Color.IndianRed;
            this.bttnGotoHome.Location = new System.Drawing.Point(12, 369);
            this.bttnGotoHome.Name = "bttnGotoHome";
            this.bttnGotoHome.Size = new System.Drawing.Size(224, 40);
            this.bttnGotoHome.TabIndex = 2;
            this.bttnGotoHome.Text = "Click Go to Home";
            this.bttnGotoHome.UseVisualStyleBackColor = false;
            this.bttnGotoHome.Click += new System.EventHandler(this.bttnGotoHome_Click);
            // 
            // lblWitamount
            // 
            this.lblWitamount.AutoSize = true;
            this.lblWitamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWitamount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWitamount.Location = new System.Drawing.Point(282, 136);
            this.lblWitamount.Name = "lblWitamount";
            this.lblWitamount.Size = new System.Drawing.Size(172, 25);
            this.lblWitamount.TabIndex = 3;
            this.lblWitamount.Text = "Withdeaw Amount";
            // 
            // lblAccNo
            // 
            this.lblAccNo.AutoSize = true;
            this.lblAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccNo.Location = new System.Drawing.Point(282, 186);
            this.lblAccNo.Name = "lblAccNo";
            this.lblAccNo.Size = new System.Drawing.Size(114, 25);
            this.lblAccNo.TabIndex = 4;
            this.lblAccNo.Text = "Account No";
            // 
            // textBox1WitAmount
            // 
            this.textBox1WitAmount.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1WitAmount.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1WitAmount.Location = new System.Drawing.Point(484, 137);
            this.textBox1WitAmount.Name = "textBox1WitAmount";
            this.textBox1WitAmount.Size = new System.Drawing.Size(263, 26);
            this.textBox1WitAmount.TabIndex = 5;
            // 
            // textBox2AccNo
            // 
            this.textBox2AccNo.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2AccNo.Location = new System.Drawing.Point(484, 187);
            this.textBox2AccNo.Name = "textBox2AccNo";
            this.textBox2AccNo.Size = new System.Drawing.Size(263, 26);
            this.textBox2AccNo.TabIndex = 6;
            // 
            // dataGridView1Witdraw
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Crimson;
            this.dataGridView1Witdraw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1Witdraw.AutoGenerateColumns = false;
            this.dataGridView1Witdraw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1Witdraw.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1Witdraw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1Witdraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Witdraw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.withdrawIDDataGridViewTextBoxColumn,
            this.witAmountDataGridViewTextBoxColumn,
            this.accNumberDataGridViewTextBoxColumn});
            this.dataGridView1Witdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1Witdraw.DataSource = this.withdrawBindingSource;
            this.dataGridView1Witdraw.Location = new System.Drawing.Point(287, 289);
            this.dataGridView1Witdraw.Name = "dataGridView1Witdraw";
            this.dataGridView1Witdraw.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1Witdraw.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1Witdraw.RowTemplate.Height = 28;
            this.dataGridView1Witdraw.Size = new System.Drawing.Size(686, 265);
            this.dataGridView1Witdraw.TabIndex = 7;
            this.dataGridView1Witdraw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // withdrawIDDataGridViewTextBoxColumn
            // 
            this.withdrawIDDataGridViewTextBoxColumn.DataPropertyName = "WithdrawID";
            this.withdrawIDDataGridViewTextBoxColumn.HeaderText = "WithdrawID";
            this.withdrawIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.withdrawIDDataGridViewTextBoxColumn.Name = "withdrawIDDataGridViewTextBoxColumn";
            this.withdrawIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.withdrawIDDataGridViewTextBoxColumn.Width = 128;
            // 
            // witAmountDataGridViewTextBoxColumn
            // 
            this.witAmountDataGridViewTextBoxColumn.DataPropertyName = "WitAmount";
            this.witAmountDataGridViewTextBoxColumn.HeaderText = "WitAmount";
            this.witAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.witAmountDataGridViewTextBoxColumn.Name = "witAmountDataGridViewTextBoxColumn";
            this.witAmountDataGridViewTextBoxColumn.Width = 124;
            // 
            // accNumberDataGridViewTextBoxColumn
            // 
            this.accNumberDataGridViewTextBoxColumn.DataPropertyName = "AccNumber";
            this.accNumberDataGridViewTextBoxColumn.HeaderText = "AccNumber";
            this.accNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.accNumberDataGridViewTextBoxColumn.Name = "accNumberDataGridViewTextBoxColumn";
            this.accNumberDataGridViewTextBoxColumn.Width = 128;
            // 
            // withdrawBindingSource
            // 
            this.withdrawBindingSource.DataMember = "Withdraw";
            this.withdrawBindingSource.DataSource = this.bankCrystalReportDataSet5;
            // 
            // bankCrystalReportDataSet5
            // 
            this.bankCrystalReportDataSet5.DataSetName = "BankCrystalReportDataSet5";
            this.bankCrystalReportDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // withdrawTableAdapter
            // 
            this.withdrawTableAdapter.ClearBeforeFill = true;
            // 
            // bankCrystalReportDataSet1
            // 
            this.bankCrystalReportDataSet1.DataSetName = "BankCrystalReportDataSet";
            this.bankCrystalReportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bttnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttnRefresh.Location = new System.Drawing.Point(867, 236);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(106, 38);
            this.bttnRefresh.TabIndex = 8;
            this.bttnRefresh.Text = "Refresh";
            this.bttnRefresh.UseVisualStyleBackColor = false;
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.button3Deposit);
            this.panel1.Controls.Add(this.button1Branch);
            this.panel1.Controls.Add(this.button2Client);
            this.panel1.Controls.Add(this.bttnGotoHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 594);
            this.panel1.TabIndex = 9;
            // 
            // button3Deposit
            // 
            this.button3Deposit.BackColor = System.Drawing.Color.Silver;
            this.button3Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Deposit.Location = new System.Drawing.Point(12, 289);
            this.button3Deposit.Name = "button3Deposit";
            this.button3Deposit.Size = new System.Drawing.Size(224, 43);
            this.button3Deposit.TabIndex = 8;
            this.button3Deposit.Text = "DepositTable";
            this.button3Deposit.UseVisualStyleBackColor = false;
            this.button3Deposit.Click += new System.EventHandler(this.button3Deposit_Click);
            // 
            // button1Branch
            // 
            this.button1Branch.BackColor = System.Drawing.Color.Gray;
            this.button1Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Branch.Location = new System.Drawing.Point(12, 136);
            this.button1Branch.Name = "button1Branch";
            this.button1Branch.Size = new System.Drawing.Size(224, 45);
            this.button1Branch.TabIndex = 6;
            this.button1Branch.Text = "Branch Table";
            this.button1Branch.UseVisualStyleBackColor = false;
            this.button1Branch.Click += new System.EventHandler(this.button1Branch_Click);
            // 
            // button2Client
            // 
            this.button2Client.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Client.Location = new System.Drawing.Point(12, 213);
            this.button2Client.Name = "button2Client";
            this.button2Client.Size = new System.Drawing.Size(224, 43);
            this.button2Client.TabIndex = 7;
            this.button2Client.Text = "ClientTabl";
            this.button2Client.UseVisualStyleBackColor = false;
            this.button2Client.Click += new System.EventHandler(this.button2Client_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(254, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 49);
            this.panel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(753, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1082, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttnRefresh);
            this.Controls.Add(this.dataGridView1Witdraw);
            this.Controls.Add(this.textBox2AccNo);
            this.Controls.Add(this.textBox1WitAmount);
            this.Controls.Add(this.lblAccNo);
            this.Controls.Add(this.lblWitamount);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "withdraw";
            this.Text = "withdraw";
            this.Load += new System.EventHandler(this.withdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Witdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankCrystalReportDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankCrystalReportDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnGotoHome;
        private System.Windows.Forms.Label lblWitamount;
        private System.Windows.Forms.Label lblAccNo;
        private System.Windows.Forms.TextBox textBox1WitAmount;
        private System.Windows.Forms.TextBox textBox2AccNo;
        private System.Windows.Forms.DataGridView dataGridView1Witdraw;
        private BankCrystalReportDataSet5 bankCrystalReportDataSet5;
        private System.Windows.Forms.BindingSource withdrawBindingSource;
        private BankCrystalReportDataSet5TableAdapters.WithdrawTableAdapter withdrawTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn withdrawIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn witAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accNumberDataGridViewTextBoxColumn;
        private BankCrystalReportDataSet bankCrystalReportDataSet1;
        private System.Windows.Forms.Button bttnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1Branch;
        private System.Windows.Forms.Button button2Client;
        private System.Windows.Forms.Button button3Deposit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}