
namespace Enrollment_System_NEW
{
    partial class Enrollment
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
            this.Search = new System.Windows.Forms.Button();
            this.Search_key = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stud_email = new System.Windows.Forms.TextBox();
            this.stud_address = new System.Windows.Forms.TextBox();
            this.stud_lname = new System.Windows.Forms.TextBox();
            this.stud_mname = new System.Windows.Forms.TextBox();
            this.stud_fname = new System.Windows.Forms.TextBox();
            this.toHome = new System.Windows.Forms.LinkLabel();
            this.BackToHome = new System.Windows.Forms.Button();
            this.toEnrollmentForm = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Search.Location = new System.Drawing.Point(765, 43);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(91, 34);
            this.Search.TabIndex = 37;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Search_key
            // 
            this.Search_key.BackColor = System.Drawing.SystemColors.Window;
            this.Search_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_key.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Search_key.Location = new System.Drawing.Point(453, 57);
            this.Search_key.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search_key.Name = "Search_key";
            this.Search_key.Size = new System.Drawing.Size(285, 22);
            this.Search_key.TabIndex = 36;
            this.Search_key.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(453, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 343);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddStudentBtn.Location = new System.Drawing.Point(299, 405);
            this.AddStudentBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(91, 34);
            this.AddStudentBtn.TabIndex = 34;
            this.AddStudentBtn.Text = "Submit";
            this.AddStudentBtn.UseVisualStyleBackColor = false;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "Student Information";
            // 
            // birthdate
            // 
            this.birthdate.CustomFormat = "YYYYMMDD";
            this.birthdate.Location = new System.Drawing.Point(181, 256);
            this.birthdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(208, 22);
            this.birthdate.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Birthdate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "First Name";
            // 
            // stud_email
            // 
            this.stud_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stud_email.Location = new System.Drawing.Point(181, 359);
            this.stud_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_email.Name = "stud_email";
            this.stud_email.Size = new System.Drawing.Size(207, 22);
            this.stud_email.TabIndex = 25;
            // 
            // stud_address
            // 
            this.stud_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stud_address.Location = new System.Drawing.Point(181, 306);
            this.stud_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_address.Name = "stud_address";
            this.stud_address.Size = new System.Drawing.Size(207, 22);
            this.stud_address.TabIndex = 24;
            // 
            // stud_lname
            // 
            this.stud_lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stud_lname.Location = new System.Drawing.Point(181, 203);
            this.stud_lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_lname.Name = "stud_lname";
            this.stud_lname.Size = new System.Drawing.Size(207, 22);
            this.stud_lname.TabIndex = 23;
            // 
            // stud_mname
            // 
            this.stud_mname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stud_mname.Location = new System.Drawing.Point(181, 149);
            this.stud_mname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_mname.Name = "stud_mname";
            this.stud_mname.Size = new System.Drawing.Size(207, 22);
            this.stud_mname.TabIndex = 22;
            // 
            // stud_fname
            // 
            this.stud_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stud_fname.Location = new System.Drawing.Point(181, 98);
            this.stud_fname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_fname.Name = "stud_fname";
            this.stud_fname.Size = new System.Drawing.Size(207, 22);
            this.stud_fname.TabIndex = 21;
            // 
            // toHome
            // 
            this.toHome.AutoSize = true;
            this.toHome.Location = new System.Drawing.Point(24, 18);
            this.toHome.Name = "toHome";
            this.toHome.Size = new System.Drawing.Size(0, 17);
            this.toHome.TabIndex = 38;
            // 
            // BackToHome
            // 
            this.BackToHome.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToHome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToHome.Location = new System.Drawing.Point(12, 18);
            this.BackToHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(37, 39);
            this.BackToHome.TabIndex = 39;
            this.BackToHome.Text = "<";
            this.BackToHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackToHome.UseVisualStyleBackColor = true;
            this.BackToHome.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // toEnrollmentForm
            // 
            this.toEnrollmentForm.BackColor = System.Drawing.Color.LightSeaGreen;
            this.toEnrollmentForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toEnrollmentForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.toEnrollmentForm.Location = new System.Drawing.Point(955, 25);
            this.toEnrollmentForm.Margin = new System.Windows.Forms.Padding(0);
            this.toEnrollmentForm.Name = "toEnrollmentForm";
            this.toEnrollmentForm.Size = new System.Drawing.Size(91, 53);
            this.toEnrollmentForm.TabIndex = 40;
            this.toEnrollmentForm.Text = "Quick Enroll";
            this.toEnrollmentForm.UseVisualStyleBackColor = false;
            this.toEnrollmentForm.Click += new System.EventHandler(this.toEnrollmentForm_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateBtn.Location = new System.Drawing.Point(299, 405);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(91, 34);
            this.updateBtn.TabIndex = 41;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.clearBtn.Location = new System.Drawing.Point(181, 405);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(91, 34);
            this.clearBtn.TabIndex = 44;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1109, 507);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.toEnrollmentForm);
            this.Controls.Add(this.BackToHome);
            this.Controls.Add(this.toHome);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search_key);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stud_email);
            this.Controls.Add(this.stud_address);
            this.Controls.Add(this.stud_lname);
            this.Controls.Add(this.stud_mname);
            this.Controls.Add(this.stud_fname);
            this.Controls.Add(this.updateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Enrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment";
            this.Load += new System.EventHandler(this.Enrollment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Search_key;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stud_email;
        private System.Windows.Forms.TextBox stud_address;
        private System.Windows.Forms.TextBox stud_lname;
        private System.Windows.Forms.TextBox stud_mname;
        private System.Windows.Forms.TextBox stud_fname;
        private System.Windows.Forms.LinkLabel toHome;
        private System.Windows.Forms.Button BackToHome;
        private System.Windows.Forms.Button toEnrollmentForm;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}