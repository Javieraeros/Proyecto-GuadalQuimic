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
    public class Profesor
    {
        #region Atributos

        private int id;
        private String nombre;
        private String apellidos;
        private String correo;
        private String contraseña;

        #endregion

        #region Constructores
        public Profesor()
        {
        }

        public Profesor(int id, string nombre, string apellidos, string correo, string contraseña)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.correo = correo;
            this.contraseña = contraseña;
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

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }
        

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }
        #endregion
    }
}
