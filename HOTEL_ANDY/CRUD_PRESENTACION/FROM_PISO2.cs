using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_PRESENTACION
{
    public partial class FROM_PISO2 : Form
    {
        public FROM_PISO2()
        {
            InitializeComponent();
        }

        private void panel_hobitacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsiguiente1_Click(object sender, EventArgs e)
        {

        }

        private void panel_hobitacion_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnanterior1_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnsiguien2_Click(object sender, EventArgs e)
        {
            abrirfroulario<FROM_PISO3>();

        }
        private void abrirfroulario<MiForm3>() where MiForm3 : Form, new()
        {
            Form formulario3;
            formulario3 = panel_piso2.Controls.OfType<MiForm3>().FirstOrDefault();//busnca en la colecion el formulario
            //si el formulario si existe en la estancia
            if (formulario3 == null)
            {
                formulario3 = new MiForm3();
                formulario3.TopLevel = false;
                formulario3.FormBorderStyle = FormBorderStyle.None;
                formulario3.Dock = DockStyle.Fill;
                panel_piso2.Controls.Add(formulario3);
                panel_piso2.Tag = formulario3;
                formulario3.Show();
                formulario3.BringToFront();
            }
            else
            {
                formulario3.BringToFront();
            }
        }
    }
}