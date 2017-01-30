/* *************
 * Restricciones
 * *************
 * Nombre no vacío
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Ent.Models
{
    public class Magnitud
    {
        #region Atributos
        private int id;
        private String nombre;
        private String unidad;
        private double val_Max;
        private double val_Min;

        #endregion
        #region Constructores
        public Magnitud() { }

        public Magnitud(int id, string nombre, string unidad, double val_Max, double val_Min)
        {
            this.id = id;
            this.nombre = nombre;
            this.unidad = unidad;
            this.val_Max = val_Max;
            this.val_Min = val_Min;
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

        public string Unidad
        {
            get
            {
                return unidad;
            }

            set
            {
                unidad = value;
            }
        }

        public double Val_Max
        {
            get
            {
                return val_Max;
            }

            set
            {
                val_Max = value;
            }
        }

        public double Val_Min1
        {
            get
            {
                return val_Min;
            }

            set
            {
                val_Min = value;
            }
        }

        #endregion
    }
}
