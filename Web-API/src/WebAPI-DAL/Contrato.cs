using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_DAL
{
    public class Contrato
    {
        public static class Alumno
        {
            public static string TABLA= "Alumnos";
            public static string ID= "Id";
            public static string NOMBRE= "Nombre";
            public static string APELLIDOS= "Apellidos";
            public static string CONTRASEÑA= "Contraseña";
            public static string ALIAS= "Alias";
            public static string CORREO= "Correo";
            public static string CURSO= "Curso";
        }
        public static class AlumnoGrupo
        {
            public static string TABLA= "Alumnos_Grupos";
            public static string ID_ALUMNO= "Id_Alumno";
            public static string ID_GRUPO= "Id_Grupo";
        }
        public static class Centro
        {
            public static string TABLA= "Centros";
            public static string ID= "Id";
            public static string NOMBRE= "Nombre";
            public static string LOCALIZACION= "Localizacion";

        }
        public static class Estacion
        {
            public static string TABLA= "Estaciones";
            public static string ID= "Id";
            public static string NOMBRE= "Nombre";
            public static string LONGITUD= "Longitud";
            public static string LATITUD= "Latitud";

        }
        public static class Grupo
        {
            public static string TABLA= "Grupos";
            public static string ID= "Id";
            public static string ID_VIAJE= "Id_Viaje";
            public static string ID_CENTRO= "Id_Centro";
            public static string NOMBRE= "Nombre";

        }
        public static class Magnitud
        {
            public static string TABLA="Magnitudes";
            public static string ID="Id";
            public static string NOMBRE="Nombre";
            public static string UNIDAD="Unidad";
            public static string VALMAX="Val_Max";
            public static string VALMIN="Val_Min";
        }
        public static class Medida
        {
            public static string TABLA="Medidas";
            public static string ID_GRUPO="Id_Grupo";
            public static string ID_ALUMNO="Id_Alumno";
            public static string ID_ESTACION="Id_Estacion";
            public static string ID_MAGNITUD="Id_Magnitud";
            public static string FECHA="Fecha";
            public static string FECHA_MODIFICABILIDAD="Fecha_Modificabilidad";
            public static string VALOR="Valor";
            public static string CONFIRMADA="Confirmada";
        }
        public static class Profesor
        {
            public static string ID="Id";
            public static string NOMBRE="Nombre";
            public static string APELLIDOS="Apellidos";
            public static string CORREO="Correo";
            public static string CONTRASEÑA="Contraseña";
            public static string TABLA="Profesores";

        }

        public static class ProfesorCentro
        {
            public static string TABLA="Profesores_Centros";
            public static string ID_PROFESOR="Id_Profesor";
            public static string ID_CENTRO="Id_Centro";
            public static string FECHA_ALTA="Fecha_Alta";
            public static string FECHA_BAJA="Fecha_Baja";

        }

        public static class ProfesorGrupo
        {
            public static string TABLA="Profesores_Grupos";
            public static string ID_PROFESOR="Id_Profesor";
            public static string ID_GRUPO="Id_Grupo";

        }

        public static class ProfesorViaje
        {
            public static string TABLA="Profesores_Viajes";
            public static string ID_PROFESOR="Id_Profesor";
            public static string ID_VIAJE="Id_Viaje";

        }

        public static class Viaje
        {
            public static string TABLA="Viajes";
            public static string ID="Id";
            public static string INICIO="Fecha_Inicio";
            public static string FIN="Fecha_Fin";
            public static string TIPO="Tipo";
            public static string DENOMINACION="Denominacion";
            public static string NOTAS="Notas";

        }
    }
}
