using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos la clase Repo banco para mandar a llamar a nuestro metodo que de la bienvenida
            RepoBanco r = new RepoBanco();
            r.Principal();
            
            
        }
    }
}
