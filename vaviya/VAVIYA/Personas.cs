using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAVIYA
{
    public partial class Personas : Form
    {
       
        PersonasBL personasdata = new BusinessLayer.PersonasBL();
        public Personas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            { 
                if (cedu_perso.Text != "" && cbo_rol.Text != "" && nombre_perso.Text != "" && tel_perso.Text != "" && direc_perso.Text != "" && correo_perso.Text != "")
                {
                    if (apellidos_perso.Text == "")
                    {
                        apellidos_perso.Text = " ";
                    }
                    string cedula = cedu_perso.Text;

               
                    personasdata.LLama_tipo_personas(cedula, cbo_rol.Text);
                    personasdata.LLamas_ingre_personas(nombre_perso.Text, apellidos_perso.Text, tel_perso.Text, direc_perso.Text, correo_perso.Text, cedula,cbo_rol.Text);
                    string valor_re = personasdata.LLama_regis_perso();
                    codigo_perso.Text = valor_re;
                    cedu_perso.Text = "";
                    cbo_rol.Text = "";
                    nombre_perso.Text = "";
                    apellidos_perso.Text = "";
                    tel_perso.Text = "";
                    direc_perso.Text = "";
                    correo_perso.Text = "";
                    string message = "Datos Registrados!!";
                    string title = "VAVIYA";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                }
                else
                {
                    string message = "Hay datos vacios. Verifique";
                    string title = "VAVIYA";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }

            }
            catch
            {
                string message = "Hay datos vacios. Verifique";
                string title = "VAVIYA";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }

        }

        private void Personas_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            cbo_rol.Items.Add("Cliente");
            cbo_rol.Items.Add("Proveedor");
            cbo_rol.Items.Add("Empleado");
            string valor_re = personasdata.LLama_regis_perso();
            codigo_perso.Text = valor_re;

            this.Dock = DockStyle.Fill;
            var dt = personasdata.ObtenerPersonas();
            dataGridView1.DataSource = dt;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cedu_perso.Text="";
            cbo_rol.Text="";
            nombre_perso.Text = "";
            apellidos_perso.Text = "";
            tel_perso.Text = "";
            direc_perso.Text = "";
            correo_perso.Text = "";

        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = cedu_perso.Text;
                personasdata.LLama_elimina_personas(cedula);
                cedu_perso.Text = "";

                string message = "Datos Eliminados!!";
                string title = "VAVIYA";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                string valor_re = personasdata.LLama_regis_perso();
                codigo_perso.Text = valor_re;
            }
            catch
            {
                string message = "Verifique la cedula";
                string title = "VAVIYA";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }


        }

        private void cedu_perso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            

        }

        private void cedu_perso_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_perso_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_perso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            //{
            //    e.Handled = true;
            //}
        }

        private void apellidos_perso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            //{
            //    e.Handled = true;
            //}
        }

        private void tel_perso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void correo_perso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void cbo_rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_rol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            frm_bienvenida bienve = new frm_bienvenida();
            bienve.MdiParent = this.MdiParent;
            bienve.Show();
            this.Close();
        }
    }

}