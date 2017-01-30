/* *************
 * Restricciones
 * *************
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Ent.Models
{
    public class ProfesorViaje
    {
        #region Atributos
        private int id_Profesor;
        private int id_Viaje;

        #endregion

        #region Constructores

        public ProfesorViaje() { }

        public ProfesorViaje(int id_Profesor, int id_Viaje)
        {
            this.id_Profesor = id_Profesor;
            this.id_Viaje = id_Viaje;
        }

        #endregion

        #region Propiedades

        public int Id_Profesor
        {
            get
            {
                return id_Profesor;
            }

            set
            {
                id_Profesor = value;
            }
        }

        public int Id_Viaje
        {
            get
            {
                return id_Viaje;
            }

            set
            {
                id_Viaje = value;
            }
        }
        #endregion

    }
}
