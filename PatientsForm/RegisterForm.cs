using Microsoft.EntityFrameworkCore;
using PatientsForm.models;
using PatientsForm.Models;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientsForm
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void bt_SaveUser_Click(object sender, EventArgs e)
        {
            using (var context = new PatientContext())
            {
                var user = new UserAccount
                {
                    FirstName = tb_uFirstName.Text,
                    LastName = tb_uLastName.Text,
                    Username = tb_uUserName.Text,
                    Password = tb_uPassword.Text,
                    Usertype = cb_Usertype.Text,

                };
                context.UserAccounts.Add(user);
                context.SaveChanges();
                if (MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }


            }
        }

        private void bt_BackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm= new LoginForm();
            loginForm.ShowDialog(); 
        }
    }
}
