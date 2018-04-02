using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Chofer
    {
        private int cedula;
        private string nombre;
        private Auto autoAsignado;

        #region props
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public Auto AutoAsignado
        {
            get { return autoAsignado; }
            set { autoAsignado = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion

        public static bool ValidarCedula(int cedula)
        {
            return (cedula + "").Length >= 8;
        }
        public Chofer (int cedula, string nombre)
        {
            this.cedula = cedula;
            this.nombre = nombre;
        }
    }
}
