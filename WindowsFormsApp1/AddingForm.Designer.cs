
namespace WindowsFormsApp1
{
    partial class AddingForm
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_Dob = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Dob = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_AnnualSalary = new System.Windows.Forms.Label();
            this.btn_AddStaff = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(251, 100);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 0;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(251, 156);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_Dob
            // 
            this.textBox_Dob.Location = new System.Drawing.Point(251, 212);
            this.textBox_Dob.Name = "textBox_Dob";
            this.textBox_Dob.Size = new System.Drawing.Size(100, 20);
            this.textBox_Dob.TabIndex = 2;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(250, 272);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 3;
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Location = new System.Drawing.Point(251, 331);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(100, 20);
            this.textBox_Salary.TabIndex = 4;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(169, 103);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(43, 13);
            this.label_ID.TabIndex = 5;
            this.label_ID.Text = "Staff ID";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(169, 163);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 6;
            this.label_Name.Text = "Name";
            // 
            // label_Dob
            // 
            this.label_Dob.AutoSize = true;
            this.label_Dob.Location = new System.Drawing.Point(169, 219);
            this.label_Dob.Name = "label_Dob";
            this.label_Dob.Size = new System.Drawing.Size(66, 13);
            this.label_Dob.TabIndex = 7;
            this.label_Dob.Text = "Date of Birth";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(169, 279);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(35, 13);
            this.label_email.TabIndex = 8;
            this.label_email.Text = "E-mail";
            // 
            // label_AnnualSalary
            // 
            this.label_AnnualSalary.AutoSize = true;
            this.label_AnnualSalary.Location = new System.Drawing.Point(169, 334);
            this.label_AnnualSalary.Name = "label_AnnualSalary";
            this.label_AnnualSalary.Size = new System.Drawing.Size(72, 13);
            this.label_AnnualSalary.TabIndex = 9;
            this.label_AnnualSalary.Text = "Annual Salary";
            // 
            // btn_AddStaff
            // 
            this.btn_AddStaff.Location = new System.Drawing.Point(172, 456);
            this.btn_AddStaff.Name = "btn_AddStaff";
            this.btn_AddStaff.Size = new System.Drawing.Size(75, 23);
            this.btn_AddStaff.TabIndex = 10;
            this.btn_AddStaff.Text = "OK";
            this.btn_AddStaff.UseVisualStyleBackColor = true;
            this.btn_AddStaff.Click += new System.EventHandler(this.btn_AddStaff_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(330, 456);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 581);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_AddStaff);
            this.Controls.Add(this.label_AnnualSalary);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_Dob);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_Salary);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_Dob);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_ID);
            this.Name = "AddingForm";
            this.Text = "AddingForm";
            this.Load += new System.EventHandler(this.AddingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_Dob;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Dob;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_AnnualSalary;
        private System.Windows.Forms.Button btn_AddStaff;
        private System.Windows.Forms.Button btn_Cancel;
    }
}