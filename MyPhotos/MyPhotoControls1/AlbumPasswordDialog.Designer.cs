namespace Manning.MyPhotoControls
{
    partial class AlbumPasswordDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lnkOK = new System.Windows.Forms.LinkLabel();
            this.lnkCancel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(12, 12);
=======
            this.label1.Location = new System.Drawing.Point(23, 13);
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Album File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(14, 39);
=======
            this.label2.Location = new System.Drawing.Point(26, 39);
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Password:";
            // 
            // txtAlbum
            // 
<<<<<<< HEAD
            this.txtAlbum.Location = new System.Drawing.Point(76, 9);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.ReadOnly = true;
            this.txtAlbum.Size = new System.Drawing.Size(181, 20);
=======
            this.txtAlbum.Location = new System.Drawing.Point(87, 10);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.ReadOnly = true;
            this.txtAlbum.Size = new System.Drawing.Size(170, 20);
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
            this.txtAlbum.TabIndex = 2;
            // 
            // txtPassword
            // 
<<<<<<< HEAD
            this.txtPassword.Location = new System.Drawing.Point(76, 36);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 20);
=======
            this.txtPassword.Location = new System.Drawing.Point(88, 36);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 20);
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lnkOK
            // 
            this.lnkOK.AutoSize = true;
<<<<<<< HEAD
            this.lnkOK.Location = new System.Drawing.Point(12, 76);
=======
            this.lnkOK.Location = new System.Drawing.Point(29, 72);
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
            this.lnkOK.Name = "lnkOK";
            this.lnkOK.Size = new System.Drawing.Size(22, 13);
            this.lnkOK.TabIndex = 4;
            this.lnkOK.TabStop = true;
            this.lnkOK.Text = "OK";
            this.lnkOK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_LinkClicked);
            // 
            // lnkCancel
            // 
            this.lnkCancel.AutoSize = true;
<<<<<<< HEAD
            this.lnkCancel.Location = new System.Drawing.Point(217, 76);
=======
            this.lnkCancel.Location = new System.Drawing.Point(217, 72);
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
            this.lnkCancel.Name = "lnkCancel";
            this.lnkCancel.Size = new System.Drawing.Size(40, 13);
            this.lnkCancel.TabIndex = 5;
            this.lnkCancel.TabStop = true;
            this.lnkCancel.Text = "Cancel";
            this.lnkCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_LinkClicked);
            // 
            // AlbumPasswordDialog
            // 
            this.AcceptButton = this.lnkOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.lnkCancel;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(269, 98);
=======
            this.ClientSize = new System.Drawing.Size(269, 97);
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
            this.ControlBox = false;
            this.Controls.Add(this.lnkCancel);
            this.Controls.Add(this.lnkOK);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AlbumPasswordDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Please Enter Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel lnkOK;
        private System.Windows.Forms.LinkLabel lnkCancel;
    }
}