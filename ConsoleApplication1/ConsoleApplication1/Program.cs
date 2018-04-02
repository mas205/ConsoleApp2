using System;
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Remiseria n = new Remiseria();
            Chofer r = new Chofer(15123412, "Roberto");
            Auto h = new Auto(1997, "Opel", "XR7-22", "AHH998");
            n.AgregarAuto(h);
            n.AgregarChofer(r);
            n.AsignarChoferAuto(r, h);
            Console.ReadLine();
        }
    }
}
