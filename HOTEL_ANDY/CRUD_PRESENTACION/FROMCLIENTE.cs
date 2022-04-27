using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_NEGOCIO;
namespace CRUD_PRESENTACION
{
    public partial class FROMCLIENTE : Form
    {
        public FROMCLIENTE()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel_habitacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsiguiente2_Click(object sender, EventArgs e)
        {
            abrirfroulario<FROM_PISO2>();

        }
        private void abrirfroulario<MiForm2>() where MiForm2 : Form, new()
        {
            Form formulario2;
            formulario2 = panel_habitacion.Controls.OfType<MiForm2>().FirstOrDefault();//busnca en la colecion el formulario
            //si el formulario si existe en la estancia
            if (formulario2 == null)
            {
                formulario2 = new MiForm2();
                formulario2.TopLevel = false;
                formulario2.FormBorderStyle = FormBorderStyle.None;
                formulario2.Dock = DockStyle.Fill;
                panel_habitacion.Controls.Add(formulario2);
                panel_habitacion.Tag = formulario2;
                formulario2.Show();
                formulario2.BringToFront();
            }
            else
            {
                formulario2.BringToFront();
            }
        }

        private void FROMCLIENTE_Load(object sender, EventArgs e)
        {
            mostrar_estancia();
        }

        private void mostrar_estancia()
        {
            NEGOCIO_CLIENTE objestancia = new NEGOCIO_CLIENTE();
            dataGridView1.DataSource = objestancia.mostrar_estancia();
        }
    }
}
