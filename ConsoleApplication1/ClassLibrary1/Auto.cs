using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Auto
    {
        private int anio;
        private string marca;
        private string modelo;
        private string matricula;
        private List<Chofer> choferes;

        #region Props
        public List<Chofer> Choferes
        {
            get { return choferes; }
            set { value = choferes; }
        }
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        #endregion

        public Auto(int anio, string marca, string modelo, string matricula)
        {
            this.anio = anio;
            this.marca = marca;
            this.modelo = modelo;
            this.matricula = matricula;
            choferes = new List<Chofer>();
        }

    }
}
