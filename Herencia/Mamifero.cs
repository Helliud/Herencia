using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Mamifero : Animal
    {
        public string parir()
        {
            return Nombre + " estaba pariendo";

        }

        override public string desplazar()
        {
            return Nombre + " esta cagando";

        }
    }
}
