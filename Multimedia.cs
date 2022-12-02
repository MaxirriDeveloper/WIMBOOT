using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WINBOOT
{
    public partial class frmMultimedia : Form
    {
        public frmMultimedia()
        {
            InitializeComponent();
        }

        private void btnInternetDowloand_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\idm_setup.exe");
        }

        private void btnVLC_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\vlc-3.0.12-win64.exe");
        }

        private void btnPowerDVD_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\powerdvd_setup.exe");
        }

        private void btnNERO_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\Nero 2020.exe");
        }

        private void btnTeamviewer_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\TeamViewer_Setup.exe");
        }

        private void btnAnydesk_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\AnyDesk.exe");
        }
    }
    
}
