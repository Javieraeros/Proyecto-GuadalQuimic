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
            public const string TABLA= "Alumnos";
            public const string ID= "Id";
            public const string NOMBRE= "Nombre";
            public const string APELLIDOS= "Apellidos";
            public const string CONTRASEÑA= "Contraseña";
            public const string ALIAS= "Alias";
            public const string CORREO= "Correo";
            public const string CURSO= "Curso";
        }
        public static class AlumnoGrupo
        {
            public const string TABLA= "Alumnos_Grupos";
            public const string ID_ALUMNO= "Id_Alumno";
            public const string ID_GRUPO= "Id_Grupo";
        }
        public static class Centro
        {
            public const string TABLA= "Centros";
            public const string ID= "Id";
            public const string NOMBRE= "Nombre";
            public const string LOCALIZACION= "Localizacion";

        }
        public static class Estacion
        {
            public const string TABLA= "Estaciones";
            public const string ID= "Id";
            public const string NOMBRE= "Nombre";
            public const string LONGITUD= "Longitud";
            public const string LATITUD= "Latitud";

        }
        public static class Grupo
        {
            public const string TABLA= "Grupos";
            public const string ID= "Id";
            public const string ID_VIAJE= "Id_Viaje";
            public const string ID_CENTRO= "Id_Centro";
            public const string NOMBRE= "Nombre";

        }
        public static class Magnitud
        {
            public const string TABLA="Magnitudes";
            public const string ID="Id";
            public const string NOMBRE="Nombre";
            public const string UNIDAD="Unidad";
            public const string VALMAX="Val_Max";
            public const string VALMIN="Val_Min";
        }
        public static class Medida
        {
            public const string TABLA="Medidas";
            public const string ID_GRUPO="Id_Grupo";
            public const string ID_ALUMNO="Id_Alumno";
            public const string ID_ESTACION="Id_Estacion";
            public const string ID_MAGNITUD="Id_Magnitud";
            public const string FECHA="Fecha";
            public const string FECHA_MODIFICABILIDAD="Fecha_Modificabilidad";
            public const string VALOR="Valor";
            public const string CONFIRMADA="Confirmada";
        }
        public static class Profesor
        {
            public const string ID="Id";
            public const string NOMBRE="Nombre";
            public const string APELLIDOS="Apellidos";
            public const string CORREO="Correo";
            public const string CONTRASEÑA="Contraseña";
            public const string TABLA="Profesores";

        }

        public static class ProfesorCentro
        {
            public const string TABLA="Profesores_Centros";
            public const string ID_PROFESOR="Id_Profesor";
            public const string ID_CENTRO="Id_Centro";
            public const string FECHA_ALTA="Fecha_Alta";
            public const string FECHA_BAJA="Fecha_Baja";

        }

        public static class ProfesorGrupo
        {
            public const string TABLA="Profesores_Grupos";
            public const string ID_PROFESOR="Id_Profesor";
            public const string ID_GRUPO="Id_Grupo";

        }

        public static class ProfesorViaje
        {
            public const string TABLA="Profesores_Viajes";
            public const string ID_PROFESOR="Id_Profesor";
            public const string ID_VIAJE="Id_Viaje";

        }

        public static class Viaje
        {
            public const string TABLA="Viajes";
            public const string ID="Id";
            public const string INICIO="Fecha_Inicio";
            public const string FIN="Fecha_Fin";
            public const string TIPO="Tipo";
            public const string DENOMINACION="Denominacion";
            public const string NOTAS="Notas";

        }
    }
}
