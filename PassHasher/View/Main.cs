using System;
using System.Diagnostics;
using System.Windows.Forms;
using PassHasher.Business;

namespace PassHasher
{
    public partial class Main : Form
    {
        Encrypt clsEncrypt = new Encrypt();
        public Main()
        {
            InitializeComponent();
        }

        // Make Form Moveable by Mouse
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // End Make Form Moveable by Mouse

        private void PictureExit_MouseEnter(object sender, EventArgs e)
        {
            PictureExit.Image = PassHasher.Properties.Resources.HoverClose;
        }

        private void PictureExit_MouseLeave(object sender, EventArgs e)
        {
            PictureExit.Image = PassHasher.Properties.Resources.Close;
        }

        private void PictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDevWeb_Click(object sender, EventArgs e)
        {
            Process.Start("https://ArminSharifi.ir");
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            fncSelectHashText();
        }

        private void fncSelectHashText()
        {
            if (txtPlain.Text != "")
            {
                if (rdbSha1XBig.Checked)
                {
                    txtHashed.Text = clsEncrypt.fncEncryptSha1(txtPlain.Text, "X2");
                }
                if (rdbSha1XS.Checked)
                {
                    txtHashed.Text = clsEncrypt.fncEncryptSha1(txtPlain.Text, "x2");
                }
                if (rdbMD5.Checked)
                {
                    txtHashed.Text = clsEncrypt.fncEncryptMD5(txtPlain.Text);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Plain Text","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
