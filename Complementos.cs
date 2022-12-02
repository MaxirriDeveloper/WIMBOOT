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
    public partial class frmComplementos : Form
    {
        public frmComplementos()
        {
            InitializeComponent();
        }

        private void btnVStudio_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\NetFrameWoks4.8.exe");
        }

        private void btnNitro_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\nitro_pro10_x64.exe");
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\AdobeDC.exe");
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\Zoom.exe");
        }

        private void btnZip_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\7z1900x64.exe");
        }

        private void btnRar_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\Winrar.exe");
        }
    }
}
