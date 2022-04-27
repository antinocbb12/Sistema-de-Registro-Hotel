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

namespace CRUD_PRESENTACION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;        
            restaurar.Visible = false;
            maximisar.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            this.WindowState = FormWindowState.Maximized;
            maximisar.Visible = false;
            restaurar.Visible = true;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void fromH_cliente(object fromhija)
        {
            if (this.PANELPRINCIPAL.Controls.Count > 0)
            {
                this.PANELPRINCIPAL.Controls.RemoveAt(0);
            }
            Form fh = fromhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PANELPRINCIPAL.Controls.Add(fh);
            this.PANELPRINCIPAL.Tag = fh;
            fh.Show();
        }

        private void BTNCLIENTE_Click(object sender, EventArgs e)
        {
            fromH_cliente(new FROMCLIENTE());
        }
        private void fromH_reporte(object fromhija)
        {
            if (this.PANELPRINCIPAL.Controls.Count > 0)
                this.PANELPRINCIPAL.Controls.RemoveAt(0);
            Form fh = fromhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PANELPRINCIPAL.Controls.Add(fh);
            this.PANELPRINCIPAL.Tag = fh;
            fh.Show();
        }
        private void btnreportes_Click(object sender, EventArgs e)
        {
            fromH_reporte(new FROM_REPORTES());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirfroulario<FROMCLIENTE>();
        }
        private void abrirfroulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PANELPRINCIPAL.Controls.OfType<MiForm>().FirstOrDefault();//busnca en la colecion el formulario
            //si el formulario si existe en la estancia
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PANELPRINCIPAL.Controls.Add(formulario);
                PANELPRINCIPAL.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirfroulario<FROM_REPORTES>();
        }
    }
}
