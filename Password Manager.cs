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
    public partial class frm_passwordmanager : Form
    {
        public frm_passwordmanager()
        {
            InitializeComponent();
        }

        private void Edit(bool value)
        {
            txt_userName.Enabled = value;
            txt_password.Enabled = value;
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            {
                Edit(true);
                dataApp.tbllog.AddtbllogRow(dataApp.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit(true);
        }

        private void frm_passwordmanager_Load(object sender, EventArgs e)
        {
            this.tbllogTableAdapter.Fill(this.dataApp.tbllog);
            Edit(true);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.EndEdit();
            tbllogTableAdapter.Update(dataApp.tbllog);
            dgv_adminuser.Refresh();
            txt_userName.Focus();
            MessageBox.Show("Your Name has successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.CancelEdit();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbllogBindingSource.RemoveCurrent();
            }
        }
    }
}
