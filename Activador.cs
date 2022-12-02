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
    public partial class frmActivador : Form
    {
        public frmActivador()
        {
            InitializeComponent();
        }

        private void btnToolkit_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\Microsoft Toolkit 2.7.3\Microsoft Toolkit.exe");
        }

        private void btnPortable_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\KMSportable\KMS Tools Unpack.exe");
        }

        private void btnCMD2013_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\ActivadorCMD\ActivadorOffice2016.bat");
        }

        private void btnCmd2019_Click(object sender, EventArgs e)
        {
            Process.Start(@"Utilitarios\ActivadorCMD\ActivadorOffice2019.bat");
        }

        private void btnCMD2021_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\ActivadorCMD\Office2021.txt");
        }


    }
}
