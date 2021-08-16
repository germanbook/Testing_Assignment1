
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingForm));
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAnnualSalary = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblIDHint = new System.Windows.Forms.Label();
            this.lblNameHint = new System.Windows.Forms.Label();
            this.lblGenderHint = new System.Windows.Forms.Label();
            this.lblEmailHint = new System.Windows.Forms.Label();
            this.lblSalaryHint = new System.Windows.Forms.Label();
            this.lblStaffIDIsAvailable = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(155, 83);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(100, 20);
            this.tbxID.TabIndex = 5;
            this.tbxID.Leave += new System.EventHandler(this.tbxID_Leave);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(154, 125);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 1;
            this.tbxName.Leave += new System.EventHandler(this.tbxName_Leave);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(154, 336);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 3;
            this.tbxEmail.Leave += new System.EventHandler(this.tbxEmail_Leave);
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(155, 395);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(100, 20);
            this.tbxSalary.TabIndex = 4;
            this.tbxSalary.Leave += new System.EventHandler(this.tbxSalary_Leave);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Location = new System.Drawing.Point(72, 86);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(43, 13);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Staff ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(72, 132);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblDateBirth.Location = new System.Drawing.Point(72, 266);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(66, 13);
            this.lblDateBirth.TabIndex = 7;
            this.lblDateBirth.Text = "Date of Birth";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(73, 343);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // lblAnnualSalary
            // 
            this.lblAnnualSalary.AutoSize = true;
            this.lblAnnualSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnualSalary.Location = new System.Drawing.Point(73, 398);
            this.lblAnnualSalary.Name = "lblAnnualSalary";
            this.lblAnnualSalary.Size = new System.Drawing.Size(72, 13);
            this.lblAnnualSalary.TabIndex = 9;
            this.lblAnnualSalary.Text = "Annual Salary";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(190, 511);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.toolTip1.SetToolTip(this.btnOk, "Ok and save");
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btn_AddStaff_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.btnOk_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.btnOk_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(348, 511);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.toolTip1.SetToolTip(this.btnBack, "Back to previous form");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Location = new System.Drawing.Point(73, 198);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(19, 25);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 13;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            this.rbtnMale.Click += new System.EventHandler(this.rbtnMale_Click);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(97, 25);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 14;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            this.rbtnFemale.CheckedChanged += new System.EventHandler(this.rbtnFemale_CheckedChanged);
            this.rbtnFemale.Click += new System.EventHandler(this.rbtnFemale_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "dd-MM-yyyy";
            this.dtpDateOfBirth.Location = new System.Drawing.Point(155, 266);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 16;
            // 
            // lblIDHint
            // 
            this.lblIDHint.BackColor = System.Drawing.Color.Transparent;
            this.lblIDHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIDHint.ForeColor = System.Drawing.Color.Black;
            this.lblIDHint.Location = new System.Drawing.Point(417, 85);
            this.lblIDHint.Name = "lblIDHint";
            this.lblIDHint.Size = new System.Drawing.Size(153, 32);
            this.lblIDHint.TabIndex = 17;
            this.lblIDHint.Text = "ID must be 6 digits";
            // 
            // lblNameHint
            // 
            this.lblNameHint.BackColor = System.Drawing.Color.Transparent;
            this.lblNameHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNameHint.ForeColor = System.Drawing.Color.Black;
            this.lblNameHint.Location = new System.Drawing.Point(417, 125);
            this.lblNameHint.Name = "lblNameHint";
            this.lblNameHint.Size = new System.Drawing.Size(184, 55);
            this.lblNameHint.TabIndex = 18;
            this.lblNameHint.Text = "ex: James Bond ( only uppercase/lowercase letters)";
            // 
            // lblGenderHint
            // 
            this.lblGenderHint.BackColor = System.Drawing.Color.Transparent;
            this.lblGenderHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGenderHint.ForeColor = System.Drawing.Color.Black;
            this.lblGenderHint.Location = new System.Drawing.Point(417, 196);
            this.lblGenderHint.Name = "lblGenderHint";
            this.lblGenderHint.Size = new System.Drawing.Size(153, 32);
            this.lblGenderHint.TabIndex = 19;
            this.lblGenderHint.Text = "Select one";
            // 
            // lblEmailHint
            // 
            this.lblEmailHint.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmailHint.ForeColor = System.Drawing.Color.Black;
            this.lblEmailHint.Location = new System.Drawing.Point(417, 336);
            this.lblEmailHint.Name = "lblEmailHint";
            this.lblEmailHint.Size = new System.Drawing.Size(153, 32);
            this.lblEmailHint.TabIndex = 20;
            this.lblEmailHint.Text = "ex: example@mail.com";
            // 
            // lblSalaryHint
            // 
            this.lblSalaryHint.BackColor = System.Drawing.Color.Transparent;
            this.lblSalaryHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSalaryHint.ForeColor = System.Drawing.Color.Black;
            this.lblSalaryHint.Location = new System.Drawing.Point(417, 395);
            this.lblSalaryHint.Name = "lblSalaryHint";
            this.lblSalaryHint.Size = new System.Drawing.Size(153, 32);
            this.lblSalaryHint.TabIndex = 21;
            this.lblSalaryHint.Text = "Salary in number";
            // 
            // lblStaffIDIsAvailable
            // 
            this.lblStaffIDIsAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffIDIsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStaffIDIsAvailable.ForeColor = System.Drawing.Color.Red;
            this.lblStaffIDIsAvailable.Location = new System.Drawing.Point(272, 86);
            this.lblStaffIDIsAvailable.Name = "lblStaffIDIsAvailable";
            this.lblStaffIDIsAvailable.Size = new System.Drawing.Size(126, 32);
            this.lblStaffIDIsAvailable.TabIndex = 22;
            this.lblStaffIDIsAvailable.Text = "Not Available";
            this.lblStaffIDIsAvailable.Visible = false;
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.BackColor = System.Drawing.Color.Transparent;
            this.lblRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(417, 456);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(126, 32);
            this.lblRequiredFields.TabIndex = 23;
            this.lblRequiredFields.Text = "* All Fields Required";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtnMale);
            this.groupBox1.Controls.Add(this.rbtnFemale);
            this.groupBox1.Location = new System.Drawing.Point(154, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 65);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 581);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.lblStaffIDIsAvailable);
            this.Controls.Add(this.lblSalaryHint);
            this.Controls.Add(this.lblEmailHint);
            this.Controls.Add(this.lblGenderHint);
            this.Controls.Add(this.lblNameHint);
            this.Controls.Add(this.lblIDHint);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblAnnualSalary);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDateBirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.tbxSalary);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddingForm";
            this.Text = "Adding Form";
            this.Load += new System.EventHandler(this.AddingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAnnualSalary;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblIDHint;
        private System.Windows.Forms.Label lblNameHint;
        private System.Windows.Forms.Label lblGenderHint;
        private System.Windows.Forms.Label lblEmailHint;
        private System.Windows.Forms.Label lblSalaryHint;
        private System.Windows.Forms.Label lblStaffIDIsAvailable;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}