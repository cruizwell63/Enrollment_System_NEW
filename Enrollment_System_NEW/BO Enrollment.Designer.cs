
namespace Enrollment_System_NEW
{
    partial class BOEnrollment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AY = new System.Windows.Forms.ComboBox();
            this.Sem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackToHome = new System.Windows.Forms.Button();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.EnrollmentPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YearLvl = new System.Windows.Forms.ComboBox();
            this.Int_ID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Acad_Year = new System.Windows.Forms.ComboBox();
            this.Program = new System.Windows.Forms.ComboBox();
            this.Section = new System.Windows.Forms.ComboBox();
            this.Semester = new System.Windows.Forms.ComboBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.EnrollmentPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(501, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(563, 367);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AY
            // 
            this.AY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AY.FormattingEnabled = true;
            this.AY.Location = new System.Drawing.Point(501, 63);
            this.AY.Name = "AY";
            this.AY.Size = new System.Drawing.Size(102, 24);
            this.AY.TabIndex = 2;
            // 
            // Sem
            // 
            this.Sem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sem.FormattingEnabled = true;
            this.Sem.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Sem.Location = new System.Drawing.Point(618, 63);
            this.Sem.Name = "Sem";
            this.Sem.Size = new System.Drawing.Size(102, 24);
            this.Sem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "A.Y.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Semester";
            // 
            // BackToHome
            // 
            this.BackToHome.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToHome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToHome.Location = new System.Drawing.Point(12, 11);
            this.BackToHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(37, 39);
            this.BackToHome.TabIndex = 40;
            this.BackToHome.Text = "<";
            this.BackToHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackToHome.UseVisualStyleBackColor = true;
            this.BackToHome.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // Searchbox
            // 
            this.Searchbox.Location = new System.Drawing.Point(854, 64);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(173, 22);
            this.Searchbox.TabIndex = 41;
            // 
            // EnrollmentPanel
            // 
            this.EnrollmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnrollmentPanel.Controls.Add(this.button1);
            this.EnrollmentPanel.Controls.Add(this.Reset_btn);
            this.EnrollmentPanel.Controls.Add(this.label4);
            this.EnrollmentPanel.Controls.Add(this.label1);
            this.EnrollmentPanel.Controls.Add(this.YearLvl);
            this.EnrollmentPanel.Controls.Add(this.Int_ID);
            this.EnrollmentPanel.Controls.Add(this.label13);
            this.EnrollmentPanel.Controls.Add(this.label12);
            this.EnrollmentPanel.Controls.Add(this.label11);
            this.EnrollmentPanel.Controls.Add(this.label10);
            this.EnrollmentPanel.Controls.Add(this.ID);
            this.EnrollmentPanel.Controls.Add(this.Acad_Year);
            this.EnrollmentPanel.Controls.Add(this.Program);
            this.EnrollmentPanel.Controls.Add(this.Section);
            this.EnrollmentPanel.Controls.Add(this.Semester);
            this.EnrollmentPanel.Controls.Add(this.Submit_btn);
            this.EnrollmentPanel.Controls.Add(this.Update_btn);
            this.EnrollmentPanel.Location = new System.Drawing.Point(112, 42);
            this.EnrollmentPanel.Name = "EnrollmentPanel";
            this.EnrollmentPanel.Size = new System.Drawing.Size(355, 427);
            this.EnrollmentPanel.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(220, 374);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 87;
            this.button1.Text = "Unenroll";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Reset_btn.BackgroundImage = global::Enrollment_System_NEW.Properties.Resources.reset;
            this.Reset_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.Reset_btn.Location = new System.Drawing.Point(-1, 397);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(28, 29);
            this.Reset_btn.TabIndex = 86;
            this.Reset_btn.UseVisualStyleBackColor = false;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 84;
            this.label4.Text = "Enrollment Form";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Year Level";
            // 
            // YearLvl
            // 
            this.YearLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearLvl.FormattingEnabled = true;
            this.YearLvl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.YearLvl.Location = new System.Drawing.Point(129, 123);
            this.YearLvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YearLvl.Name = "YearLvl";
            this.YearLvl.Size = new System.Drawing.Size(187, 24);
            this.YearLvl.TabIndex = 82;
            // 
            // Int_ID
            // 
            this.Int_ID.Location = new System.Drawing.Point(130, 85);
            this.Int_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Int_ID.Name = "Int_ID";
            this.Int_ID.Size = new System.Drawing.Size(74, 22);
            this.Int_ID.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 80;
            this.label13.Text = "Semester";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 79;
            this.label12.Text = "Academic Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 78;
            this.label11.Text = "Program";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "Section";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(40, 90);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(72, 17);
            this.ID.TabIndex = 76;
            this.ID.Text = "Internal ID";
            // 
            // Acad_Year
            // 
            this.Acad_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acad_Year.FormattingEnabled = true;
            this.Acad_Year.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024"});
            this.Acad_Year.Location = new System.Drawing.Point(130, 255);
            this.Acad_Year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Acad_Year.Name = "Acad_Year";
            this.Acad_Year.Size = new System.Drawing.Size(187, 24);
            this.Acad_Year.TabIndex = 73;
            // 
            // Program
            // 
            this.Program.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Program.FormattingEnabled = true;
            this.Program.Items.AddRange(new object[] {
            "BSIT",
            "BSIS"});
            this.Program.Location = new System.Drawing.Point(130, 214);
            this.Program.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(187, 24);
            this.Program.TabIndex = 72;
            // 
            // Section
            // 
            this.Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Section.FormattingEnabled = true;
            this.Section.Location = new System.Drawing.Point(130, 169);
            this.Section.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(187, 24);
            this.Section.TabIndex = 71;
            // 
            // Semester
            // 
            this.Semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Semester.FormattingEnabled = true;
            this.Semester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Semester.Location = new System.Drawing.Point(130, 298);
            this.Semester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(187, 24);
            this.Semester.TabIndex = 74;
            // 
            // Submit_btn
            // 
            this.Submit_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_btn.ForeColor = System.Drawing.Color.Black;
            this.Submit_btn.Location = new System.Drawing.Point(220, 330);
            this.Submit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(96, 36);
            this.Submit_btn.TabIndex = 75;
            this.Submit_btn.Text = "Enroll";
            this.Submit_btn.UseVisualStyleBackColor = false;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_btn.ForeColor = System.Drawing.Color.Black;
            this.Update_btn.Location = new System.Drawing.Point(220, 330);
            this.Update_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(96, 36);
            this.Update_btn.TabIndex = 85;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Search
            // 
            this.Search.BackgroundImage = global::Enrollment_System_NEW.Properties.Resources.download;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Search.Location = new System.Drawing.Point(1033, 63);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(29, 25);
            this.Search.TabIndex = 42;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // BOEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1109, 507);
            this.Controls.Add(this.EnrollmentPanel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.BackToHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sem);
            this.Controls.Add(this.AY);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BOEnrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BO (Enrollment)";
            this.Load += new System.EventHandler(this.BOEnrollment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.EnrollmentPanel.ResumeLayout(false);
            this.EnrollmentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox AY;
        private System.Windows.Forms.ComboBox Sem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackToHome;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Panel EnrollmentPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox YearLvl;
        private System.Windows.Forms.TextBox Int_ID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox Acad_Year;
        private System.Windows.Forms.ComboBox Program;
        private System.Windows.Forms.ComboBox Section;
        private System.Windows.Forms.ComboBox Semester;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button button1;
    }
}