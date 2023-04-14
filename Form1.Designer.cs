namespace sqlite3Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreateDatabase = new Button();
            btnDeleteDatabase = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBoxName = new TextBox();
            txtBoxSID = new TextBox();
            btnSubmitSQL = new Button();
            dViewDB = new DataGridView();
            btnRefreshList = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dViewDB).BeginInit();
            SuspendLayout();
            // 
            // btnCreateDatabase
            // 
            btnCreateDatabase.Location = new Point(100, 12);
            btnCreateDatabase.Name = "btnCreateDatabase";
            btnCreateDatabase.Size = new Size(193, 39);
            btnCreateDatabase.TabIndex = 0;
            btnCreateDatabase.Text = "Create Table Database";
            btnCreateDatabase.UseVisualStyleBackColor = true;
            btnCreateDatabase.Click += btnCreateDatabase_Click;
            // 
            // btnDeleteDatabase
            // 
            btnDeleteDatabase.Location = new Point(100, 57);
            btnDeleteDatabase.Name = "btnDeleteDatabase";
            btnDeleteDatabase.Size = new Size(193, 39);
            btnDeleteDatabase.TabIndex = 1;
            btnDeleteDatabase.Text = "Delete Database";
            btnDeleteDatabase.UseVisualStyleBackColor = true;
            btnDeleteDatabase.Click += btnDeleteDatabase_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 163);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Name: ";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(74, 116);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(195, 27);
            txtBoxName.TabIndex = 4;
            // 
            // txtBoxSID
            // 
            txtBoxSID.Location = new Point(100, 160);
            txtBoxSID.Name = "txtBoxSID";
            txtBoxSID.Size = new Size(195, 27);
            txtBoxSID.TabIndex = 5;
            // 
            // btnSubmitSQL
            // 
            btnSubmitSQL.Location = new Point(100, 209);
            btnSubmitSQL.Name = "btnSubmitSQL";
            btnSubmitSQL.Size = new Size(160, 48);
            btnSubmitSQL.TabIndex = 6;
            btnSubmitSQL.Text = "Submit Data";
            btnSubmitSQL.UseVisualStyleBackColor = true;
            btnSubmitSQL.Click += btnSubmitSQL_Click;
            // 
            // dViewDB
            // 
            dViewDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dViewDB.Location = new Point(315, 12);
            dViewDB.Name = "dViewDB";
            dViewDB.RowHeadersWidth = 51;
            dViewDB.RowTemplate.Height = 29;
            dViewDB.Size = new Size(269, 151);
            dViewDB.TabIndex = 7;
            // 
            // btnRefreshList
            // 
            btnRefreshList.Location = new Point(345, 169);
            btnRefreshList.Name = "btnRefreshList";
            btnRefreshList.Size = new Size(219, 42);
            btnRefreshList.TabIndex = 8;
            btnRefreshList.Text = "Get Data";
            btnRefreshList.UseVisualStyleBackColor = true;
            btnRefreshList.Click += btnRefreshList_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 232);
            label3.Name = "label3";
            label3.Size = new Size(230, 20);
            label3.TabIndex = 9;
            label3.Text = "Coded By Kitsuuu : SQLite and C#";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 288);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 10;
            label4.Text = "Status : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 317);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnRefreshList);
            Controls.Add(dViewDB);
            Controls.Add(btnSubmitSQL);
            Controls.Add(txtBoxSID);
            Controls.Add(txtBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeleteDatabase);
            Controls.Add(btnCreateDatabase);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dViewDB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateDatabase;
        private Button btnDeleteDatabase;
        private Label label1;
        private Label label2;
        private TextBox txtBoxName;
        private TextBox txtBoxSID;
        private Button btnSubmitSQL;
        private DataGridView dViewDB;
        private Button btnRefreshList;
        private Label label3;
        private Label label4;
    }
}