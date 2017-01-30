/* *************
 * Restricciones
 * *************
 * Nombre tiene que contener al menos 3 caracteres
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Ent.Models
{
    public class Grupo
    {
        #region Atributos

        private int id;
        private int id_Viaje;
        private int id_Centro;
        private String nombre;


        #endregion

        #region Constructores
        public Grupo() { }

        public Grupo(int id, int id_Viaje, int id_Centro, string nombre)
        {
            this.id = id;
            this.id_Viaje = id_Viaje;
            this.id_Centro = id_Centro;
            this.nombre = nombre;
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
        #endregion
    }
}
