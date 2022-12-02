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
    public partial class frmMantenimiento : Form
    {
        public frmMantenimiento()
        {
            InitializeComponent();
        }

        private void btnCcleaner_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\ccsetup578.exe");
        }

        private void btnDBooster_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\driverbooster_setup.exe");
        }

        private void btnRecuva_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\Recuva.exe");
        }

        private void btnRevoUninstaller_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\RevoUninstaller.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\Victoria\Victoria.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\HDsentinental\HDSentinel.exe");
        }
    }
}
