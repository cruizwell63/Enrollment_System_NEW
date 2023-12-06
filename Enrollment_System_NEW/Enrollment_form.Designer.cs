
namespace Enrollment_System_NEW
{
    partial class Enrollment_form
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.ComboBox();
            this.Enroll_btn = new System.Windows.Forms.Button();
            this.BackToHome = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.YearLvl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(96, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 66;
            this.label13.Text = "Semester";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 65;
            this.label12.Text = "Academic Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 64;
            this.label11.Text = "Program";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 63;
            this.label10.Text = "Section";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(93, 100);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(72, 17);
            this.ID.TabIndex = 62;
            this.ID.Text = "Internal ID";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024"});
            this.comboBox4.Location = new System.Drawing.Point(191, 265);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(187, 24);
            this.comboBox4.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "BSIT",
            "BSIS"});
            this.comboBox3.Location = new System.Drawing.Point(191, 224);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(187, 24);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(191, 174);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 29);
            this.label8.TabIndex = 58;
            this.label8.Text = "Enroll Student";
            // 
            // Semester
            // 
            this.Semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Semester.FormattingEnabled = true;
            this.Semester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Semester.Location = new System.Drawing.Point(191, 308);
            this.Semester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(187, 24);
            this.Semester.TabIndex = 5;
            // 
            // Enroll_btn
            // 
            this.Enroll_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Enroll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enroll_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Enroll_btn.Location = new System.Drawing.Point(227, 350);
            this.Enroll_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Enroll_btn.Name = "Enroll_btn";
            this.Enroll_btn.Size = new System.Drawing.Size(96, 36);
            this.Enroll_btn.TabIndex = 56;
            this.Enroll_btn.Text = "Enroll";
            this.Enroll_btn.UseVisualStyleBackColor = false;
            this.Enroll_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackToHome
            // 
            this.BackToHome.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToHome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToHome.Location = new System.Drawing.Point(12, 28);
            this.BackToHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(37, 39);
            this.BackToHome.TabIndex = 67;
            this.BackToHome.Text = "<";
            this.BackToHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackToHome.UseVisualStyleBackColor = true;
            this.BackToHome.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 95);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 68;
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
            this.YearLvl.Location = new System.Drawing.Point(190, 133);
            this.YearLvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YearLvl.Name = "YearLvl";
            this.YearLvl.Size = new System.Drawing.Size(187, 24);
            this.YearLvl.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Year Level";
            // 
            // Enrollment_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(525, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearLvl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BackToHome);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.Enroll_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Enrollment_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment Form";
            this.Load += new System.EventHandler(this.Enrollment_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Semester;
        private System.Windows.Forms.Button Enroll_btn;
        private System.Windows.Forms.Button BackToHome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox YearLvl;
        private System.Windows.Forms.Label label1;
    }
}