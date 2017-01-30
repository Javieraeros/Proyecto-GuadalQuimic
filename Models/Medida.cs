/* *************
 * Restricciones
 * *************
 * fecha_Modificabilidad mayor que fecha.
 * Valor debe existir.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Ent.Models
{
    public class Medida
    {
        #region Atributos
        private int id_Alumno;
        private int id_Grupo;
        private int id_Estacion;
        private int id_Magnitud;
        private DateTime fecha;
        private DateTime fecha_Modificabilidad;
        private double valor;
        private bool confirmada;

        #endregion

        #region Constructores

        public Medida() { }
        public Medida(int id_Alumno, int id_Grupo, int id_Estacion, int id_Magnitud, DateTime fecha, DateTime fecha_Modificabilidad, double valor, bool confirmada)
        {
            this.id_Alumno = id_Alumno;
            this.id_Grupo = id_Grupo;
            this.id_Estacion = id_Estacion;
            this.id_Magnitud = id_Magnitud;
            this.fecha = fecha;
            this.fecha_Modificabilidad = fecha_Modificabilidad;
            this.valor = valor;
            this.confirmada = confirmada;
        }
        #endregion

        #region Propiedades

        public int Id_Alumno
        {
            get
            {
                return id_Alumno;
            }

            set
            {
                id_Alumno = value;
            }
        }

        public int Id_Grupo
        {
            get
            {
                return id_Grupo;
            }

            set
            {
                id_Grupo = value;
            }
        }

        public int Id_Estacion
        {
            get
            {
                return id_Estacion;
            }

            set
            {
                id_Estacion = value;
            }
        }

        public int Id_Magnitud
        {
            get
            {
                return id_Magnitud;
            }

            set
            {
                id_Magnitud = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public DateTime Fecha_Modificabilidad
        {
            get
            {
                return fecha_Modificabilidad;
            }

            set
            {
                fecha_Modificabilidad = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public bool Confirmada
        {
            get
            {
                return confirmada;
            }

            set
            {
                confirmada = value;
            }
        }

        #endregion
    }
}
