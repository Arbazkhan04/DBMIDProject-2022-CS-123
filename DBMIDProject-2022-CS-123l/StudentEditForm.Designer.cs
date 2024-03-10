namespace DBMIDProject_2022_CS_123l
{
    partial class StudentEditForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.regNof = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
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
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(323, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(314, 399);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(110, 36);
            this.materialRaisedButton1.TabIndex = 31;
            this.materialRaisedButton1.Text = "Submit Data";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // regNof
            // 
            this.regNof.Depth = 0;
            this.regNof.Hint = "";
            this.regNof.Location = new System.Drawing.Point(324, 350);
            this.regNof.MaxLength = 32767;
            this.regNof.MouseState = MaterialSkin.MouseState.HOVER;
            this.regNof.Name = "regNof";
            this.regNof.PasswordChar = '\0';
            this.regNof.SelectedText = "";
            this.regNof.SelectionLength = 0;
            this.regNof.SelectionStart = 0;
            this.regNof.Size = new System.Drawing.Size(201, 23);
            this.regNof.TabIndex = 30;
            this.regNof.TabStop = false;
            this.regNof.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(205, 350);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(110, 19);
            this.materialLabel8.TabIndex = 29;
            this.materialLabel8.Text = "RegistrationNo";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(222, 316);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(56, 19);
            this.materialLabel7.TabIndex = 28;
            this.materialLabel7.Text = "Gender";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(222, 266);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(93, 19);
            this.materialLabel5.TabIndex = 27;
            this.materialLabel5.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 266);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // emailf
            // 
            this.emailf.AutoSize = true;
            this.emailf.Depth = 0;
            this.emailf.Font = new System.Drawing.Font("Roboto", 11F);
            this.emailf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emailf.Location = new System.Drawing.Point(222, 226);
            this.emailf.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailf.Name = "emailf";
            this.emailf.Size = new System.Drawing.Size(47, 19);
            this.emailf.TabIndex = 25;
            this.emailf.Text = "Email";
            // 
            // email2f
            // 
            this.email2f.Depth = 0;
            this.email2f.Hint = "";
            this.email2f.Location = new System.Drawing.Point(323, 226);
            this.email2f.MaxLength = 32767;
            this.email2f.MouseState = MaterialSkin.MouseState.HOVER;
            this.email2f.Name = "email2f";
            this.email2f.PasswordChar = '\0';
            this.email2f.SelectedText = "";
            this.email2f.SelectionLength = 0;
            this.email2f.SelectionStart = 0;
            this.email2f.Size = new System.Drawing.Size(201, 23);
            this.email2f.TabIndex = 24;
            this.email2f.TabStop = false;
            this.email2f.UseSystemPasswordChar = false;
            // 
            // contctf
            // 
            this.contctf.Depth = 0;
            this.contctf.Hint = "";
            this.contctf.Location = new System.Drawing.Point(323, 178);
            this.contctf.MaxLength = 32767;
            this.contctf.MouseState = MaterialSkin.MouseState.HOVER;
            this.contctf.Name = "contctf";
            this.contctf.PasswordChar = '\0';
            this.contctf.SelectedText = "";
            this.contctf.SelectionLength = 0;
            this.contctf.SelectionStart = 0;
            this.contctf.Size = new System.Drawing.Size(201, 23);
            this.contctf.TabIndex = 23;
            this.contctf.TabStop = false;
            this.contctf.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(222, 182);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(62, 19);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "Contact";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(222, 133);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 21;
            this.materialLabel3.Text = "Last Name";
            // 
            // lname
            // 
            this.lname.Depth = 0;
            this.lname.Hint = "";
            this.lname.Location = new System.Drawing.Point(323, 129);
            this.lname.MaxLength = 32767;
            this.lname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lname.Name = "lname";
            this.lname.PasswordChar = '\0';
            this.lname.SelectedText = "";
            this.lname.SelectionLength = 0;
            this.lname.SelectionStart = 0;
            this.lname.Size = new System.Drawing.Size(201, 23);
            this.lname.TabIndex = 20;
            this.lname.TabStop = false;
            this.lname.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(222, 87);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "First Name";
            // 
            // fname
            // 
            this.fname.Depth = 0;
            this.fname.Hint = "";
            this.fname.Location = new System.Drawing.Point(323, 83);
            this.fname.MaxLength = 32767;
            this.fname.MouseState = MaterialSkin.MouseState.HOVER;
            this.fname.Name = "fname";
            this.fname.PasswordChar = '\0';
            this.fname.SelectedText = "";
            this.fname.SelectionLength = 0;
            this.fname.SelectionStart = 0;
            this.fname.Size = new System.Drawing.Size(201, 23);
            this.fname.TabIndex = 18;
            this.fname.TabStop = false;
            this.fname.UseSystemPasswordChar = false;
            // 
            // StudentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.regNof);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.emailf);
            this.Controls.Add(this.email2f);
            this.Controls.Add(this.contctf);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.fname);
            this.Name = "StudentEditForm";
            this.Text = "StudentEditForm";
            this.Load += new System.EventHandler(this.StudentEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField regNof;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel emailf;
        private MaterialSkin.Controls.MaterialSingleLineTextField email2f;
        private MaterialSkin.Controls.MaterialSingleLineTextField contctf;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField lname;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField fname;
    }
}