/* *************
 * Restricciones
 * *************
 * Tanto fecha inicio como fecha fin deberán existir y ser coherentes
 * Tipo,denominación y notas podrán ser cadenas vacías
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Ent.Models
{
    public class Viaje
    {
        #region Atributos
        private int id;
        private DateTime fecha_Inicio;
        private DateTime fecha_Fin;
        private String tipo;
        private String denominacion;
        private String notas;

        #endregion

        #region Constructores

        public Viaje() { }
        public Viaje(int id, DateTime fecha_Inicio, DateTime fecha_Fin, string tipo, string denominacion, string notas)
        {
            this.id = id;
            this.fecha_Inicio = fecha_Inicio;
            this.fecha_Fin = fecha_Fin;
            this.tipo = tipo;
            this.denominacion = denominacion;
            this.notas = notas;
        }

        #endregion

        #region Propiedades

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DateTime Fecha_Inicio
        {
            get
            {
                return fecha_Inicio;
            }

            set
            {
                fecha_Inicio = value;
            }
        }

        public DateTime Fecha_Fin
        {
            get
            {
                return fecha_Fin;
            }

            set
            {
                fecha_Fin = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Denominacion
        {
            get
            {
                return denominacion;
            }

            set
            {
                denominacion = value;
            }
        }

        public string Notas
        {
            get
            {
                return notas;
            }

            set
            {
                notas = value;
            }
        }

        #endregion

    }
}
