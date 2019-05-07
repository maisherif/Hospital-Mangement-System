﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace HospitalManagementSystem
{
    public partial class frm_register : Form
    {
        Point lastLoc;

        string orcl = "Data Source = orcl; User Id = hr; Password = hr";
        OracleConnection con;

        public frm_register()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            if (cmb_registeras.SelectedItem.ToString() == "Doctor")
            {
                cmd.CommandText = "INSERT INTO Doctor " +
                    "VALUES (:username, :password, :fname, :lname, :mobilenumber, :department)";
                cmd.Parameters.Add("username", txt_username.Text);
                cmd.Parameters.Add("password", Cryptography.Encrypt(txt_password.Text));
                cmd.Parameters.Add("fname", txt_fname.Text);
                cmd.Parameters.Add("lname", txt_lname.Text);
                cmd.Parameters.Add("mobilenumber", txt_mobile.Text);
                cmd.Parameters.Add("department", txt_department.Text);
            }
            else if (cmb_registeras.SelectedItem.ToString() == "Patient")
            {
                cmd.CommandText = "INSERT INTO Patient " +
                    "VALUES (:username, :password, :name, :nationalid, :age, :mobilenumber)";
                cmd.Parameters.Add("username", txt_patUsername.Text);
                cmd.Parameters.Add("password", Cryptography.Encrypt(txt_patPassword.Text));
                cmd.Parameters.Add("name", txt_patName.Text);
                cmd.Parameters.Add("nationalid", txt_patNationalID.Text);
                cmd.Parameters.Add("age", txt_patAge.Text);
                cmd.Parameters.Add("mobilenumber", txt_patMobilenumber.Text);
            }
            else if (cmb_registeras.SelectedItem.ToString() == "Nurse")
            {
                cmd.CommandText = "INSERT INTO Nurse " +
                    "VALUES (:username, :password, :fname, :lname, :mobilenumber)";
                cmd.Parameters.Add("username", txt_nurUsername.Text);
                cmd.Parameters.Add("password", Cryptography.Encrypt(txt_nurPassword.Text));
                cmd.Parameters.Add("fname", txt_nurFname.Text);
                cmd.Parameters.Add("lname", txt_nurLname.Text);
                cmd.Parameters.Add("mobilenumber", txt_nurMobile.Text);
            }

            int row = cmd.ExecuteNonQuery();
            if (row != -1)
            {
                DialogResult res = MessageBox.Show("Registration Done Successfully.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                    this.Close();
            }
        }

        private void frm_register_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Dispose();
        }

        private void frm_register_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(orcl);
            con.Open();

            cmb_registeras.SelectedIndex = 0;
        }

        private void cmb_registeras_SelectedIndexChanged(object sender, EventArgs e)
        {
            showRequiredPanel(cmb_registeras.SelectedItem.ToString());
        }

        private void showRequiredPanel(string registerAs)
        {
            if (registerAs == "Doctor")
            {
                pnl_patient.Visible = false;
                pnl_nurse.Visible = false;
                pnl_doctor.Visible = true;
                pnl_doctor.Dock = DockStyle.Fill;
                txt_username.Focus();
            }
            else if (registerAs == "Patient")
            {
                pnl_doctor.Visible = false;
                pnl_nurse.Visible = false;
                pnl_patient.Visible = true;
                pnl_patient.Dock = DockStyle.Fill;
                txt_patUsername.Focus();
            }
            else if (registerAs == "Nurse")
            {
                pnl_doctor.Visible = false;
                pnl_patient.Visible = false;
                pnl_nurse.Visible = true;
                pnl_nurse.Dock = DockStyle.Fill;
                txt_nurUsername.Focus();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel6_MouseDown(object sender, MouseEventArgs e)
        {
            lastLoc = e.Location;
        }

        private void tableLayoutPanel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point((this.Location.X - lastLoc.X) + e.X, (this.Location.Y - lastLoc.Y) + e.Y);
            }
        }
    }
}
