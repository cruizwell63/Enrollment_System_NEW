
namespace Enrollment_System_NEW
{
    partial class BackOffice2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgramList = new System.Windows.Forms.ComboBox();
            this.SubCode = new System.Windows.Forms.TextBox();
            this.SubName = new System.Windows.Forms.TextBox();
            this.Sub_desc = new System.Windows.Forms.RichTextBox();
            this.BackToHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddSub = new System.Windows.Forms.Button();
            this.DelSub = new System.Windows.Forms.Button();
            this.UpdateSub = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClearSub = new System.Windows.Forms.Button();
            this.Key = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subjects";
            // 
            // ProgramList
            // 
            this.ProgramList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProgramList.FormattingEnabled = true;
            this.ProgramList.Location = new System.Drawing.Point(232, 74);
            this.ProgramList.Name = "ProgramList";
            this.ProgramList.Size = new System.Drawing.Size(263, 24);
            this.ProgramList.TabIndex = 69;
            // 
            // SubCode
            // 
            this.SubCode.Location = new System.Drawing.Point(232, 122);
            this.SubCode.Name = "SubCode";
            this.SubCode.Size = new System.Drawing.Size(263, 22);
            this.SubCode.TabIndex = 70;
            // 
            // SubName
            // 
            this.SubName.Location = new System.Drawing.Point(232, 173);
            this.SubName.Name = "SubName";
            this.SubName.Size = new System.Drawing.Size(263, 22);
            this.SubName.TabIndex = 71;
            // 
            // Sub_desc
            // 
            this.Sub_desc.Location = new System.Drawing.Point(232, 237);
            this.Sub_desc.Name = "Sub_desc";
            this.Sub_desc.Size = new System.Drawing.Size(263, 166);
            this.Sub_desc.TabIndex = 72;
            this.Sub_desc.Text = "";
            // 
            // BackToHome
            // 
            this.BackToHome.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToHome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToHome.Location = new System.Drawing.Point(12, 11);
            this.BackToHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(37, 39);
            this.BackToHome.TabIndex = 68;
            this.BackToHome.Text = "<";
            this.BackToHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackToHome.UseVisualStyleBackColor = true;
            this.BackToHome.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Program";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Subject Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "Subject Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "Description";
            // 
            // AddSub
            // 
            this.AddSub.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AddSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSub.Location = new System.Drawing.Point(420, 424);
            this.AddSub.Name = "AddSub";
            this.AddSub.Size = new System.Drawing.Size(75, 33);
            this.AddSub.TabIndex = 77;
            this.AddSub.Text = "Add";
            this.AddSub.UseVisualStyleBackColor = false;
            this.AddSub.Click += new System.EventHandler(this.AddSub_Click);
            // 
            // DelSub
            // 
            this.DelSub.BackColor = System.Drawing.Color.MediumTurquoise;
            this.DelSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelSub.Location = new System.Drawing.Point(232, 424);
            this.DelSub.Name = "DelSub";
            this.DelSub.Size = new System.Drawing.Size(75, 33);
            this.DelSub.TabIndex = 78;
            this.DelSub.Text = "Delete";
            this.DelSub.UseVisualStyleBackColor = false;
            this.DelSub.Click += new System.EventHandler(this.DelSub_Click);
            // 
            // UpdateSub
            // 
            this.UpdateSub.BackColor = System.Drawing.Color.MediumTurquoise;
            this.UpdateSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSub.Location = new System.Drawing.Point(420, 424);
            this.UpdateSub.Name = "UpdateSub";
            this.UpdateSub.Size = new System.Drawing.Size(75, 33);
            this.UpdateSub.TabIndex = 79;
            this.UpdateSub.Text = "Update";
            this.UpdateSub.UseVisualStyleBackColor = false;
            this.UpdateSub.Click += new System.EventHandler(this.UpdateSub_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(527, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 329);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClearSub
            // 
            this.ClearSub.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClearSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearSub.Location = new System.Drawing.Point(325, 424);
            this.ClearSub.Name = "ClearSub";
            this.ClearSub.Size = new System.Drawing.Size(75, 33);
            this.ClearSub.TabIndex = 81;
            this.ClearSub.Text = "Clear";
            this.ClearSub.UseVisualStyleBackColor = false;
            this.ClearSub.Click += new System.EventHandler(this.ClearSub_Click);
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(527, 77);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(342, 22);
            this.Key.TabIndex = 82;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(887, 70);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 33);
            this.Search.TabIndex = 83;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // BackOffice2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1109, 507);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.ClearSub);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DelSub);
            this.Controls.Add(this.AddSub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToHome);
            this.Controls.Add(this.Sub_desc);
            this.Controls.Add(this.SubName);
            this.Controls.Add(this.ProgramList);
            this.Controls.Add(this.SubCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateSub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BackOffice2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BO (Subject/Schedule Management)";
            this.Load += new System.EventHandler(this.BackOffice2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProgramList;
        private System.Windows.Forms.TextBox SubCode;
        private System.Windows.Forms.TextBox SubName;
        private System.Windows.Forms.RichTextBox Sub_desc;
        private System.Windows.Forms.Button BackToHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddSub;
        private System.Windows.Forms.Button DelSub;
        private System.Windows.Forms.Button UpdateSub;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearSub;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Button Search;
    }
}