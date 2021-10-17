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

            clearDataGridView();

            dtgAlumnos.Columns.Add("IdStudent", "Codigo de el estudiante");
            dtgAlumnos.Columns.Add("NameStudent", "Nombre de el estudiante");
            dtgAlumnos.Columns.Add("LastNameStudent", "Apellido de el estudiante");
            dtgAlumnos.Columns.Add("AgeStudent", "edad de el estudiante");
            dtgAlumnos.Columns.Add("sesion", "Sección");
            dtgAlumnos.Columns.Add("Year", "Grado");

            //llamado al medoto getAllStudents() de la clase Alumnos
            MySqlDataReader dataReader = alumnos.getAllStudents();

            //leer el resultado y mostrarlo en el datagridview
            while (dataReader.Read())
            {
                dtgAlumnos.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4),
                        dataReader.GetValue(5)
                       );
            }
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
            if (txtIdStudent.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe rellenar todos los campos necesarios", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdStudent.Focus(); //enviamos el enfoque a la caja de texto

            }
            else
            {

                Alumnos alumno = new Alumnos(); //instancia de la clase Alumnos
                                                //evaluar la accion



                alumno.IdStudent = txtIdStudent.Text;
                alumno.NameStudent = txtLastNameStudent.Text;
                alumno.LastNameStudent = txtLastNameStudent.Text;
                alumno.AgeStudent = txtAgeStudent.Text;
                alumno.SesionStudent = cbSesionStudent.Text;
                alumno.StudentSchoolYear = cbYearStudent.Text;

                string mensaje = "Esta seguro que desea guardar el registro?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //LLAMAR AL METODO PARA GUARDAR
                    if (alumno.newEditStudent(action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamente!",
                            "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han guardado!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    clearControls();
                    controlsDisable();
                    fillDataGridView();

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            controlsEnable();

            txtIdStudent.Text = dtgAlumnos.CurrentRow.Cells[0].Value.ToString();
            txtNameStudent.Text = dtgAlumnos.CurrentRow.Cells[1].Value.ToString();
            txtLastNameStudent.Text = dtgAlumnos.CurrentRow.Cells[2].Value.ToString();
            txtAgeStudent.Text = dtgAlumnos.CurrentRow.Cells[3].Value.ToString();
            cbSesionStudent.Text = dtgAlumnos.CurrentRow.Cells[4].Value.ToString();
            cbYearStudent.Text = dtgAlumnos.CurrentRow.Cells[5].Value.ToString();

            //enviar aaccion
            action = "edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea eliminar el registro?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Alumnos alumnos = new Alumnos();
                alumnos.IdStudent = Convert.ToString(dtgAlumnos.CurrentRow.Cells[0].Value);

                //llamado al metodo deleteBook() de la clase Book
                if (alumnos.deleteStudent())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos se han eliminado exitosamente!",
                        "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //actualizar datagridview
                    fillDataGridView();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han podido eliminar",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
