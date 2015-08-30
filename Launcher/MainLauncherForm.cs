using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Launcher
{
    public partial class MainLauncherForm : Form
    {
        public MainLauncherForm()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.wow_path);
            this.Close();
        }

        private void WebsiteButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.website);
        }

        private void VoteButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.votelink);
        }

        private void CacheButton_Click(object sender, EventArgs e)
        {
            var cachefolder = Properties.Settings.Default.wow_path.Substring(0, Properties.Settings.Default.wow_path.Length - 7);
            if(Directory.Exists(cachefolder + "Cache"))
            {
                Directory.Delete(cachefolder + "Cache", true);
                MessageBox.Show("Cache Cleared!");
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainLauncherForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainLauncherForm_Load(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Properties.Settings.Default.wow_path))
            {
                //select wow.exe
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.wow_path = openFileDialog1.FileName;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MainLauncherForm_Load(sender, e);
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
