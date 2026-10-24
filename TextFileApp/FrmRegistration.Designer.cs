namespace TextFileApp
{
    partial class FrmRegistration
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
            label1 = new Label();
            label2 = new Label();
            cmbProgram = new ComboBox();
            txtStudentNo = new TextBox();
            dtpBirthday = new DateTimePicker();
            btnRegister = new Button();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbGender = new ComboBox();
            txtFirstName = new TextBox();
            label9 = new Label();
            txtMI = new TextBox();
            label10 = new Label();
            txtContactNo = new TextBox();
            btnRecord = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 63);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // cmbProgram
            // 
            cmbProgram.AutoCompleteCustomSource.AddRange(new string[] { "BS-Information Technology", "BS-Computer Engineering", "BS-Information System", "BS-Computer Science", "BS-Tourism Management", "BS-Hotel and Restaurant Management", "BS-Business Administration", "BS-Psychology", "BS-Criminology" });
            cmbProgram.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Items.AddRange(new object[] { "BS-Information Technology", "BS-Computer Engineering", "BS-Information System", "BS-Computer Science", "BS-Tourism Management", "BS-Hotel and Restaurant Management", "BS-Business Administration", "BS-Psychology", "BS-Criminology" });
            cmbProgram.Location = new Point(441, 55);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(319, 25);
            cmbProgram.TabIndex = 2;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentNo.Location = new Point(118, 55);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(214, 25);
            txtStudentNo.TabIndex = 3;
            // 
            // dtpBirthday
            // 
            dtpBirthday.CalendarFont = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthday.Location = new Point(118, 148);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(214, 23);
            dtpBirthday.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkGray;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.Location = new Point(263, 198);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(133, 29);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 94);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(118, 86);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(214, 25);
            txtLastName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 125);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 8;
            label4.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(118, 117);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(163, 25);
            txtAge.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 154);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 10;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(354, 94);
            label6.Name = "label6";
            label6.Size = new Size(81, 17);
            label6.TabIndex = 11;
            label6.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(369, 63);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 12;
            label7.Text = "Program";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(378, 125);
            label8.Name = "label8";
            label8.Size = new Size(57, 17);
            label8.TabIndex = 13;
            label8.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(441, 117);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(146, 25);
            cmbGender.TabIndex = 14;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(441, 86);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(214, 25);
            txtFirstName.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(670, 94);
            label9.Name = "label9";
            label9.Size = new Size(33, 17);
            label9.TabIndex = 16;
            label9.Text = "M.I.";
            // 
            // txtMI
            // 
            txtMI.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMI.Location = new Point(709, 86);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(51, 25);
            txtMI.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(347, 152);
            label10.Name = "label10";
            label10.Size = new Size(88, 17);
            label10.TabIndex = 18;
            label10.Text = "Contact No.";
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNo.Location = new Point(441, 148);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(214, 25);
            txtContactNo.TabIndex = 19;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.DarkGray;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRecord.Location = new Point(402, 198);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(133, 29);
            btnRecord.TabIndex = 20;
            btnRecord.Text = "Records";
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 248);
            Controls.Add(btnRecord);
            Controls.Add(txtContactNo);
            Controls.Add(label10);
            Controls.Add(txtMI);
            Controls.Add(label9);
            Controls.Add(txtFirstName);
            Controls.Add(cmbGender);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(btnRegister);
            Controls.Add(dtpBirthday);
            Controls.Add(txtStudentNo);
            Controls.Add(cmbProgram);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbProgram;
        private TextBox txtStudentNo;
        private DateTimePicker dtpBirthday;
        private Button btnRegister;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtAge;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbGender;
        private TextBox txtFirstName;
        private Label label9;
        private TextBox txtMI;
        private Label label10;
        private TextBox txtContactNo;
        private Button btnRecord;
    }
}