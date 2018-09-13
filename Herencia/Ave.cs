using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Ave : Animal
    {
        public string huevo()
        {
            return Nombre + " tiene un huevo";

        }

        override public string desplazar()
        {
            return Nombre + " esta volando";

        }
    }
}
