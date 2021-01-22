using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoII
{
    public partial class FormPrincipal : Form
    {
        // string nombre1form1;
        public static Nombres _name;

        public FormPrincipal()
        {
           // UpdateNombre();
            InitializeComponent();
            
        }
        public FormPrincipal(Nombres nombres)
        {
            labelName1.Text = nombres.ToString();
           
            InitializeComponent();
            
        }

        public void UpdateNombre()
        {
            
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonName1_Click(object sender, EventArgs e)
        {
            fmrNombre1 name1Call = new fmrNombre1();
            name1Call.ShowDialog();
            //labelName1.Text = nombre1form1;
           
        }
    }
}
