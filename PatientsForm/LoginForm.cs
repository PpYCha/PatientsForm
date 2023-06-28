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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

                        DashboardForm.userType = user.Usertype;
                       

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

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
