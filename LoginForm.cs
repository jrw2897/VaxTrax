using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaxTrax_2._0_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            GlobalUser.UserID = userIDTextBox.Text.Trim();
            GlobalUser.Password = passwordTextBox.Text.Trim();

            try
            {
                bool status = LoginMethod.IsValid();

                if (status)
                {
                    MessageBox.Show("Login Good! Welcome " + GlobalUser.UserID);

                    MainForm newMainForm = new MainForm();

                    newMainForm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Bad");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Login Bad");
            }
            
            /*
            MainForm newMainForm = new MainForm();

            newMainForm.Show();

            this.Hide();
            */
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
