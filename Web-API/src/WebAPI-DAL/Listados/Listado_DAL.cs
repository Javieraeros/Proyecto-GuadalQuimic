using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Ent;
using WebAPI_Ent.Models;

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
            String cadenaConsulta = String.Format("Select {0},{1},{2},{3},{4},{5} from {6}",Contrato.Alumno.ID,
                                                   Contrato.Alumno.NOMBRE,Contrato.Alumno.APELLIDOS,Contrato.Alumno.ALIAS,
                                                   Contrato.Alumno.CORREO,Contrato.Alumno.CURSO,Contrato.Alumno.TABLA);
            try
            {
                conexionAlumno.openConnection();
                consulta.CommandText = cadenaConsulta;
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new Alumno();
                        miAlum.Id = (int)lector[Contrato.Alumno.ID];
                        miAlum.Nombre = (String)lector[Contrato.Alumno.NOMBRE];
                        miAlum.Apellidos = (String)lector[Contrato.Alumno.APELLIDOS];
                        miAlum.Alias = (String)lector[Contrato.Alumno.ALIAS];
                        miAlum.Correo = (String)lector[Contrato.Alumno.CORREO];
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

        public ObservableCollection<Alumno> listadoAlumnosGrupos()
        {
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            AlumnoGrupo miAlum;
            ObservableCollection<Alumno> devolver = new ObservableCollection<Alumno>();
            String cadenaConsulta = String.Format("Select {0},{1} from {2}", Contrato.AlumnoGrupo.ID_ALUMNO,
                                                   Contrato.AlumnoGrupo.ID_GRUPO, Contrato.AlumnoGrupo.TABLA);
            try
            {
                conexionAlumno.openConnection();
                consulta.CommandText = cadenaConsulta;
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new AlumnoGrupo();
                        miAlum.Id_Alumno = (int)lector[Contrato.Alumno.ID];
                        miAlum.Nombre = (String)lector[Contrato.Alumno.NOMBRE];
                        miAlum.Apellidos = (String)lector[Contrato.Alumno.APELLIDOS];
                        miAlum.Alias = (String)lector[Contrato.Alumno.ALIAS];
                        miAlum.Correo = (String)lector[Contrato.Alumno.CORREO];
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

        public ObservableCollection<Alumno> listadoCentros()
        {
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            Alumno miAlum;
            ObservableCollection<Alumno> devolver = new ObservableCollection<Alumno>();
            String cadenaConsulta = String.Format("Select {0},{1},{2},{3},{4},{5} from {6}", Contrato.Alumno.ID,
                                                   Contrato.Alumno.NOMBRE, Contrato.Alumno.APELLIDOS, Contrato.Alumno.ALIAS,
                                                   Contrato.Alumno.CORREO, Contrato.Alumno.CURSO, Contrato.Alumno.TABLA);
            try
            {
                conexionAlumno.openConnection();
                consulta.CommandText = cadenaConsulta;
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new Alumno();
                        miAlum.Id = (int)lector[Contrato.Alumno.ID];
                        miAlum.Nombre = (String)lector[Contrato.Alumno.NOMBRE];
                        miAlum.Apellidos = (String)lector[Contrato.Alumno.APELLIDOS];
                        miAlum.Alias = (String)lector[Contrato.Alumno.ALIAS];
                        miAlum.Correo = (String)lector[Contrato.Alumno.CORREO];
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

        public ObservableCollection<Alumno> listadoEstaciones()
        {
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            Alumno miAlum;
            ObservableCollection<Alumno> devolver = new ObservableCollection<Alumno>();
            String cadenaConsulta = String.Format("Select {0},{1},{2},{3},{4},{5} from {6}", Contrato.Alumno.ID,
                                                   Contrato.Alumno.NOMBRE, Contrato.Alumno.APELLIDOS, Contrato.Alumno.ALIAS,
                                                   Contrato.Alumno.CORREO, Contrato.Alumno.CURSO, Contrato.Alumno.TABLA);
            try
            {
                conexionAlumno.openConnection();
                consulta.CommandText = cadenaConsulta;
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new Alumno();
                        miAlum.Id = (int)lector[Contrato.Alumno.ID];
                        miAlum.Nombre = (String)lector[Contrato.Alumno.NOMBRE];
                        miAlum.Apellidos = (String)lector[Contrato.Alumno.APELLIDOS];
                        miAlum.Alias = (String)lector[Contrato.Alumno.ALIAS];
                        miAlum.Correo = (String)lector[Contrato.Alumno.CORREO];
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

        public ObservableCollection<Alumno> listadoGrupos()
        {
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            Alumno miAlum;
            ObservableCollection<Alumno> devolver = new ObservableCollection<Alumno>();
            String cadenaConsulta = String.Format("Select {0},{1},{2},{3},{4},{5} from {6}", Contrato.Alumno.ID,
                                                   Contrato.Alumno.NOMBRE, Contrato.Alumno.APELLIDOS, Contrato.Alumno.ALIAS,
                                                   Contrato.Alumno.CORREO, Contrato.Alumno.CURSO, Contrato.Alumno.TABLA);
            try
            {
                conexionAlumno.openConnection();
                consulta.CommandText = cadenaConsulta;
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new Alumno();
                        miAlum.Id = (int)lector[Contrato.Alumno.ID];
                        miAlum.Nombre = (String)lector[Contrato.Alumno.NOMBRE];
                        miAlum.Apellidos = (String)lector[Contrato.Alumno.APELLIDOS];
                        miAlum.Alias = (String)lector[Contrato.Alumno.ALIAS];
                        miAlum.Correo = (String)lector[Contrato.Alumno.CORREO];
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

        public ObservableCollection<Alumno> listadoMagnitudes()
        {
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            Alumno miAlum;
            ObservableCollection<Alumno> devolver = new ObservableCollection<Alumno>();
            String cadenaConsulta = String.Format("Select {0},{1},{2},{3},{4},{5} from {6}", Contrato.Alumno.ID,
                                                   Contrato.Alumno.NOMBRE, Contrato.Alumno.APELLIDOS, Contrato.Alumno.ALIAS,
                                                   Contrato.Alumno.CORREO, Contrato.Alumno.CURSO, Contrato.Alumno.TABLA);
            try
            {
                conexionAlumno.openConnection();
                consulta.CommandText = cadenaConsulta;
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new Alumno();
                        miAlum.Id = (int)lector[Contrato.Alumno.ID];
                        miAlum.Nombre = (String)lector[Contrato.Alumno.NOMBRE];
                        miAlum.Apellidos = (String)lector[Contrato.Alumno.APELLIDOS];
                        miAlum.Alias = (String)lector[Contrato.Alumno.ALIAS];
                        miAlum.Correo = (String)lector[Contrato.Alumno.CORREO];
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

        public ObservableCollection<Alumno> listadoMedidas()
        {
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            Alumno miAlum;
            ObservableCollection<Alumno> devolver = new ObservableCollection<Alumno>();
            String cadenaConsulta = String.Format("Select {0},{1},{2},{3},{4},{5} from {6}", Contrato.Alumno.ID,
                                                   Contrato.Alumno.NOMBRE, Contrato.Alumno.APELLIDOS, Contrato.Alumno.ALIAS,
                                                   Contrato.Alumno.CORREO, Contrato.Alumno.CURSO, Contrato.Alumno.TABLA);
            try
            {
                conexionAlumno.openConnection();
                consulta.CommandText = cadenaConsulta;
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new Alumno();
                        miAlum.Id = (int)lector[Contrato.Alumno.ID];
                        miAlum.Nombre = (String)lector[Contrato.Alumno.NOMBRE];
                        miAlum.Apellidos = (String)lector[Contrato.Alumno.APELLIDOS];
                        miAlum.Alias = (String)lector[Contrato.Alumno.ALIAS];
                        miAlum.Correo = (String)lector[Contrato.Alumno.CORREO];
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

        public ObservableCollection<Alumno> listadoProfesores()
        {
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            Alumno miAlum;
            ObservableCollection<Alumno> devolver = new ObservableCollection<Alumno>();
            String cadenaConsulta = String.Format("Select {0},{1},{2},{3},{4},{5} from {6}", Contrato.Alumno.ID,
                                                   Contrato.Alumno.NOMBRE, Contrato.Alumno.APELLIDOS, Contrato.Alumno.ALIAS,
                                                   Contrato.Alumno.CORREO, Contrato.Alumno.CURSO, Contrato.Alumno.TABLA);
            try
            {
                conexionAlumno.openConnection();
                consulta.CommandText = cadenaConsulta;
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new Alumno();
                        miAlum.Id = (int)lector[Contrato.Alumno.ID];
                        miAlum.Nombre = (String)lector[Contrato.Alumno.NOMBRE];
                        miAlum.Apellidos = (String)lector[Contrato.Alumno.APELLIDOS];
                        miAlum.Alias = (String)lector[Contrato.Alumno.ALIAS];
                        miAlum.Correo = (String)lector[Contrato.Alumno.CORREO];
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

        public ObservableCollection<Alumno> listadoProfesoresCentros()
        {
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            Alumno miAlum;
            ObservableCollection<Alumno> devolver = new ObservableCollection<Alumno>();
            String cadenaConsulta = String.Format("Select {0},{1},{2},{3},{4},{5} from {6}", Contrato.Alumno.ID,
                                                   Contrato.Alumno.NOMBRE, Contrato.Alumno.APELLIDOS, Contrato.Alumno.ALIAS,
                                                   Contrato.Alumno.CORREO, Contrato.Alumno.CURSO, Contrato.Alumno.TABLA);
            try
            {
                conexionAlumno.openConnection();
                consulta.CommandText = cadenaConsulta;
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new Alumno();
                        miAlum.Id = (int)lector[Contrato.Alumno.ID];
                        miAlum.Nombre = (String)lector[Contrato.Alumno.NOMBRE];
                        miAlum.Apellidos = (String)lector[Contrato.Alumno.APELLIDOS];
                        miAlum.Alias = (String)lector[Contrato.Alumno.ALIAS];
                        miAlum.Correo = (String)lector[Contrato.Alumno.CORREO];
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

        public ObservableCollection<Alumno> listadoProfesoresGrupos()
        {
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            Alumno miAlum;
            ObservableCollection<Alumno> devolver = new ObservableCollection<Alumno>();
            String cadenaConsulta = String.Format("Select {0},{1},{2},{3},{4},{5} from {6}", Contrato.Alumno.ID,
                                                   Contrato.Alumno.NOMBRE, Contrato.Alumno.APELLIDOS, Contrato.Alumno.ALIAS,
                                                   Contrato.Alumno.CORREO, Contrato.Alumno.CURSO, Contrato.Alumno.TABLA);
            try
            {
                conexionAlumno.openConnection();
                consulta.CommandText = cadenaConsulta;
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new Alumno();
                        miAlum.Id = (int)lector[Contrato.Alumno.ID];
                        miAlum.Nombre = (String)lector[Contrato.Alumno.NOMBRE];
                        miAlum.Apellidos = (String)lector[Contrato.Alumno.APELLIDOS];
                        miAlum.Alias = (String)lector[Contrato.Alumno.ALIAS];
                        miAlum.Correo = (String)lector[Contrato.Alumno.CORREO];
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

        public ObservableCollection<Alumno> listadoProfesoresViajes()
        {
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            Alumno miAlum;
            ObservableCollection<Alumno> devolver = new ObservableCollection<Alumno>();
            String cadenaConsulta = String.Format("Select {0},{1},{2},{3},{4},{5} from {6}", Contrato.Alumno.ID,
                                                   Contrato.Alumno.NOMBRE, Contrato.Alumno.APELLIDOS, Contrato.Alumno.ALIAS,
                                                   Contrato.Alumno.CORREO, Contrato.Alumno.CURSO, Contrato.Alumno.TABLA);
            try
            {
                conexionAlumno.openConnection();
                consulta.CommandText = cadenaConsulta;
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new Alumno();
                        miAlum.Id = (int)lector[Contrato.Alumno.ID];
                        miAlum.Nombre = (String)lector[Contrato.Alumno.NOMBRE];
                        miAlum.Apellidos = (String)lector[Contrato.Alumno.APELLIDOS];
                        miAlum.Alias = (String)lector[Contrato.Alumno.ALIAS];
                        miAlum.Correo = (String)lector[Contrato.Alumno.CORREO];
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

        public ObservableCollection<Alumno> listadoViajes()
        {
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            Alumno miAlum;
            ObservableCollection<Alumno> devolver = new ObservableCollection<Alumno>();
            String cadenaConsulta = String.Format("Select {0},{1},{2},{3},{4},{5} from {6}", Contrato.Alumno.ID,
                                                   Contrato.Alumno.NOMBRE, Contrato.Alumno.APELLIDOS, Contrato.Alumno.ALIAS,
                                                   Contrato.Alumno.CORREO, Contrato.Alumno.CURSO, Contrato.Alumno.TABLA);
            try
            {
                conexionAlumno.openConnection();
                consulta.CommandText = cadenaConsulta;
                consulta.Connection = conexionAlumno.connection;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        miAlum = new Alumno();
                        miAlum.Id = (int)lector[Contrato.Alumno.ID];
                        miAlum.Nombre = (String)lector[Contrato.Alumno.NOMBRE];
                        miAlum.Apellidos = (String)lector[Contrato.Alumno.APELLIDOS];
                        miAlum.Alias = (String)lector[Contrato.Alumno.ALIAS];
                        miAlum.Correo = (String)lector[Contrato.Alumno.CORREO];
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
