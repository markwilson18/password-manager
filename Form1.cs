using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        string log;

        private void label1_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "Wilson" && txt_password.Text == "1999")
            {
                Form home = new frm_home(log);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password you entered is incorrect");
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
