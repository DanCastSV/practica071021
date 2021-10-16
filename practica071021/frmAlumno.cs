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
    public partial class frmAlumno : Form
    {
        private string action = "";
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            fillDataGridView();

        }
        //utilizado para mostrar los registros en el datagridview
        public void fillDataGridView()
        {
            //instancia de la clase libro| Book
            Alumnos alumnos = new Alumnos();

           

            dtgAlumnos.Columns.Add("IdStudent", "Codigo de el estudiante");
            dtgAlumnos.Columns.Add("NameStudent", "Nombre de el estudiante");
            dtgAlumnos.Columns.Add("LastNameStudent", "Apellido de el estudiante");
            dtgAlumnos.Columns.Add("AgeStudent", "edad de el estudiante");
            dtgAlumnos.Columns.Add("Year", "Grado");
            dtgAlumnos.Columns.Add("sesion", "Sección");
            

            //llamado al medoto getAllStudents() de la clase Alumnos
            MySqlDataReader dataReader = alumnos.getAllStudents();

            //leer el resultado y mostrarlo en el datagridview
            //while (dataReader.Read())
            //{
            //    dtgAlumnos.Rows.Add(
            //            dataReader.GetValue(0),
            //            dataReader.GetValue(1),
            //            dataReader.GetValue(2),
            //            dataReader.GetValue(3),
            //            dataReader.GetValue(4),
            //            dataReader.GetValue(5),
            //            dataReader.GetValue(6)
            //           );
            //}
        }

        public void clearDataGridView()
        {
            dtgAlumnos.Columns.Clear();
            dtgAlumnos.Rows.Clear();
        }

        //deshabilita los controles de formulario
        public void controlsDisable()
        {
            txtIdStudent.Enabled = false;
            txtNameStudent.Enabled = false;
            txtLastNameStudent.Enabled = false;
            txtAgeStudent.Enabled = false;
            cbSesionStudent.Enabled = false;
            cbYearStudent.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        //habilitar los controles de formulario
        public void controlsEnable()
        {
            txtIdStudent.Enabled = true;
            txtNameStudent.Enabled = true;
            txtLastNameStudent.Enabled = true;
            txtAgeStudent.Enabled = true;
            cbSesionStudent.Enabled = true;
            cbYearStudent.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        //limpiar el contenido de los controles
        public void clearControls()
        {
            txtIdStudent.Text = "";
            txtNameStudent.Text = "";
            txtLastNameStudent.Text = "";
            txtAgeStudent.Text = "";
            cbSesionStudent.Text = "";
            cbYearStudent.Text = "";
        }

        private void dtgAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            action = "edit";

            controlsEnable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //codigo del boton salir
            string mensaje = "¿Está seguró que desea salir?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que desea cancelar?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearControls();
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
