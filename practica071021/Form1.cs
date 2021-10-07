using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica071021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciamo 
            fmtest fm = new fmtest();
            fm.MdiParent = this;
            fm.Show();

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAlumno frm = new frmAlumno();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
