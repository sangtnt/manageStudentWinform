namespace StudentManagement
{
    partial class AddLecturerForm
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
            this.lecId = new System.Windows.Forms.Label();
            this.lecName = new System.Windows.Forms.Label();
            this.DoB = new System.Windows.Forms.Label();
            this.lecEmail = new System.Windows.Forms.Label();
            this.lecAddress = new System.Windows.Forms.Label();
            this.lecDept = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.deptxt = new System.Windows.Forms.TextBox();
            this.DoBtxt = new System.Windows.Forms.DateTimePicker();
            this.lecSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lecId
            // 
            this.lecId.AutoSize = true;
            this.lecId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lecId.Location = new System.Drawing.Point(12, 30);
            this.lecId.Name = "lecId";
            this.lecId.Size = new System.Drawing.Size(26, 21);
            this.lecId.TabIndex = 0;
            this.lecId.Text = "Id";
            // 
            // lecName
            // 
            this.lecName.AutoSize = true;
            this.lecName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lecName.Location = new System.Drawing.Point(12, 60);
            this.lecName.Name = "lecName";
            this.lecName.Size = new System.Drawing.Size(53, 21);
            this.lecName.TabIndex = 0;
            this.lecName.Text = "Name";
            // 
            // DoB
            // 
            this.DoB.AutoSize = true;
            this.DoB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoB.Location = new System.Drawing.Point(12, 120);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(110, 21);
            this.DoB.TabIndex = 0;
            this.DoB.Text = "Date Of Birth";
            // 
            // lecEmail
            // 
            this.lecEmail.AutoSize = true;
            this.lecEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lecEmail.Location = new System.Drawing.Point(12, 90);
            this.lecEmail.Name = "lecEmail";
            this.lecEmail.Size = new System.Drawing.Size(51, 21);
            this.lecEmail.TabIndex = 0;
            this.lecEmail.Text = "Email";
            // 
            // lecAddress
            // 
            this.lecAddress.AutoSize = true;
            this.lecAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lecAddress.Location = new System.Drawing.Point(12, 150);
            this.lecAddress.Name = "lecAddress";
            this.lecAddress.Size = new System.Drawing.Size(73, 21);
            this.lecAddress.TabIndex = 0;
            this.lecAddress.Text = "Address";
            // 
            // lecDept
            // 
            this.lecDept.AutoSize = true;
            this.lecDept.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lecDept.Location = new System.Drawing.Point(12, 180);
            this.lecDept.Name = "lecDept";
            this.lecDept.Size = new System.Drawing.Size(96, 21);
            this.lecDept.TabIndex = 0;
            this.lecDept.Text = "Department";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(135, 58);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(200, 23);
            this.nametxt.TabIndex = 2;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(135, 28);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(200, 23);
            this.idtxt.TabIndex = 2;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(135, 88);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(200, 23);
            this.emailtxt.TabIndex = 2;
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(135, 147);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(200, 23);
            this.addresstxt.TabIndex = 2;
            // 
            // deptxt
            // 
            this.deptxt.Location = new System.Drawing.Point(135, 178);
            this.deptxt.Name = "deptxt";
            this.deptxt.Size = new System.Drawing.Size(200, 23);
            this.deptxt.TabIndex = 2;
            // 
            // DoBtxt
            // 
            this.DoBtxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DoBtxt.Location = new System.Drawing.Point(135, 117);
            this.DoBtxt.Name = "DoBtxt";
            this.DoBtxt.Size = new System.Drawing.Size(200, 23);
            this.DoBtxt.TabIndex = 4;
            // 
            // lecSubmit
            // 
            this.lecSubmit.Location = new System.Drawing.Point(135, 207);
            this.lecSubmit.Name = "lecSubmit";
            this.lecSubmit.Size = new System.Drawing.Size(75, 23);
            this.lecSubmit.TabIndex = 2;
            this.lecSubmit.Text = "Finish";
            this.lecSubmit.UseVisualStyleBackColor = true;
            this.lecSubmit.Click += new System.EventHandler(this.lecSubmit_Click);
            // 
            // AddLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 247);
            this.Controls.Add(this.lecSubmit);
            this.Controls.Add(this.DoBtxt);
            this.Controls.Add(this.deptxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.lecDept);
            this.Controls.Add(this.lecAddress);
            this.Controls.Add(this.lecEmail);
            this.Controls.Add(this.DoB);
            this.Controls.Add(this.lecName);
            this.Controls.Add(this.lecId);
            this.Name = "AddLecturerForm";
            this.Text = "AddLecturerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lecId;
        private System.Windows.Forms.Label lecName;
        private System.Windows.Forms.Label DoB;
        private System.Windows.Forms.Label lecEmail;
        private System.Windows.Forms.Label lecAddress;
        private System.Windows.Forms.Label lecDept;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox deptxt;
        private System.Windows.Forms.DateTimePicker DoBtxt;
        private System.Windows.Forms.Button lecSubmit;
    }
}