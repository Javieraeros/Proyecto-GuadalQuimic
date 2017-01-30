/* *************
 * Restricciones
 * *************
 * Solo el campo de curso podrá estar vacío.Y el correo será  **@**.**
 * La contraseña deberá contener mínimo 5 caracteres y al menos uno de ellos en mayúsculas
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Ent
{
    public class Alumno
    {
        #region Atributos

        private int id;
        private String nombre;
        private String apellidos;
        private String alias;
        private String correo;
        private String contraseña;
        private String curso;

        #endregion

        #region Constructores
        public Alumno()
        {
        }

        public Alumno(int id, string nombre, string apellidos, string alias, string correo, string contraseña, string curso)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.alias = alias;
            this.correo = correo;
            this.contraseña = contraseña;
            this.curso = curso;
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

        public string Alias
        {
            get
            {
                return alias;
            }

            set
            {
                alias = value;
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

        public string Curso
        {
            get
            {
                return curso;
            }

            set
            {
                curso = value;
            }
        }
        #endregion
    }
}
