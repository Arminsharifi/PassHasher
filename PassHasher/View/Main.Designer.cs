
namespace PassHasher
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnDevWeb = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.PictureExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHashed = new System.Windows.Forms.TextBox();
            this.rdbSha1XBig = new System.Windows.Forms.RadioButton();
            this.rdbSha1XS = new System.Windows.Forms.RadioButton();
            this.rdbMD5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDevWeb
            // 
            this.btnDevWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnDevWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevWeb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnDevWeb.Location = new System.Drawing.Point(79, 369);
            this.btnDevWeb.Name = "btnDevWeb";
            this.btnDevWeb.Size = new System.Drawing.Size(217, 47);
            this.btnDevWeb.TabIndex = 5;
            this.btnDevWeb.Text = "Programmer Website";
            this.btnDevWeb.UseVisualStyleBackColor = false;
            this.btnDevWeb.Click += new System.EventHandler(this.btnDevWeb_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEncrypt.Location = new System.Drawing.Point(27, 261);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(320, 52);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // PictureExit
            // 
            this.PictureExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureExit.Image = global::PassHasher.Properties.Resources.Close;
            this.PictureExit.Location = new System.Drawing.Point(337, 7);
            this.PictureExit.Name = "PictureExit";
            this.PictureExit.Size = new System.Drawing.Size(32, 25);
            this.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureExit.TabIndex = 9;
            this.PictureExit.TabStop = false;
            this.PictureExit.Click += new System.EventHandler(this.PictureExit_Click);
            this.PictureExit.MouseEnter += new System.EventHandler(this.PictureExit_MouseEnter);
            this.PictureExit.MouseLeave += new System.EventHandler(this.PictureExit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password Hasher By Armin Sharifi";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.PictureExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 42);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            // 
            // txtPlain
            // 
            this.txtPlain.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlain.Location = new System.Drawing.Point(27, 94);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(320, 23);
            this.txtPlain.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(139, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Plain Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(126, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hashed Text";
            // 
            // txtHashed
            // 
            this.txtHashed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHashed.Location = new System.Drawing.Point(27, 172);
            this.txtHashed.Name = "txtHashed";
            this.txtHashed.ReadOnly = true;
            this.txtHashed.Size = new System.Drawing.Size(320, 23);
            this.txtHashed.TabIndex = 14;
            // 
            // rdbSha1XBig
            // 
            this.rdbSha1XBig.AutoSize = true;
            this.rdbSha1XBig.Checked = true;
            this.rdbSha1XBig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.rdbSha1XBig.Location = new System.Drawing.Point(69, 219);
            this.rdbSha1XBig.Name = "rdbSha1XBig";
            this.rdbSha1XBig.Size = new System.Drawing.Size(75, 17);
            this.rdbSha1XBig.TabIndex = 15;
            this.rdbSha1XBig.TabStop = true;
            this.rdbSha1XBig.Text = "SHA1 (X2)";
            this.rdbSha1XBig.UseVisualStyleBackColor = true;
            // 
            // rdbSha1XS
            // 
            this.rdbSha1XS.AutoSize = true;
            this.rdbSha1XS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.rdbSha1XS.Location = new System.Drawing.Point(159, 219);
            this.rdbSha1XS.Name = "rdbSha1XS";
            this.rdbSha1XS.Size = new System.Drawing.Size(73, 17);
            this.rdbSha1XS.TabIndex = 16;
            this.rdbSha1XS.Text = "SHA1 (x2)";
            this.rdbSha1XS.UseVisualStyleBackColor = true;
            // 
            // rdbMD5
            // 
            this.rdbMD5.AutoSize = true;
            this.rdbMD5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.rdbMD5.Location = new System.Drawing.Point(251, 219);
            this.rdbMD5.Name = "rdbMD5";
            this.rdbMD5.Size = new System.Drawing.Size(48, 17);
            this.rdbMD5.TabIndex = 17;
            this.rdbMD5.Text = "MD5";
            this.rdbMD5.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(375, 445);
            this.Controls.Add(this.rdbMD5);
            this.Controls.Add(this.rdbSha1XS);
            this.Controls.Add(this.rdbSha1XBig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHashed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDevWeb);
            this.Controls.Add(this.btnEncrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDevWeb;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.PictureBox PictureExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHashed;
        private System.Windows.Forms.RadioButton rdbSha1XBig;
        private System.Windows.Forms.RadioButton rdbSha1XS;
        private System.Windows.Forms.RadioButton rdbMD5;
    }
}

