namespace StudentManagement
{
    partial class FormStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.StuTable = new System.Windows.Forms.DataGridView();
            this.StuDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StuUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StuTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(19, 13);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(260, 23);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(753, 13);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // StuTable
            // 
            this.StuTable.AllowUserToAddRows = false;
            this.StuTable.AllowUserToDeleteRows = false;
            this.StuTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuTable.Location = new System.Drawing.Point(19, 42);
            this.StuTable.Name = "StuTable";
            this.StuTable.ReadOnly = true;
            this.StuTable.Size = new System.Drawing.Size(809, 316);
            this.StuTable.TabIndex = 0;
            this.StuTable.Text = "dataGridView1";
            this.StuTable.SelectionChanged += new System.EventHandler(this.StuTable_SelectionChanged);
            // 
            // StuDelete
            // 
            this.StuDelete.Enabled = false;
            this.StuDelete.Location = new System.Drawing.Point(753, 364);
            this.StuDelete.Name = "StuDelete";
            this.StuDelete.Size = new System.Drawing.Size(75, 23);
            this.StuDelete.TabIndex = 2;
            this.StuDelete.Text = "Delete";
            this.StuDelete.UseVisualStyleBackColor = true;
            this.StuDelete.Click += new System.EventHandler(this.StuDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(502, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select row to delete or update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(19, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search By ID";
            // 
            // StuUpdate
            // 
            this.StuUpdate.Enabled = false;
            this.StuUpdate.Location = new System.Drawing.Point(672, 364);
            this.StuUpdate.Name = "StuUpdate";
            this.StuUpdate.Size = new System.Drawing.Size(75, 23);
            this.StuUpdate.TabIndex = 6;
            this.StuUpdate.Text = "Update";
            this.StuUpdate.UseVisualStyleBackColor = true;
            this.StuUpdate.Click += new System.EventHandler(this.StuUpdate_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StuUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StuDelete);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.StuTable);
            this.Name = "FormStudent";
            this.Size = new System.Drawing.Size(850, 400);
            ((System.ComponentModel.ISupportInitialize)(this.StuTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button AddBtn;
        public System.Windows.Forms.DataGridView StuTable;
        private System.Windows.Forms.Button StuDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StuUpdate;
    }
}
