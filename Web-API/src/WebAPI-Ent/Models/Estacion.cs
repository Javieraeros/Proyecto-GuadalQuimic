/* *************
 * Restricciones
 * *************
 * Nombre con al menos un caracter
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Ent.Models
{
    public class Estacion
    {
        #region Atributos
        private int id;
        private String nombre;
        private String longitud;
        private String latitud;

        #endregion

        #region Constructores

        public Estacion() { }

        public Estacion(int id, string nombre, string longitud, string latitud)
        {
            this.id = id;
            this.nombre = nombre;
            this.longitud = longitud;
            this.latitud = latitud;
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

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Longitud
        {
            get
            {
                return longitud;
            }

            set
            {
                longitud = value;
            }
        }

        public string Latitud
        {
            get
            {
                return latitud;
            }

            set
            {
                latitud = value;
            }
        }

        #endregion
    }
}
