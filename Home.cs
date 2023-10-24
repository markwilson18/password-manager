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
    public partial class frm_home : Form
    {
        public frm_home(string log)
        {
            InitializeComponent();
            lbl_loguser.Text = log;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login fl = new frm_login();
            fl.Show();
            this.Hide();
        }

        private void btn_passwordmanager_Click(object sender, EventArgs e)
        {
            frm_passwordmanager fau = new frm_passwordmanager();
            fau.ShowDialog();
        }

        private void frm_home_Load(object sender, EventArgs e)
        {

        }
    }
}
