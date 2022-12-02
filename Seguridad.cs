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
using System.Diagnostics;
using System.Linq.Expressions;

namespace WINBOOT
{

    public partial class frmSeguridad : Form
    {
        private static frmSeguridad instancia = null;

        public static frmSeguridad ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new frmSeguridad();
                return instancia;
            }
            return instancia;
        }

        public frmSeguridad()
        {
            InitializeComponent();
        }

        private void frmSeguridad_Load(object sender, EventArgs e)
        {

        }

        private void btnAvast_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\avast_premium.exe");
            
        }

        private void btnAVG_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\avg_antivirus_free_setup_offline.exe");
        }

        private void btnEset_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\eset_eav_setup64.exe");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Process.Start(@".\Utilitarios\malwarebytes_setup.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\kaspersky.exe");
        }
    }
}
