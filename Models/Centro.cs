/* *************
 * Restricciones
 * *************
 * Todos lso campso deberán contener al menos un carácter. Y el correo será  **@**.**
 * La contraseña deberá contener mínimo 5 caracteres y al menos uno de ellos en mayúsculas
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Ent.Models
{
    public class Centro
    {
        #region Atributos
        private int id;
        private String nombre;
        private String localizacion;
        #endregion

        #region Constructores

        public Centro() { }


        public Centro(int id, string nombre, string localizacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.localizacion = localizacion;
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

        public string Localizacion
        {
            get
            {
                return localizacion;
            }

            set
            {
                localizacion = value;
            }
        }
        #endregion
    }
}
