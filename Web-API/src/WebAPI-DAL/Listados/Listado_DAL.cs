using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Ent;

namespace WebAPI_DAL.Listados
{
    public class Listado_DAL
    {
        Conexion conexionAlumno = new Conexion("AlumnoGuadalquimic", "fjmajada#)1617.");
        Conexion conexionProfesor = new Conexion("ProfesorGuadalquimic", "rbrln!?2201,");
        public ObservableCollection<Alumno> listadoAlumnos()
        {
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            Alumno miAlum;
            ObservableCollection<Alumno> devolver=new ObservableCollection<Alumno>();
            try
            {
                //TODO
                conexionAlumno.openConnection();
                consulta.CommandText = "Select ";
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new Alumno();
                        miAlum.Id = (int)lector["IDPersona"];
                        miAlum.Nombre = (String)lector["nombre"];
                        miAlum.Apellidos = (String)lector["apellidos"];
                        devolver.Add(miAlum);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexionAlumno.closeConnection();

            }
            return devolver;
        }
    }
}
