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
    public class AlumnoGrupo
    {
        #region Atributos
        private int id_Alumno;
        private int id_Grupo;
        #endregion

        #region Constructores

        public AlumnoGrupo() { }

        public AlumnoGrupo(int id_Alumno, int id_Grupo)
        {
            this.id_Alumno = id_Alumno;
            this.id_Grupo = id_Grupo;
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

        public int Id_Grupo1
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
