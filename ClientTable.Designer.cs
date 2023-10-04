namespace BankCReport
{
    partial class ClientTable
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
            this.lblClientTitle = new System.Windows.Forms.Label();
            this.bttnCGotoHom = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblCAddress = new System.Windows.Forms.Label();
            this.lbldateOfBirth = new System.Windows.Forms.Label();
            this.lbleGender = new System.Windows.Forms.Label();
            this.textBox1CName = new System.Windows.Forms.TextBox();
            this.textBox2CAdd = new System.Windows.Forms.TextBox();
            this.dateTimeClient = new System.Windows.Forms.DateTimePicker();
            this.radioButton1Male = new System.Windows.Forms.RadioButton();
            this.radioButton2Female = new System.Windows.Forms.RadioButton();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.textBox3BrancID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankCrystalReportDataSet2 = new BankCReport.BankCrystalReportDataSet2();
            this.clienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankCrystalReportDataSet1 = new BankCReport.BankCrystalReportDataSet1();
            this.clienTableAdapter = new BankCReport.BankCrystalReportDataSet1TableAdapters.ClienTableAdapter();
            this.textBoxPhoto = new System.Windows.Forms.TextBox();
            this.bttnUpload = new System.Windows.Forms.Button();
            this.clienTableAdapter1 = new BankCReport.BankCrystalReportDataSet2TableAdapters.ClienTableAdapter();
            this.pictureBox1Photo = new System.Windows.Forms.PictureBox();
            this.button1Refresh = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4Withdraw = new System.Windows.Forms.Button();
            this.button3Deposit = new System.Windows.Forms.Button();
            this.button1Branch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttnX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankCrystalReportDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankCrystalReportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Photo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientTitle
            // 
            this.lblClientTitle.AutoSize = true;
            this.lblClientTitle.BackColor = System.Drawing.Color.SeaGreen;
            this.lblClientTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientTitle.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblClientTitle.Location = new System.Drawing.Point(521, 49);
            this.lblClientTitle.Name = "lblClientTitle";
            this.lblClientTitle.Size = new System.Drawing.Size(368, 32);
            this.lblClientTitle.TabIndex = 0;
            this.lblClientTitle.Text = "This Page for Client Table";
            // 
            // bttnCGotoHom
            // 
            this.bttnCGotoHom.BackColor = System.Drawing.Color.PowderBlue;
            this.bttnCGotoHom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCGotoHom.Location = new System.Drawing.Point(19, 384);
            this.bttnCGotoHom.Name = "bttnCGotoHom";
            this.bttnCGotoHom.Size = new System.Drawing.Size(216, 41);
            this.bttnCGotoHom.TabIndex = 1;
            this.bttnCGotoHom.Text = "Click Go to Home";
            this.bttnCGotoHom.UseVisualStyleBackColor = false;
            this.bttnCGotoHom.Click += new System.EventHandler(this.bttnCGotoHom_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.Black;
            this.lblClientName.Location = new System.Drawing.Point(293, 128);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(119, 25);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "Client Name";
            // 
            // lblCAddress
            // 
            this.lblCAddress.AutoSize = true;
            this.lblCAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAddress.Location = new System.Drawing.Point(293, 173);
            this.lblCAddress.Name = "lblCAddress";
            this.lblCAddress.Size = new System.Drawing.Size(140, 25);
            this.lblCAddress.TabIndex = 3;
            this.lblCAddress.Text = "Client Address";
            // 
            // lbldateOfBirth
            // 
            this.lbldateOfBirth.AutoSize = true;
            this.lbldateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateOfBirth.Location = new System.Drawing.Point(293, 220);
            this.lbldateOfBirth.Name = "lbldateOfBirth";
            this.lbldateOfBirth.Size = new System.Drawing.Size(123, 25);
            this.lbldateOfBirth.TabIndex = 4;
            this.lbldateOfBirth.Text = "Date Of Birth";
            // 
            // lbleGender
            // 
            this.lbleGender.AutoSize = true;
            this.lbleGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleGender.Location = new System.Drawing.Point(293, 269);
            this.lbleGender.Name = "lbleGender";
            this.lbleGender.Size = new System.Drawing.Size(77, 25);
            this.lbleGender.TabIndex = 5;
            this.lbleGender.Text = "Gender";
            // 
            // textBox1CName
            // 
            this.textBox1CName.Location = new System.Drawing.Point(448, 129);
            this.textBox1CName.Name = "textBox1CName";
            this.textBox1CName.Size = new System.Drawing.Size(194, 26);
            this.textBox1CName.TabIndex = 6;
            // 
            // textBox2CAdd
            // 
            this.textBox2CAdd.Location = new System.Drawing.Point(448, 171);
            this.textBox2CAdd.Name = "textBox2CAdd";
            this.textBox2CAdd.Size = new System.Drawing.Size(193, 26);
            this.textBox2CAdd.TabIndex = 7;
            // 
            // dateTimeClient
            // 
            this.dateTimeClient.Location = new System.Drawing.Point(448, 217);
            this.dateTimeClient.Name = "dateTimeClient";
            this.dateTimeClient.Size = new System.Drawing.Size(193, 26);
            this.dateTimeClient.TabIndex = 8;
            // 
            // radioButton1Male
            // 
            this.radioButton1Male.AutoSize = true;
            this.radioButton1Male.Location = new System.Drawing.Point(448, 267);
            this.radioButton1Male.Name = "radioButton1Male";
            this.radioButton1Male.Size = new System.Drawing.Size(68, 24);
            this.radioButton1Male.TabIndex = 9;
            this.radioButton1Male.TabStop = true;
            this.radioButton1Male.Text = "Male";
            this.radioButton1Male.UseVisualStyleBackColor = true;
            // 
            // radioButton2Female
            // 
            this.radioButton2Female.AutoSize = true;
            this.radioButton2Female.Location = new System.Drawing.Point(552, 267);
            this.radioButton2Female.Name = "radioButton2Female";
            this.radioButton2Female.Size = new System.Drawing.Size(87, 24);
            this.radioButton2Female.TabIndex = 10;
            this.radioButton2Female.TabStop = true;
            this.radioButton2Female.Text = "Female";
            this.radioButton2Female.UseVisualStyleBackColor = true;
            // 
            // bttnAdd
            // 
            this.bttnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAdd.ForeColor = System.Drawing.Color.Blue;
            this.bttnAdd.Location = new System.Drawing.Point(1071, 241);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(129, 44);
            this.bttnAdd.TabIndex = 15;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // lblBranchID
            // 
            this.lblBranchID.AutoSize = true;
            this.lblBranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchID.Location = new System.Drawing.Point(293, 320);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(98, 25);
            this.lblBranchID.TabIndex = 16;
            this.lblBranchID.Text = "Branch ID";
            // 
            // textBox3BrancID
            // 
            this.textBox3BrancID.Location = new System.Drawing.Point(448, 313);
            this.textBox3BrancID.Multiline = true;
            this.textBox3BrancID.Name = "textBox3BrancID";
            this.textBox3BrancID.Size = new System.Drawing.Size(191, 29);
            this.textBox3BrancID.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienIDDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.cAddressDataGridViewTextBoxColumn,
            this.cDOBDataGridViewTextBoxColumn,
            this.cGenderDataGridViewTextBoxColumn,
            this.cPhotoDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(273, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(930, 203);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clienIDDataGridViewTextBoxColumn
            // 
            this.clienIDDataGridViewTextBoxColumn.DataPropertyName = "ClienID";
            this.clienIDDataGridViewTextBoxColumn.HeaderText = "ClienID";
            this.clienIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clienIDDataGridViewTextBoxColumn.Name = "clienIDDataGridViewTextBoxColumn";
            this.clienIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "CName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "CName";
            this.cNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cAddressDataGridViewTextBoxColumn
            // 
            this.cAddressDataGridViewTextBoxColumn.DataPropertyName = "CAddress";
            this.cAddressDataGridViewTextBoxColumn.HeaderText = "CAddress";
            this.cAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cAddressDataGridViewTextBoxColumn.Name = "cAddressDataGridViewTextBoxColumn";
            this.cAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // cDOBDataGridViewTextBoxColumn
            // 
            this.cDOBDataGridViewTextBoxColumn.DataPropertyName = "CDOB";
            this.cDOBDataGridViewTextBoxColumn.HeaderText = "CDOB";
            this.cDOBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cDOBDataGridViewTextBoxColumn.Name = "cDOBDataGridViewTextBoxColumn";
            this.cDOBDataGridViewTextBoxColumn.Width = 150;
            // 
            // cGenderDataGridViewTextBoxColumn
            // 
            this.cGenderDataGridViewTextBoxColumn.DataPropertyName = "CGender";
            this.cGenderDataGridViewTextBoxColumn.HeaderText = "CGender";
            this.cGenderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cGenderDataGridViewTextBoxColumn.Name = "cGenderDataGridViewTextBoxColumn";
            this.cGenderDataGridViewTextBoxColumn.Width = 150;
            // 
            // cPhotoDataGridViewTextBoxColumn
            // 
            this.cPhotoDataGridViewTextBoxColumn.DataPropertyName = "CPhoto";
            this.cPhotoDataGridViewTextBoxColumn.HeaderText = "CPhoto";
            this.cPhotoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cPhotoDataGridViewTextBoxColumn.Name = "cPhotoDataGridViewTextBoxColumn";
            this.cPhotoDataGridViewTextBoxColumn.Width = 150;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // clienBindingSource1
            // 
            this.clienBindingSource1.DataMember = "Clien";
            this.clienBindingSource1.DataSource = this.bankCrystalReportDataSet2;
            // 
            // bankCrystalReportDataSet2
            // 
            this.bankCrystalReportDataSet2.DataSetName = "BankCrystalReportDataSet2";
            this.bankCrystalReportDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienBindingSource
            // 
            this.clienBindingSource.DataMember = "Clien";
            this.clienBindingSource.DataSource = this.bankCrystalReportDataSet1;
            // 
            // bankCrystalReportDataSet1
            // 
            this.bankCrystalReportDataSet1.DataSetName = "BankCrystalReportDataSet1";
            this.bankCrystalReportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienTableAdapter
            // 
            this.clienTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxPhoto
            // 
            this.textBoxPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPhoto.Location = new System.Drawing.Point(744, 242);
            this.textBoxPhoto.Multiline = true;
            this.textBoxPhoto.Name = "textBoxPhoto";
            this.textBoxPhoto.Size = new System.Drawing.Size(201, 43);
            this.textBoxPhoto.TabIndex = 19;
            // 
            // bttnUpload
            // 
            this.bttnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpload.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttnUpload.Location = new System.Drawing.Point(760, 298);
            this.bttnUpload.Name = "bttnUpload";
            this.bttnUpload.Size = new System.Drawing.Size(173, 44);
            this.bttnUpload.TabIndex = 21;
            this.bttnUpload.Text = "Upload Photo";
            this.bttnUpload.UseVisualStyleBackColor = false;
            this.bttnUpload.Click += new System.EventHandler(this.bttnUpload_Click);
            // 
            // clienTableAdapter1
            // 
            this.clienTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1Photo
            // 
            this.pictureBox1Photo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1Photo.Location = new System.Drawing.Point(744, 128);
            this.pictureBox1Photo.Name = "pictureBox1Photo";
            this.pictureBox1Photo.Size = new System.Drawing.Size(201, 113);
            this.pictureBox1Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Photo.TabIndex = 20;
            this.pictureBox1Photo.TabStop = false;
            // 
            // button1Refresh
            // 
            this.button1Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Refresh.Location = new System.Drawing.Point(1071, 298);
            this.button1Refresh.Name = "button1Refresh";
            this.button1Refresh.Size = new System.Drawing.Size(129, 44);
            this.button1Refresh.TabIndex = 22;
            this.button1Refresh.Text = "Refresh";
            this.button1Refresh.UseVisualStyleBackColor = false;
            this.button1Refresh.Click += new System.EventHandler(this.button1Refresh_Click);
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.bttnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdate.ForeColor = System.Drawing.Color.Blue;
            this.bttnUpdate.Location = new System.Drawing.Point(1071, 127);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(129, 44);
            this.bttnUpdate.TabIndex = 23;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = false;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelete.Location = new System.Drawing.Point(1071, 192);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(129, 39);
            this.bttnDelete.TabIndex = 24;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.button4Withdraw);
            this.panel1.Controls.Add(this.button3Deposit);
            this.panel1.Controls.Add(this.button1Branch);
            this.panel1.Controls.Add(this.bttnCGotoHom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 600);
            this.panel1.TabIndex = 25;
            // 
            // button4Withdraw
            // 
            this.button4Withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Withdraw.Location = new System.Drawing.Point(19, 303);
            this.button4Withdraw.Name = "button4Withdraw";
            this.button4Withdraw.Size = new System.Drawing.Size(216, 42);
            this.button4Withdraw.TabIndex = 9;
            this.button4Withdraw.Text = "Withdraw Table";
            this.button4Withdraw.UseVisualStyleBackColor = true;
            this.button4Withdraw.Click += new System.EventHandler(this.button4Withdraw_Click);
            // 
            // button3Deposit
            // 
            this.button3Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Deposit.Location = new System.Drawing.Point(19, 217);
            this.button3Deposit.Name = "button3Deposit";
            this.button3Deposit.Size = new System.Drawing.Size(216, 43);
            this.button3Deposit.TabIndex = 8;
            this.button3Deposit.Text = "Deposit Table";
            this.button3Deposit.UseVisualStyleBackColor = true;
            this.button3Deposit.Click += new System.EventHandler(this.button3Deposit_Click);
            // 
            // button1Branch
            // 
            this.button1Branch.BackColor = System.Drawing.Color.Transparent;
            this.button1Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Branch.Location = new System.Drawing.Point(19, 130);
            this.button1Branch.Name = "button1Branch";
            this.button1Branch.Size = new System.Drawing.Size(216, 45);
            this.button1Branch.TabIndex = 6;
            this.button1Branch.Text = "Branch Table";
            this.button1Branch.UseVisualStyleBackColor = false;
            this.button1Branch.Click += new System.EventHandler(this.button1Branch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.bttnX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(254, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 49);
            this.panel2.TabIndex = 26;
            // 
            // bttnX
            // 
            this.bttnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnX.Location = new System.Drawing.Point(973, 2);
            this.bttnX.Name = "bttnX";
            this.bttnX.Size = new System.Drawing.Size(68, 46);
            this.bttnX.TabIndex = 0;
            this.bttnX.Text = "X";
            this.bttnX.UseVisualStyleBackColor = true;
            this.bttnX.Click += new System.EventHandler(this.bttnX_Click);
            // 
            // ClientTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1295, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.button1Refresh);
            this.Controls.Add(this.bttnUpload);
            this.Controls.Add(this.pictureBox1Photo);
            this.Controls.Add(this.textBoxPhoto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3BrancID);
            this.Controls.Add(this.lblBranchID);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.radioButton2Female);
            this.Controls.Add(this.radioButton1Male);
            this.Controls.Add(this.dateTimeClient);
            this.Controls.Add(this.textBox2CAdd);
            this.Controls.Add(this.textBox1CName);
            this.Controls.Add(this.lbleGender);
            this.Controls.Add(this.lbldateOfBirth);
            this.Controls.Add(this.lblCAddress);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblClientTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientTable";
            this.Text = "ClientTable";
            this.Load += new System.EventHandler(this.ClientTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankCrystalReportDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankCrystalReportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Photo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientTitle;
        private System.Windows.Forms.Button bttnCGotoHom;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblCAddress;
        private System.Windows.Forms.Label lbldateOfBirth;
        private System.Windows.Forms.Label lbleGender;
        private System.Windows.Forms.TextBox textBox1CName;
        private System.Windows.Forms.TextBox textBox2CAdd;
        private System.Windows.Forms.DateTimePicker dateTimeClient;
        private System.Windows.Forms.RadioButton radioButton1Male;
        private System.Windows.Forms.RadioButton radioButton2Female;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Label lblBranchID;
        private System.Windows.Forms.TextBox textBox3BrancID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BankCrystalReportDataSet1 bankCrystalReportDataSet1;
        private System.Windows.Forms.BindingSource clienBindingSource;
        private BankCrystalReportDataSet1TableAdapters.ClienTableAdapter clienTableAdapter;
        private System.Windows.Forms.TextBox textBoxPhoto;
        private System.Windows.Forms.PictureBox pictureBox1Photo;
        private System.Windows.Forms.Button bttnUpload;
        private BankCrystalReportDataSet2 bankCrystalReportDataSet2;
        private System.Windows.Forms.BindingSource clienBindingSource1;
        private BankCrystalReportDataSet2TableAdapters.ClienTableAdapter clienTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1Refresh;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4Withdraw;
        private System.Windows.Forms.Button button3Deposit;
        private System.Windows.Forms.Button button1Branch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttnX;
    }
}