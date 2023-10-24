namespace Password_Manager
{
    partial class frm_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home));
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_passwordmanager = new System.Windows.Forms.Button();
            this.lbl_loguser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DimGray;
            this.btn_logout.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(701, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(87, 31);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "LOG OUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_passwordmanager
            // 
            this.btn_passwordmanager.BackColor = System.Drawing.Color.DimGray;
            this.btn_passwordmanager.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_passwordmanager.ForeColor = System.Drawing.Color.Black;
            this.btn_passwordmanager.Location = new System.Drawing.Point(294, 212);
            this.btn_passwordmanager.Name = "btn_passwordmanager";
            this.btn_passwordmanager.Size = new System.Drawing.Size(185, 44);
            this.btn_passwordmanager.TabIndex = 0;
            this.btn_passwordmanager.Text = "PASSWORD MANAGER";
            this.btn_passwordmanager.UseVisualStyleBackColor = false;
            this.btn_passwordmanager.Click += new System.EventHandler(this.btn_passwordmanager_Click);
            // 
            // lbl_loguser
            // 
            this.lbl_loguser.AutoSize = true;
            this.lbl_loguser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loguser.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loguser.ForeColor = System.Drawing.Color.White;
            this.lbl_loguser.Location = new System.Drawing.Point(12, 12);
            this.lbl_loguser.Name = "lbl_loguser";
            this.lbl_loguser.Size = new System.Drawing.Size(174, 45);
            this.lbl_loguser.TabIndex = 1;
            this.lbl_loguser.Text = "WELCOME:";
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_loguser);
            this.Controls.Add(this.btn_passwordmanager);
            this.Controls.Add(this.btn_logout);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frm_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_passwordmanager;
        private System.Windows.Forms.Label lbl_loguser;
    }
}