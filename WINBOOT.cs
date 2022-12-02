using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace WINBOOT
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        int xClick =0;
        int yClick=0;
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void btnNavegador_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new frmNavegador());
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClick = e.X;
                yClick = e.Y;
            }
            else
            {
                Left = Left + (e.X - xClick);
                Top = Top + (e.Y - yClick);
            }
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new frmSeguridad());
        }

        private void btnOffimatica_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new frmOffimatica());
        }
        private void AbrirFormaHija(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnComplementos_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new frmComplementos());
        }

        private void btnActivador_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new frmActivador());
        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void imgWhatsapp_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://api.whatsapp.com/send?phone=51914591247&text=%F0%9F%8E%8A%C2%A1BIENVENIDO%20A%20CEOTECHNOLOGY%F0%9F%8E%8A%2C%20DESARROLLADOR%20DEL%20SOFTWARE%20WINBOOT!%20%F0%9F%A4%96%F0%9F%91%BE");
        }

        private void imgInstagram_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.instagram.com/ceo_technology/?hl=es");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://ceotechperu.com/");
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new frmMantenimiento());
        }

        private void btnUsb_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new frmBooteable());
        }

        private void btnJuegos_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new frmJuegos());
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new frmCreditos());
        }

        private void btnMultimedia_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new frmMultimedia());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
