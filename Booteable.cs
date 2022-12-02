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
    public partial class frmBooteable : Form
    {
        public frmBooteable()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\YUMI.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\rufus.exe");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\ultraiso.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WIMBOOT\Utilitarios\PowerISO.exe");
        }
    }
}
