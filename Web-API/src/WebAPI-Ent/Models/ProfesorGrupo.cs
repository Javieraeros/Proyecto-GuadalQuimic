/* *************
 * Restricciones
 * *************
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Ent.Models
{
    public class ProfesorGrupo
    {
        #region Atributos
        private int id_Profesor;
        private int id_Grupo;

        #endregion

        #region Constructores

        public ProfesorGrupo() { }

        public ProfesorGrupo(int id_Profesor, int id_Grupo)
        {
            this.id_Profesor = id_Profesor;
            this.id_Grupo = id_Grupo;
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
        #endregion
    }
}
