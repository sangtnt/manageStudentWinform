namespace StudentManagement
{
    partial class AddStudentForm
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
            this.StuId = new System.Windows.Forms.Label();
            this.IDCombobox = new System.Windows.Forms.ComboBox();
            this.StuName = new System.Windows.Forms.Label();
            this.StuBatch = new System.Windows.Forms.Label();
            this.StuAddress = new System.Windows.Forms.Label();
            this.StuEmail = new System.Windows.Forms.Label();
            this.DoB = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.Batchtxt = new System.Windows.Forms.TextBox();
            this.submitStu = new System.Windows.Forms.Button();
            this.DoBtxt = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // StuId
            // 
            this.StuId.AutoSize = true;
            this.StuId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StuId.Location = new System.Drawing.Point(12, 30);
            this.StuId.Name = "StuId";
            this.StuId.Size = new System.Drawing.Size(26, 21);
            this.StuId.TabIndex = 0;
            this.StuId.Text = "Id";
            // 
            // IDCombobox
            // 
            this.IDCombobox.FormattingEnabled = true;
            this.IDCombobox.Location = new System.Drawing.Point(135, 28);
            this.IDCombobox.Name = "IDCombobox";
            this.IDCombobox.Size = new System.Drawing.Size(55, 23);
            this.IDCombobox.TabIndex = 1;
            this.IDCombobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDCombobox_KeyPress);
            // 
            // StuName
            // 
            this.StuName.AutoSize = true;
            this.StuName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StuName.Location = new System.Drawing.Point(12, 60);
            this.StuName.Name = "StuName";
            this.StuName.Size = new System.Drawing.Size(53, 21);
            this.StuName.TabIndex = 0;
            this.StuName.Text = "Name";
            // 
            // StuBatch
            // 
            this.StuBatch.AutoSize = true;
            this.StuBatch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StuBatch.Location = new System.Drawing.Point(12, 180);
            this.StuBatch.Name = "StuBatch";
            this.StuBatch.Size = new System.Drawing.Size(53, 21);
            this.StuBatch.TabIndex = 0;
            this.StuBatch.Text = "Batch";
            // 
            // StuAddress
            // 
            this.StuAddress.AutoSize = true;
            this.StuAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StuAddress.Location = new System.Drawing.Point(12, 150);
            this.StuAddress.Name = "StuAddress";
            this.StuAddress.Size = new System.Drawing.Size(73, 21);
            this.StuAddress.TabIndex = 0;
            this.StuAddress.Text = "Address";
            // 
            // StuEmail
            // 
            this.StuEmail.AutoSize = true;
            this.StuEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StuEmail.Location = new System.Drawing.Point(12, 120);
            this.StuEmail.Name = "StuEmail";
            this.StuEmail.Size = new System.Drawing.Size(51, 21);
            this.StuEmail.TabIndex = 0;
            this.StuEmail.Text = "Email";
            // 
            // DoB
            // 
            this.DoB.AutoSize = true;
            this.DoB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoB.Location = new System.Drawing.Point(12, 90);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(110, 21);
            this.DoB.TabIndex = 0;
            this.DoB.Text = "Date Of Birth";
            // 
            // Idtxt
            // 
            this.Idtxt.Location = new System.Drawing.Point(196, 28);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(139, 23);
            this.Idtxt.TabIndex = 2;
            this.Idtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(135, 58);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(200, 23);
            this.Nametxt.TabIndex = 2;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(135, 118);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(200, 23);
            this.Emailtxt.TabIndex = 2;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Location = new System.Drawing.Point(135, 148);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(200, 23);
            this.Addresstxt.TabIndex = 2;
            // 
            // Batchtxt
            // 
            this.Batchtxt.Location = new System.Drawing.Point(135, 178);
            this.Batchtxt.Name = "Batchtxt";
            this.Batchtxt.Size = new System.Drawing.Size(200, 23);
            this.Batchtxt.TabIndex = 2;
            // 
            // submitStu
            // 
            this.submitStu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitStu.Location = new System.Drawing.Point(135, 207);
            this.submitStu.Name = "submitStu";
            this.submitStu.Size = new System.Drawing.Size(75, 23);
            this.submitStu.TabIndex = 3;
            this.submitStu.Text = "Finish";
            this.submitStu.UseVisualStyleBackColor = true;
            this.submitStu.Click += new System.EventHandler(this.submitStu_Click);
            // 
            // DoBtxt
            // 
            this.DoBtxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DoBtxt.Location = new System.Drawing.Point(135, 87);
            this.DoBtxt.Name = "DoBtxt";
            this.DoBtxt.Size = new System.Drawing.Size(200, 23);
            this.DoBtxt.TabIndex = 4;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 247);
            this.Controls.Add(this.DoBtxt);
            this.Controls.Add(this.submitStu);
            this.Controls.Add(this.Batchtxt);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.DoB);
            this.Controls.Add(this.StuEmail);
            this.Controls.Add(this.StuAddress);
            this.Controls.Add(this.StuBatch);
            this.Controls.Add(this.StuName);
            this.Controls.Add(this.IDCombobox);
            this.Controls.Add(this.StuId);
            this.Name = "AddStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StuId;
        private System.Windows.Forms.ComboBox IDCombobox;
        private System.Windows.Forms.Label StuName;
        private System.Windows.Forms.Label StuBatch;
        private System.Windows.Forms.Label StuAddress;
        private System.Windows.Forms.Label StuEmail;
        private System.Windows.Forms.Label DoB;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.TextBox Batchtxt;
        private System.Windows.Forms.Button submitStu;
        private System.Windows.Forms.DateTimePicker DoBtxt;
    }
}