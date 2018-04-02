using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Remiseria
    {
        private List<Auto> autos;
        private List<Chofer> choferes;

        #region Props
        public List<Auto> Autos
        {
            get { return autos; }
            set { value = autos; }
        }
        public List<Chofer> Choferes
        {
            get { return choferes; }
            set { value = choferes; }
        }
        #endregion

        public Remiseria()
        {
            autos = new List<Auto>();
            choferes = new List<Chofer>();
        }
        public void AgregarAuto(Auto a)
        {
            autos.Add(a);
        }
        public void AgregarChofer(Chofer c)
        {
            choferes.Add(c);
        }
        public void AsignarChoferAuto(Chofer c, Auto a)
        {
            c.AutoAsignado = a;
            a.Choferes.Add(c);
        }
    }
}
