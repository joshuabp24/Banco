using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    //Se crea la clase CuentaAhorro y hereda atributos y metodos de la clase padre cuenta
    public class CuentaAhorro:Cuenta
    {
        public DateTime Vencimiento { get; set; }
        //Metodo ingreso por mes
        public double IngresoPorMes()
        {
            return 0;
        }
    }
}
