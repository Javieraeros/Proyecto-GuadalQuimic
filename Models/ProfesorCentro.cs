/* *************
 * Restricciones
 * *************
 * La fecha de alta deberá existir y ser anterior a la feha de baja (la cual no es obligatoria)
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Ent.Models
{
    public class ProfesorCentro
    {
        #region Atributos
        private int id_Profesor;
        private int id_Centro;
        private DateTime fecha_Alta;
        private DateTime fecha_Baja;

        #endregion
        #region Constructores
        public ProfesorCentro() { }

        public ProfesorCentro(int id_Profesor, int id_Centro, DateTime fecha_Alta, DateTime fecha_Baja)
        {
            this.id_Profesor = id_Profesor;
            this.id_Centro = id_Centro;
            this.fecha_Alta = fecha_Alta;
            this.fecha_Baja = fecha_Baja;
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

        public int Id_Centro
        {
            get
            {
                return id_Centro;
            }

            set
            {
                id_Centro = value;
            }
        }

        public DateTime Fecha_Alta
        {
            get
            {
                return fecha_Alta;
            }

            set
            {
                fecha_Alta = value;
            }
        }

        public DateTime Fecha_Baja
        {
            get
            {
                return fecha_Baja;
            }

            set
            {
                fecha_Baja = value;
            }
        }
        #endregion
    }
}
