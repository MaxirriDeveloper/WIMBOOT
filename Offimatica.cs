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
    public partial class frmOffimatica : Form
    {
        private static frmOffimatica instancia = null;

        public static frmOffimatica ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new frmOffimatica();
                return instancia;
            }
            return instancia;
        }


        public frmOffimatica()
        {
            InitializeComponent();
        }

        private void Offimatica_Load(object sender, EventArgs e)
        {

        }

        private void btnOffice2013_Click(object sender, EventArgs e)
        {
            Process.Start(@"Utilitarios\..\setup.exe");
        }

        private void btnOffice2016_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\Office 2016\setup.exe");
        }

        private void btnOffice2021_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\Office 2021\office2021.bat");

        }

        private void btnOffice2019_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\Office 2021\office2019.exe");
        }
    }
}
