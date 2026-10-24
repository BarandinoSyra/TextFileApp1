namespace TextFileApp
{
    partial class FrmStudentRecord
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
            lvShowText = new ListView();
            columnHeader1 = new ColumnHeader();
            lblViewRecord = new Label();
            btnRegister = new Button();
            btnUpload = new Button();
            btnFind = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.BackColor = Color.White;
            lvShowText.BorderStyle = BorderStyle.FixedSingle;
            lvShowText.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvShowText.Font = new Font("Consolas", 10F);
            lvShowText.ForeColor = Color.Black;
            lvShowText.FullRowSelect = true;
            lvShowText.HeaderStyle = ColumnHeaderStyle.None;
            lvShowText.Location = new Point(22, 46);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(440, 280);
            lvShowText.TabIndex = 3;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 420;
            // 
            // lblViewRecord
            // 
            lblViewRecord.AutoSize = true;
            lblViewRecord.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewRecord.ForeColor = Color.Black;
            lblViewRecord.Location = new Point(22, 16);
            lblViewRecord.Name = "lblViewRecord";
            lblViewRecord.Size = new Size(123, 21);
            lblViewRecord.TabIndex = 2;
            lblViewRecord.Text = "VIEW RECORD";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkGray;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(468, 46);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(111, 33);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.DarkGray;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(468, 124);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(111, 33);
            btnUpload.TabIndex = 5;
            btnUpload.Text = "UPLOAD";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.DarkGray;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.Location = new Point(468, 85);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(111, 33);
            btnFind.TabIndex = 6;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(601, 347);
            Controls.Add(btnFind);
            Controls.Add(btnUpload);
            Controls.Add(btnRegister);
            Controls.Add(lvShowText);
            Controls.Add(lblViewRecord);
            Name = "FrmStudentRecord";
            Text = "FrmStudentRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvShowText;
        private ColumnHeader columnHeader1;
        private Label lblViewRecord;
        private Button btnRegister;
        private Button btnUpload;
        private Button btnFind;
        private OpenFileDialog openFileDialog1;
    }
}