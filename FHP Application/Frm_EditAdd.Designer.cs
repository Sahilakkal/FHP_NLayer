﻿namespace FHP_Application
{
    partial class Frm_EditAdd
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.lbl_SerialNo = new System.Windows.Forms.Label();
            this.txtBox_SerialNoEditAdd = new System.Windows.Forms.TextBox();
            this.lbl_PrefixEditAdd = new System.Windows.Forms.Label();
            this.txtBox_PrefixEditAdd = new System.Windows.Forms.TextBox();
            this.lbl_FirstNameEditAdd = new System.Windows.Forms.Label();
            this.txtBox_FirstNameEditAdd = new System.Windows.Forms.TextBox();
            this.lbl_MiddleNameEditAdd = new System.Windows.Forms.Label();
            this.txtBox_MiddleNameEditAdd = new System.Windows.Forms.TextBox();
            this.lbl_LastNameEditAdd = new System.Windows.Forms.Label();
            this.txtBox_LastNameEditAdd = new System.Windows.Forms.TextBox();
            this.lbl_CurrentCompany = new System.Windows.Forms.Label();
            this.txtBox_CurrentCompanyEditAdd = new System.Windows.Forms.TextBox();
            this.lbl_CurrentAddressEditAdd = new System.Windows.Forms.Label();
            this.txtBox_CurrentAddressEditAdd = new System.Windows.Forms.TextBox();
            this.lbl_DOBEditAdd = new System.Windows.Forms.Label();
            this.lbl_JoiningDate = new System.Windows.Forms.Label();
            this.date_Joining = new System.Windows.Forms.DateTimePicker();
            this.date_DOB = new System.Windows.Forms.DateTimePicker();
            this.lbl_Qualification = new System.Windows.Forms.Label();
            this.comboBox_Qualification = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(201, 374);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Add.Size = new System.Drawing.Size(111, 51);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(473, 374);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(111, 51);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(337, 374);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(111, 51);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // lbl_SerialNo
            // 
            this.lbl_SerialNo.AutoSize = true;
            this.lbl_SerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SerialNo.Location = new System.Drawing.Point(54, 84);
            this.lbl_SerialNo.Name = "lbl_SerialNo";
            this.lbl_SerialNo.Size = new System.Drawing.Size(39, 13);
            this.lbl_SerialNo.TabIndex = 3;
            this.lbl_SerialNo.Text = "S No.";
            // 
            // txtBox_SerialNoEditAdd
            // 
            this.txtBox_SerialNoEditAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_SerialNoEditAdd.Enabled = false;
            this.txtBox_SerialNoEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_SerialNoEditAdd.Location = new System.Drawing.Point(159, 81);
            this.txtBox_SerialNoEditAdd.Name = "txtBox_SerialNoEditAdd";
            this.txtBox_SerialNoEditAdd.Size = new System.Drawing.Size(176, 20);
            this.txtBox_SerialNoEditAdd.TabIndex = 4;
            // 
            // lbl_PrefixEditAdd
            // 
            this.lbl_PrefixEditAdd.AutoSize = true;
            this.lbl_PrefixEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrefixEditAdd.Location = new System.Drawing.Point(54, 123);
            this.lbl_PrefixEditAdd.Name = "lbl_PrefixEditAdd";
            this.lbl_PrefixEditAdd.Size = new System.Drawing.Size(39, 13);
            this.lbl_PrefixEditAdd.TabIndex = 5;
            this.lbl_PrefixEditAdd.Text = "Prefix";
            // 
            // txtBox_PrefixEditAdd
            // 
            this.txtBox_PrefixEditAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_PrefixEditAdd.Location = new System.Drawing.Point(159, 123);
            this.txtBox_PrefixEditAdd.Name = "txtBox_PrefixEditAdd";
            this.txtBox_PrefixEditAdd.Size = new System.Drawing.Size(176, 20);
            this.txtBox_PrefixEditAdd.TabIndex = 6;
            // 
            // lbl_FirstNameEditAdd
            // 
            this.lbl_FirstNameEditAdd.AutoSize = true;
            this.lbl_FirstNameEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstNameEditAdd.Location = new System.Drawing.Point(49, 164);
            this.lbl_FirstNameEditAdd.Name = "lbl_FirstNameEditAdd";
            this.lbl_FirstNameEditAdd.Size = new System.Drawing.Size(72, 13);
            this.lbl_FirstNameEditAdd.TabIndex = 7;
            this.lbl_FirstNameEditAdd.Text = "First Name*";
            // 
            // txtBox_FirstNameEditAdd
            // 
            this.txtBox_FirstNameEditAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_FirstNameEditAdd.Location = new System.Drawing.Point(159, 161);
            this.txtBox_FirstNameEditAdd.Name = "txtBox_FirstNameEditAdd";
            this.txtBox_FirstNameEditAdd.Size = new System.Drawing.Size(176, 20);
            this.txtBox_FirstNameEditAdd.TabIndex = 8;
            // 
            // lbl_MiddleNameEditAdd
            // 
            this.lbl_MiddleNameEditAdd.AutoSize = true;
            this.lbl_MiddleNameEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MiddleNameEditAdd.Location = new System.Drawing.Point(49, 209);
            this.lbl_MiddleNameEditAdd.Name = "lbl_MiddleNameEditAdd";
            this.lbl_MiddleNameEditAdd.Size = new System.Drawing.Size(80, 13);
            this.lbl_MiddleNameEditAdd.TabIndex = 9;
            this.lbl_MiddleNameEditAdd.Text = "Middle Name";
            // 
            // txtBox_MiddleNameEditAdd
            // 
            this.txtBox_MiddleNameEditAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_MiddleNameEditAdd.Location = new System.Drawing.Point(159, 202);
            this.txtBox_MiddleNameEditAdd.Name = "txtBox_MiddleNameEditAdd";
            this.txtBox_MiddleNameEditAdd.Size = new System.Drawing.Size(176, 20);
            this.txtBox_MiddleNameEditAdd.TabIndex = 10;
            // 
            // lbl_LastNameEditAdd
            // 
            this.lbl_LastNameEditAdd.AutoSize = true;
            this.lbl_LastNameEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastNameEditAdd.Location = new System.Drawing.Point(49, 244);
            this.lbl_LastNameEditAdd.Name = "lbl_LastNameEditAdd";
            this.lbl_LastNameEditAdd.Size = new System.Drawing.Size(67, 13);
            this.lbl_LastNameEditAdd.TabIndex = 11;
            this.lbl_LastNameEditAdd.Text = "Last Name";
            // 
            // txtBox_LastNameEditAdd
            // 
            this.txtBox_LastNameEditAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_LastNameEditAdd.Location = new System.Drawing.Point(159, 241);
            this.txtBox_LastNameEditAdd.Name = "txtBox_LastNameEditAdd";
            this.txtBox_LastNameEditAdd.Size = new System.Drawing.Size(176, 20);
            this.txtBox_LastNameEditAdd.TabIndex = 12;
            // 
            // lbl_CurrentCompany
            // 
            this.lbl_CurrentCompany.AutoSize = true;
            this.lbl_CurrentCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentCompany.Location = new System.Drawing.Point(396, 81);
            this.lbl_CurrentCompany.Name = "lbl_CurrentCompany";
            this.lbl_CurrentCompany.Size = new System.Drawing.Size(108, 13);
            this.lbl_CurrentCompany.TabIndex = 13;
            this.lbl_CurrentCompany.Text = "Current Company*";
            // 
            // txtBox_CurrentCompanyEditAdd
            // 
            this.txtBox_CurrentCompanyEditAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_CurrentCompanyEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CurrentCompanyEditAdd.Location = new System.Drawing.Point(510, 78);
            this.txtBox_CurrentCompanyEditAdd.Name = "txtBox_CurrentCompanyEditAdd";
            this.txtBox_CurrentCompanyEditAdd.Size = new System.Drawing.Size(176, 20);
            this.txtBox_CurrentCompanyEditAdd.TabIndex = 14;
            // 
            // lbl_CurrentAddressEditAdd
            // 
            this.lbl_CurrentAddressEditAdd.AutoSize = true;
            this.lbl_CurrentAddressEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentAddressEditAdd.Location = new System.Drawing.Point(49, 304);
            this.lbl_CurrentAddressEditAdd.Name = "lbl_CurrentAddressEditAdd";
            this.lbl_CurrentAddressEditAdd.Size = new System.Drawing.Size(97, 13);
            this.lbl_CurrentAddressEditAdd.TabIndex = 15;
            this.lbl_CurrentAddressEditAdd.Text = "Current Address";
            // 
            // txtBox_CurrentAddressEditAdd
            // 
            this.txtBox_CurrentAddressEditAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_CurrentAddressEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CurrentAddressEditAdd.Location = new System.Drawing.Point(159, 286);
            this.txtBox_CurrentAddressEditAdd.Multiline = true;
            this.txtBox_CurrentAddressEditAdd.Name = "txtBox_CurrentAddressEditAdd";
            this.txtBox_CurrentAddressEditAdd.Size = new System.Drawing.Size(527, 51);
            this.txtBox_CurrentAddressEditAdd.TabIndex = 16;
            // 
            // lbl_DOBEditAdd
            // 
            this.lbl_DOBEditAdd.AutoSize = true;
            this.lbl_DOBEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOBEditAdd.Location = new System.Drawing.Point(398, 161);
            this.lbl_DOBEditAdd.Name = "lbl_DOBEditAdd";
            this.lbl_DOBEditAdd.Size = new System.Drawing.Size(81, 13);
            this.lbl_DOBEditAdd.TabIndex = 17;
            this.lbl_DOBEditAdd.Text = "Date Of Birth";
            // 
            // lbl_JoiningDate
            // 
            this.lbl_JoiningDate.AutoSize = true;
            this.lbl_JoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JoiningDate.Location = new System.Drawing.Point(398, 208);
            this.lbl_JoiningDate.Name = "lbl_JoiningDate";
            this.lbl_JoiningDate.Size = new System.Drawing.Size(83, 13);
            this.lbl_JoiningDate.TabIndex = 19;
            this.lbl_JoiningDate.Text = "Joining Date*";
            this.lbl_JoiningDate.Click += new System.EventHandler(this.lbl_JoiningDate_Click);
            // 
            // date_Joining
            // 
            this.date_Joining.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Joining.Location = new System.Drawing.Point(510, 202);
            this.date_Joining.MaxDate = new System.DateTime(2024, 2, 20, 0, 0, 0, 0);
            this.date_Joining.Name = "date_Joining";
            this.date_Joining.Size = new System.Drawing.Size(176, 20);
            this.date_Joining.TabIndex = 21;
            this.date_Joining.Value = new System.DateTime(2024, 2, 20, 0, 0, 0, 0);
            // 
            // date_DOB
            // 
            this.date_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_DOB.Location = new System.Drawing.Point(510, 161);
            this.date_DOB.MaxDate = new System.DateTime(2024, 2, 20, 0, 0, 0, 0);
            this.date_DOB.Name = "date_DOB";
            this.date_DOB.Size = new System.Drawing.Size(176, 20);
            this.date_DOB.TabIndex = 22;
            this.date_DOB.Value = new System.DateTime(2024, 2, 20, 0, 0, 0, 0);
            // 
            // lbl_Qualification
            // 
            this.lbl_Qualification.AutoSize = true;
            this.lbl_Qualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qualification.Location = new System.Drawing.Point(396, 123);
            this.lbl_Qualification.Name = "lbl_Qualification";
            this.lbl_Qualification.Size = new System.Drawing.Size(83, 13);
            this.lbl_Qualification.TabIndex = 23;
            this.lbl_Qualification.Text = "Qualification*";
            // 
            // comboBox_Qualification
            // 
            this.comboBox_Qualification.FormattingEnabled = true;
            this.comboBox_Qualification.Location = new System.Drawing.Point(510, 122);
            this.comboBox_Qualification.Name = "comboBox_Qualification";
            this.comboBox_Qualification.Size = new System.Drawing.Size(176, 21);
            this.comboBox_Qualification.TabIndex = 24;
            // 
            // Form_Model_EditAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Qualification);
            this.Controls.Add(this.lbl_Qualification);
            this.Controls.Add(this.date_DOB);
            this.Controls.Add(this.date_Joining);
            this.Controls.Add(this.lbl_JoiningDate);
            this.Controls.Add(this.lbl_DOBEditAdd);
            this.Controls.Add(this.txtBox_CurrentAddressEditAdd);
            this.Controls.Add(this.lbl_CurrentAddressEditAdd);
            this.Controls.Add(this.txtBox_CurrentCompanyEditAdd);
            this.Controls.Add(this.lbl_CurrentCompany);
            this.Controls.Add(this.txtBox_LastNameEditAdd);
            this.Controls.Add(this.lbl_LastNameEditAdd);
            this.Controls.Add(this.txtBox_MiddleNameEditAdd);
            this.Controls.Add(this.lbl_MiddleNameEditAdd);
            this.Controls.Add(this.txtBox_FirstNameEditAdd);
            this.Controls.Add(this.lbl_FirstNameEditAdd);
            this.Controls.Add(this.txtBox_PrefixEditAdd);
            this.Controls.Add(this.lbl_PrefixEditAdd);
            this.Controls.Add(this.txtBox_SerialNoEditAdd);
            this.Controls.Add(this.lbl_SerialNo);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Add);
            this.Name = "Form_Model_EditAdd";
            this.Text = "Employee Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Model_EditAdd_FormClosing_1);
            this.Load += new System.EventHandler(this.Form_Model_EditAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label lbl_SerialNo;
        private System.Windows.Forms.TextBox txtBox_SerialNoEditAdd;
        private System.Windows.Forms.Label lbl_PrefixEditAdd;
        private System.Windows.Forms.TextBox txtBox_PrefixEditAdd;
        private System.Windows.Forms.Label lbl_FirstNameEditAdd;
        private System.Windows.Forms.TextBox txtBox_FirstNameEditAdd;
        private System.Windows.Forms.Label lbl_MiddleNameEditAdd;
        private System.Windows.Forms.TextBox txtBox_MiddleNameEditAdd;
        private System.Windows.Forms.Label lbl_LastNameEditAdd;
        private System.Windows.Forms.TextBox txtBox_LastNameEditAdd;
        private System.Windows.Forms.Label lbl_CurrentCompany;
        private System.Windows.Forms.TextBox txtBox_CurrentCompanyEditAdd;
        private System.Windows.Forms.Label lbl_CurrentAddressEditAdd;
        private System.Windows.Forms.TextBox txtBox_CurrentAddressEditAdd;
        private System.Windows.Forms.Label lbl_DOBEditAdd;
        private System.Windows.Forms.Label lbl_JoiningDate;
        private System.Windows.Forms.DateTimePicker date_Joining;
        private System.Windows.Forms.DateTimePicker date_DOB;
        private System.Windows.Forms.Label lbl_Qualification;
        private System.Windows.Forms.ComboBox comboBox_Qualification;
    }
}