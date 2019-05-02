﻿namespace HospitalManagementSystem
{
    partial class frm_register
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
            this.lbl_registeras = new System.Windows.Forms.Label();
            this.cmb_registeras = new System.Windows.Forms.ComboBox();
            this.pnl_doctor = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_Fname = new System.Windows.Forms.Label();
            this.lbl_Lname = new System.Windows.Forms.Label();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_patient = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_patUsername = new System.Windows.Forms.Label();
            this.lbl_patPassword = new System.Windows.Forms.Label();
            this.lbl_patName = new System.Windows.Forms.Label();
            this.lbl_patNationalID = new System.Windows.Forms.Label();
            this.lbl_patAge = new System.Windows.Forms.Label();
            this.lbl_patMobilenumber = new System.Windows.Forms.Label();
            this.txt_patUsername = new System.Windows.Forms.TextBox();
            this.txt_patPassword = new System.Windows.Forms.TextBox();
            this.txt_patName = new System.Windows.Forms.TextBox();
            this.txt_patNationalID = new System.Windows.Forms.TextBox();
            this.txt_patAge = new System.Windows.Forms.TextBox();
            this.txt_patMobilenumber = new System.Windows.Forms.TextBox();
            this.pnl_doctor.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_patient.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_registeras
            // 
            this.lbl_registeras.AutoSize = true;
            this.lbl_registeras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_registeras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registeras.Location = new System.Drawing.Point(3, 18);
            this.lbl_registeras.Name = "lbl_registeras";
            this.lbl_registeras.Size = new System.Drawing.Size(656, 18);
            this.lbl_registeras.TabIndex = 8;
            this.lbl_registeras.Text = "Register As";
            // 
            // cmb_registeras
            // 
            this.cmb_registeras.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmb_registeras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_registeras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_registeras.FormattingEnabled = true;
            this.cmb_registeras.Items.AddRange(new object[] {
            "Doctor",
            "Patient",
            "Nurse"});
            this.cmb_registeras.Location = new System.Drawing.Point(3, 39);
            this.cmb_registeras.Name = "cmb_registeras";
            this.cmb_registeras.Size = new System.Drawing.Size(656, 29);
            this.cmb_registeras.TabIndex = 0;
            this.cmb_registeras.SelectedIndexChanged += new System.EventHandler(this.cmb_registeras_SelectedIndexChanged);
            // 
            // pnl_doctor
            // 
            this.pnl_doctor.Controls.Add(this.tableLayoutPanel3);
            this.pnl_doctor.Location = new System.Drawing.Point(6, 78);
            this.pnl_doctor.Name = "pnl_doctor";
            this.pnl_doctor.Size = new System.Drawing.Size(468, 176);
            this.pnl_doctor.TabIndex = 10;
            this.pnl_doctor.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_username, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_password, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Fname, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Lname, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_mobile, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_department, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txt_username, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_password, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_fname, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt_lname, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt_mobile, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.txt_department, 1, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(468, 176);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(3, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(325, 40);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Confirm";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(334, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(325, 40);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Discard";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(3, 5);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(228, 18);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(237, 5);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(228, 18);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password";
            // 
            // lbl_Fname
            // 
            this.lbl_Fname.AutoSize = true;
            this.lbl_Fname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Fname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fname.Location = new System.Drawing.Point(3, 51);
            this.lbl_Fname.Name = "lbl_Fname";
            this.lbl_Fname.Size = new System.Drawing.Size(228, 18);
            this.lbl_Fname.TabIndex = 8;
            this.lbl_Fname.Text = "First Name";
            // 
            // lbl_Lname
            // 
            this.lbl_Lname.AutoSize = true;
            this.lbl_Lname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Lname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lname.Location = new System.Drawing.Point(237, 51);
            this.lbl_Lname.Name = "lbl_Lname";
            this.lbl_Lname.Size = new System.Drawing.Size(228, 18);
            this.lbl_Lname.TabIndex = 9;
            this.lbl_Lname.Text = "Last Name";
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_mobile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobile.Location = new System.Drawing.Point(3, 97);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(228, 18);
            this.lbl_mobile.TabIndex = 10;
            this.lbl_mobile.Text = "Mobile Number";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_department.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.Location = new System.Drawing.Point(237, 97);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(228, 18);
            this.lbl_department.TabIndex = 11;
            this.lbl_department.Text = "Department";
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(3, 26);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(228, 27);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(237, 26);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(228, 27);
            this.txt_password.TabIndex = 2;
            // 
            // txt_fname
            // 
            this.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_fname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(3, 72);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(228, 27);
            this.txt_fname.TabIndex = 3;
            // 
            // txt_lname
            // 
            this.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_lname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(237, 72);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(228, 27);
            this.txt_lname.TabIndex = 4;
            // 
            // txt_mobile
            // 
            this.txt_mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mobile.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_mobile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobile.Location = new System.Drawing.Point(3, 118);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(228, 27);
            this.txt_mobile.TabIndex = 5;
            // 
            // txt_department
            // 
            this.txt_department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_department.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_department.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_department.Location = new System.Drawing.Point(237, 118);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(228, 27);
            this.txt_department.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_save, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_cancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 373);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(662, 46);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_registeras, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_registeras, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 72);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // pnl_patient
            // 
            this.pnl_patient.Controls.Add(this.tableLayoutPanel4);
            this.pnl_patient.Location = new System.Drawing.Point(97, 121);
            this.pnl_patient.Name = "pnl_patient";
            this.pnl_patient.Size = new System.Drawing.Size(468, 176);
            this.pnl_patient.TabIndex = 13;
            this.pnl_patient.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_patUsername, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_patPassword, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_patName, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_patNationalID, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_patAge, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lbl_patMobilenumber, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.txt_patUsername, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_patPassword, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_patName, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txt_patNationalID, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.txt_patAge, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.txt_patMobilenumber, 1, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(468, 176);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lbl_patUsername
            // 
            this.lbl_patUsername.AutoSize = true;
            this.lbl_patUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_patUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patUsername.Location = new System.Drawing.Point(3, 5);
            this.lbl_patUsername.Name = "lbl_patUsername";
            this.lbl_patUsername.Size = new System.Drawing.Size(228, 18);
            this.lbl_patUsername.TabIndex = 6;
            this.lbl_patUsername.Text = "Username";
            // 
            // lbl_patPassword
            // 
            this.lbl_patPassword.AutoSize = true;
            this.lbl_patPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_patPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patPassword.Location = new System.Drawing.Point(237, 5);
            this.lbl_patPassword.Name = "lbl_patPassword";
            this.lbl_patPassword.Size = new System.Drawing.Size(228, 18);
            this.lbl_patPassword.TabIndex = 7;
            this.lbl_patPassword.Text = "Password";
            // 
            // lbl_patName
            // 
            this.lbl_patName.AutoSize = true;
            this.lbl_patName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_patName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patName.Location = new System.Drawing.Point(3, 51);
            this.lbl_patName.Name = "lbl_patName";
            this.lbl_patName.Size = new System.Drawing.Size(228, 18);
            this.lbl_patName.TabIndex = 8;
            this.lbl_patName.Text = "Name";
            // 
            // lbl_patNationalID
            // 
            this.lbl_patNationalID.AutoSize = true;
            this.lbl_patNationalID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_patNationalID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patNationalID.Location = new System.Drawing.Point(237, 51);
            this.lbl_patNationalID.Name = "lbl_patNationalID";
            this.lbl_patNationalID.Size = new System.Drawing.Size(228, 18);
            this.lbl_patNationalID.TabIndex = 9;
            this.lbl_patNationalID.Text = "National ID";
            // 
            // lbl_patAge
            // 
            this.lbl_patAge.AutoSize = true;
            this.lbl_patAge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_patAge.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patAge.Location = new System.Drawing.Point(3, 97);
            this.lbl_patAge.Name = "lbl_patAge";
            this.lbl_patAge.Size = new System.Drawing.Size(228, 18);
            this.lbl_patAge.TabIndex = 10;
            this.lbl_patAge.Text = "Age";
            // 
            // lbl_patMobilenumber
            // 
            this.lbl_patMobilenumber.AutoSize = true;
            this.lbl_patMobilenumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_patMobilenumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patMobilenumber.Location = new System.Drawing.Point(237, 97);
            this.lbl_patMobilenumber.Name = "lbl_patMobilenumber";
            this.lbl_patMobilenumber.Size = new System.Drawing.Size(228, 18);
            this.lbl_patMobilenumber.TabIndex = 11;
            this.lbl_patMobilenumber.Text = "Mobile Number";
            // 
            // txt_patUsername
            // 
            this.txt_patUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patUsername.Location = new System.Drawing.Point(3, 26);
            this.txt_patUsername.Name = "txt_patUsername";
            this.txt_patUsername.Size = new System.Drawing.Size(228, 27);
            this.txt_patUsername.TabIndex = 1;
            // 
            // txt_patPassword
            // 
            this.txt_patPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patPassword.Location = new System.Drawing.Point(237, 26);
            this.txt_patPassword.Name = "txt_patPassword";
            this.txt_patPassword.PasswordChar = '●';
            this.txt_patPassword.Size = new System.Drawing.Size(228, 27);
            this.txt_patPassword.TabIndex = 2;
            // 
            // txt_patName
            // 
            this.txt_patName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patName.Location = new System.Drawing.Point(3, 72);
            this.txt_patName.Name = "txt_patName";
            this.txt_patName.Size = new System.Drawing.Size(228, 27);
            this.txt_patName.TabIndex = 3;
            // 
            // txt_patNationalID
            // 
            this.txt_patNationalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patNationalID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patNationalID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patNationalID.Location = new System.Drawing.Point(237, 72);
            this.txt_patNationalID.Name = "txt_patNationalID";
            this.txt_patNationalID.Size = new System.Drawing.Size(228, 27);
            this.txt_patNationalID.TabIndex = 4;
            // 
            // txt_patAge
            // 
            this.txt_patAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patAge.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patAge.Location = new System.Drawing.Point(3, 118);
            this.txt_patAge.Name = "txt_patAge";
            this.txt_patAge.Size = new System.Drawing.Size(228, 27);
            this.txt_patAge.TabIndex = 5;
            // 
            // txt_patMobilenumber
            // 
            this.txt_patMobilenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patMobilenumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patMobilenumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patMobilenumber.Location = new System.Drawing.Point(237, 118);
            this.txt_patMobilenumber.Name = "txt_patMobilenumber";
            this.txt_patMobilenumber.Size = new System.Drawing.Size(228, 27);
            this.txt_patMobilenumber.TabIndex = 6;
            // 
            // frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 419);
            this.Controls.Add(this.pnl_patient);
            this.Controls.Add(this.pnl_doctor);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frm_register";
            this.Text = "frm_register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_register_FormClosed);
            this.Load += new System.EventHandler(this.frm_register_Load);
            this.pnl_doctor.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnl_patient.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_registeras;
        private System.Windows.Forms.ComboBox cmb_registeras;
        private System.Windows.Forms.Panel pnl_doctor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_Fname;
        private System.Windows.Forms.Label lbl_Lname;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnl_patient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_patUsername;
        private System.Windows.Forms.Label lbl_patPassword;
        private System.Windows.Forms.Label lbl_patName;
        private System.Windows.Forms.Label lbl_patNationalID;
        private System.Windows.Forms.Label lbl_patAge;
        private System.Windows.Forms.Label lbl_patMobilenumber;
        private System.Windows.Forms.TextBox txt_patUsername;
        private System.Windows.Forms.TextBox txt_patPassword;
        private System.Windows.Forms.TextBox txt_patName;
        private System.Windows.Forms.TextBox txt_patNationalID;
        private System.Windows.Forms.TextBox txt_patAge;
        private System.Windows.Forms.TextBox txt_patMobilenumber;
    }
}