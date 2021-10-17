using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace practica071021
{
    class Alumnos
    {
        public string IdStudent { get; set; }
        public string NameStudent { get; set; }
        public string LastNameStudent { get; set; }
        public string AgeStudent { get; set; }
        public string SesionStudent { get; set; }
        public string StudentSchoolYear { get; set; }

        //instancias a la clase Crud
        private CRUD crud = new CRUD();

        //metodo para retornar los registros de la tabla de estudiantes
        public MySqlDataReader getAllStudents()
        {
            string query = "SELECT IdStudent,NameStudent,LastNameStudent,AgeStudent,SesionStudent,StudentSchoolYear FROM alumnos";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }

        //metodo para insertar o editar un registro
        public Boolean newEditStudent(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO alumnos(IdStudent, NameStudent, LastNameStudent, AgeStudent, SesionStudent, StudentSchoolYear  )" +
                    "VALUES ('" + IdStudent + "', '" + NameStudent + "', '" + LastNameStudent + "', '" + AgeStudent + "', '" + SesionStudent + "', '" + StudentSchoolYear + "')";
                crud.executeQuery(query); //llamato al metodo executeQuery de la clase Crud
                return true;
            }
            else if (action == "edit")
            {
                string query = "UPDATE alumnos SET "
                    + "NameStudent='" + NameStudent + "' ,"
                    + "LastNameStudent='" + LastNameStudent + "',"
                    + "AgeStudent='" + AgeStudent + "',"
                    + "SesionStudent='" + SesionStudent + "'"
                    + "StudentSchoolYear='" + StudentSchoolYear + "'"
                    + "WHERE"
                    + "IdStudent='" + IdStudent + "'";

                crud.executeQuery(query);
                return true;
            }

            return false;
        }
        public Boolean deleteStudent()
        {
            string query = "DELETE FROM alumnos WHERE IdStudent='" + IdStudent + "'";
            crud.executeQuery(query);
            return true;
        }

    }
}
