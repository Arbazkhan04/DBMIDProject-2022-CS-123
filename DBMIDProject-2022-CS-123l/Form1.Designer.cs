namespace DBMIDProject_2022_CS_123l
{
    partial class Form1
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.studentPage = new System.Windows.Forms.TabPage();
            this.regNof = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.emailf = new MaterialSkin.Controls.MaterialLabel();
            this.email2f = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.contctf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.fname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.advisorPage = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.studentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.studentPage);
            this.materialTabControl1.Controls.Add(this.advisorPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 124);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1274, 579);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // studentPage
            // 
            this.studentPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.studentPage.Controls.Add(this.dataGridView1);
            this.studentPage.Controls.Add(this.materialFlatButton3);
            this.studentPage.Controls.Add(this.materialFlatButton2);
            this.studentPage.Controls.Add(this.materialFlatButton1);
            this.studentPage.Controls.Add(this.comboBox1);
            this.studentPage.Controls.Add(this.materialRaisedButton1);
            this.studentPage.Controls.Add(this.regNof);
            this.studentPage.Controls.Add(this.materialLabel8);
            this.studentPage.Controls.Add(this.materialLabel7);
            this.studentPage.Controls.Add(this.materialLabel6);
            this.studentPage.Controls.Add(this.materialLabel5);
            this.studentPage.Controls.Add(this.dateTimePicker1);
            this.studentPage.Controls.Add(this.emailf);
            this.studentPage.Controls.Add(this.email2f);
            this.studentPage.Controls.Add(this.contctf);
            this.studentPage.Controls.Add(this.materialLabel4);
            this.studentPage.Controls.Add(this.materialLabel3);
            this.studentPage.Controls.Add(this.lname);
            this.studentPage.Controls.Add(this.materialLabel2);
            this.studentPage.Controls.Add(this.fname);
            this.studentPage.Location = new System.Drawing.Point(4, 22);
            this.studentPage.Name = "studentPage";
            this.studentPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentPage.Size = new System.Drawing.Size(1266, 553);
            this.studentPage.TabIndex = 1;
            this.studentPage.Text = "Manage Student";
            this.studentPage.Click += new System.EventHandler(this.studentPage_Click);
            // 
            // regNof
            // 
            this.regNof.Depth = 0;
            this.regNof.Hint = "";
            this.regNof.Location = new System.Drawing.Point(189, 431);
            this.regNof.MaxLength = 32767;
            this.regNof.MouseState = MaterialSkin.MouseState.HOVER;
            this.regNof.Name = "regNof";
            this.regNof.PasswordChar = '\0';
            this.regNof.SelectedText = "";
            this.regNof.SelectionLength = 0;
            this.regNof.SelectionStart = 0;
            this.regNof.Size = new System.Drawing.Size(201, 23);
            this.regNof.TabIndex = 15;
            this.regNof.TabStop = false;
            this.regNof.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(70, 431);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(110, 19);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "RegistrationNo";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(87, 397);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(56, 19);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Gender";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(87, 397);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(0, 19);
            this.materialLabel6.TabIndex = 12;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(87, 347);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(93, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Date of Birth";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 347);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // emailf
            // 
            this.emailf.AutoSize = true;
            this.emailf.Depth = 0;
            this.emailf.Font = new System.Drawing.Font("Roboto", 11F);
            this.emailf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emailf.Location = new System.Drawing.Point(87, 307);
            this.emailf.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailf.Name = "emailf";
            this.emailf.Size = new System.Drawing.Size(47, 19);
            this.emailf.TabIndex = 8;
            this.emailf.Text = "Email";
            this.emailf.Click += new System.EventHandler(this.emailf_Click);
            // 
            // email2f
            // 
            this.email2f.Depth = 0;
            this.email2f.Hint = "";
            this.email2f.Location = new System.Drawing.Point(188, 307);
            this.email2f.MaxLength = 32767;
            this.email2f.MouseState = MaterialSkin.MouseState.HOVER;
            this.email2f.Name = "email2f";
            this.email2f.PasswordChar = '\0';
            this.email2f.SelectedText = "";
            this.email2f.SelectionLength = 0;
            this.email2f.SelectionStart = 0;
            this.email2f.Size = new System.Drawing.Size(201, 23);
            this.email2f.TabIndex = 7;
            this.email2f.TabStop = false;
            this.email2f.UseSystemPasswordChar = false;
            this.email2f.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // contctf
            // 
            this.contctf.Depth = 0;
            this.contctf.Hint = "";
            this.contctf.Location = new System.Drawing.Point(188, 259);
            this.contctf.MaxLength = 32767;
            this.contctf.MouseState = MaterialSkin.MouseState.HOVER;
            this.contctf.Name = "contctf";
            this.contctf.PasswordChar = '\0';
            this.contctf.SelectedText = "";
            this.contctf.SelectionLength = 0;
            this.contctf.SelectionStart = 0;
            this.contctf.Size = new System.Drawing.Size(201, 23);
            this.contctf.TabIndex = 6;
            this.contctf.TabStop = false;
            this.contctf.UseSystemPasswordChar = false;
            this.contctf.Click += new System.EventHandler(this.contctf_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(87, 263);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(62, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Contact";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(87, 214);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Last Name";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // lname
            // 
            this.lname.Depth = 0;
            this.lname.Hint = "";
            this.lname.Location = new System.Drawing.Point(188, 210);
            this.lname.MaxLength = 32767;
            this.lname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lname.Name = "lname";
            this.lname.PasswordChar = '\0';
            this.lname.SelectedText = "";
            this.lname.SelectionLength = 0;
            this.lname.SelectionStart = 0;
            this.lname.Size = new System.Drawing.Size(201, 23);
            this.lname.TabIndex = 3;
            this.lname.TabStop = false;
            this.lname.UseSystemPasswordChar = false;
            this.lname.Click += new System.EventHandler(this.lname_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(87, 168);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "First Name";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // fname
            // 
            this.fname.Depth = 0;
            this.fname.Hint = "";
            this.fname.Location = new System.Drawing.Point(188, 164);
            this.fname.MaxLength = 32767;
            this.fname.MouseState = MaterialSkin.MouseState.HOVER;
            this.fname.Name = "fname";
            this.fname.PasswordChar = '\0';
            this.fname.SelectedText = "";
            this.fname.SelectionLength = 0;
            this.fname.SelectionStart = 0;
            this.fname.Size = new System.Drawing.Size(201, 23);
            this.fname.TabIndex = 0;
            this.fname.TabStop = false;
            this.fname.UseSystemPasswordChar = false;
            this.fname.Click += new System.EventHandler(this.fname_Click);
            // 
            // advisorPage
            // 
            this.advisorPage.Location = new System.Drawing.Point(4, 22);
            this.advisorPage.Name = "advisorPage";
            this.advisorPage.Padding = new System.Windows.Forms.Padding(3);
            this.advisorPage.Size = new System.Drawing.Size(1091, 553);
            this.advisorPage.TabIndex = 2;
            this.advisorPage.Text = "Manage Advisor";
            this.advisorPage.UseVisualStyleBackColor = true;
            this.advisorPage.Click += new System.EventHandler(this.advisorPage_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1438, 36);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(179, 480);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(110, 36);
            this.materialRaisedButton1.TabIndex = 16;
            this.materialRaisedButton1.Text = "Submit Data";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 398);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(153, 94);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(112, 36);
            this.materialFlatButton1.TabIndex = 19;
            this.materialFlatButton1.Text = "Add Records";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(518, 29);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(181, 36);
            this.materialFlatButton2.TabIndex = 20;
            this.materialFlatButton2.Text = "Manage Student Data";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(735, 108);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(118, 36);
            this.materialFlatButton3.TabIndex = 21;
            this.materialFlatButton3.Text = "View Records";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 309);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 715);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Form1";
            this.Text = "Project Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.studentPage.ResumeLayout(false);
            this.studentPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage studentPage;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage advisorPage;
        private MaterialSkin.Controls.MaterialSingleLineTextField fname;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField lname;
        private MaterialSkin.Controls.MaterialSingleLineTextField contctf;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField email2f;
        private MaterialSkin.Controls.MaterialLabel emailf;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField regNof;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

