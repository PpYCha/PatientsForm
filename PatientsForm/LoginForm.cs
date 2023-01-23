using PatientsForm.models;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientsForm
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            using (PatientContext ctx = new PatientContext())
            {
                var user = ctx.UserAccounts.Where(u => u.Username.Equals(tb_loginUsername.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password != tb_loginPassword.Text)
                    {
                        MessageBox.Show("Invalid Password.");
                    }
                   
                    else
                    {
                      
                        DashboardForm.isLogin = true;

                    
                       

                        this.Close();

                    }
                }
                else
                {
                    MessageBox.Show("No (" + tb_loginUsername.Text + ") user found");
                }
            }
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm= new RegisterForm();
            registerForm.ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
