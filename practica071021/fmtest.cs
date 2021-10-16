using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace practica071021
{
    public partial class fmtest : Form
    {
        public fmtest()
        {
            InitializeComponent();
        }

        private void fmtest_Load(object sender, EventArgs e)
        {

        }

        private void frmTest_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            MySqlConnection conn;

            try
            {
                connectionString = @"Server=localhost;Database=smis068421;Uid=root;Pwd=usbw;SSL Mode=None";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                //MessageBox.Show("Se establecio conexión correctamente");
                MetroFramework.MetroMessageBox.Show(this, "conexion exitosa", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message);
                MetroFramework.MetroMessageBox.Show(this, Ex.Message,"error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fmtest_Load_1(object sender, EventArgs e)
        {

        }
    }
}
