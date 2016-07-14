namespace DRMCR
{
    partial class Frm_manageDB
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
            this.btn_restore = new System.Windows.Forms.Button();
            this.btnn_backup = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_restore
            // 
            this.btn_restore.Image = global::DRMCR.Properties.Resources.iconmonstr_disk_16_32;
            this.btn_restore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_restore.Location = new System.Drawing.Point(165, 140);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(98, 50);
            this.btn_restore.TabIndex = 1;
            this.btn_restore.Text = "Restore";
            this.btn_restore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnn_backup
            // 
            this.btnn_backup.Image = global::DRMCR.Properties.Resources.iconmonstr_disk_14_32__1_;
            this.btnn_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnn_backup.Location = new System.Drawing.Point(12, 140);
            this.btnn_backup.Name = "btnn_backup";
            this.btnn_backup.Size = new System.Drawing.Size(98, 50);
            this.btnn_backup.TabIndex = 0;
            this.btnn_backup.Text = "Backup";
            this.btnn_backup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnn_backup.UseVisualStyleBackColor = true;
            this.btnn_backup.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Image = global::DRMCR.Properties.Resources.iconmonstr_log_out_3_32;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(317, 143);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(92, 44);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DRMCR.Properties.Resources.iconmonstr_refresh_3_321;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_manageDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 203);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.btnn_backup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_manageDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_manageDB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnn_backup;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}