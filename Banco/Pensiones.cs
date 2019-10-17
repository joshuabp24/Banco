using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{//Se crea la clase pensiones y hereda atributos y metodos  de la clase cuenta
    public class Pensiones:Cuenta
    {
        public DateTime Vencimiento { get; set; }
        public double Cotizacion { get; set; }
        public int NoCuentaOrigen { get; set; }

        
    }
}
