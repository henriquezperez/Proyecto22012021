using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoII
{
    public partial class fmrNombre1 : Form
    {

        public static Nombres _name;

        public fmrNombre1()
        {
            InitializeComponent();
        }

        private void fmrNombre1_Load(object sender, EventArgs e)
        {

        }

        public void nombre()
        {

        }

        private void buttonGuardarNombre1_Click(object sender, EventArgs e)
        {

            //string name;

            Nombres name = new Nombres()
            {
                NombresBox = textBoxName1.Text
            };

            // Nombres = textBoxName1.Text;
            //FormPrincipal.(name);

            FormPrincipal a = new FormPrincipal(name);
            
            this.Close();
      
        }

        private void textBoxName1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
