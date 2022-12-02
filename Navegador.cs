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
    public partial class frmNavegador : Form
    {
        private static frmNavegador instancia = null;
        
        public static frmNavegador ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new frmNavegador();
                return instancia;
            }
            return instancia;
        }
 
        public frmNavegador()
        {
            InitializeComponent();
        }

        private void btnChrome_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\WIMBOOT\Utilitarios\ChromeStandaloneSetup64.exe";
            proceso.Start();
        }

        private void btnFireFox_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\WIMBOOT\Utilitarios\Firefox Setup 87.0_64.exe";
            proceso.Start();
        }

        private void btnEdge_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\WIMBOOT\Utilitarios\MicrosoftEdgeX64.exe";
            proceso.Start();
        }

        private void btnOpera_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\WIMBOOT\Utilitarios\OperaX64.exe";
            proceso.Start();
        }

        private void btnGx_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\WIMBOOT\Utilitarios\OperaGXSetup.exe";
            proceso.Start();
        }

        private void btnBrave_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\WIMBOOT\Utilitarios\BraveSetup64.exe";
            proceso.Start();
        }
    }
}
