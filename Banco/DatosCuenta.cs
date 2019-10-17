using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class DatosCuenta
    {//Se crea la clase datos cuenta para crear los objetos 

        public List<Pensiones> ListaP() //Se crea una lista del tipo pensiones para crear objetos e introducirlos en la lista
        {
            List<Pensiones> lista = new List<Pensiones>();
            lista.Add(new Pensiones { Id = 1, Titular = "Joshua", Interes = 10, Cotizacion = 500, NoCuentaOrigen = 234, Numero = 111, Saldo = 1000, Vencimiento = Convert.ToDateTime("31/octubre/2020") }) ;
            lista.Add(new Pensiones { Id = 2, Titular = "Juan", Interes = 20, Cotizacion = 400, NoCuentaOrigen = 543, Numero = 122, Saldo = 2000, Vencimiento = Convert.ToDateTime("25/mayo/2020") });
            lista.Add(new Pensiones { Id = 2, Titular = "Maria", Interes = 30, Cotizacion = 300, NoCuentaOrigen = 345, Numero = 133, Saldo = 3000, Vencimiento = Convert.ToDateTime("12/junio/2020") });
            lista.Add(new Pensiones { Id = 2, Titular = "Paco", Interes = 40, Cotizacion = 200, NoCuentaOrigen = 678, Numero = 144, Saldo = 4000, Vencimiento = Convert.ToDateTime("31/diciembre/2020") });
            lista.Add(new Pensiones { Id = 2, Titular = "Pedro", Interes = 50, Cotizacion = 100, NoCuentaOrigen = 999, Numero = 155, Saldo = 5000, Vencimiento = Convert.ToDateTime("10/noviembre/2020") });
            return lista;

        }
        public List<CuentaCorriente> ListaCC() //Se crea una lista del tipo CuentaCorriente para crear objetos e introducirlos en la lista
        {
            List<CuentaCorriente> lista = new List<CuentaCorriente>();
            lista.Add(new CuentaCorriente { Id = 1, Titular = "Joshua", Interes = 10, Numero = 111, Saldo = 1000});
            lista.Add(new CuentaCorriente { Id = 2, Titular = "Juan", Interes = 20,  Numero = 122, Saldo = 2000});
            lista.Add(new CuentaCorriente { Id = 2, Titular = "Maria", Interes = 30,  Numero = 133, Saldo = 3000});
            lista.Add(new CuentaCorriente { Id = 2, Titular = "Paco", Interes = 40, Numero = 144, Saldo = 4000});
            lista.Add(new CuentaCorriente { Id = 2, Titular = "Pedro", Interes = 50, Numero = 155, Saldo = 5000});
            return lista;

        }
        public List<CuentaAhorro> ListaCA() //Se crea una lista del tipo CuentaAhorro para crear objetos e introducirlos en la lista
        {
            List<CuentaAhorro> lista = new List<CuentaAhorro>(); 
            lista.Add(new CuentaAhorro { Id = 1, Titular = "Joshua", Interes = 10, Numero = 111, Saldo = 1000, Vencimiento = Convert.ToDateTime("31/octubre/2020") });
            lista.Add(new CuentaAhorro { Id = 2, Titular = "Juan", Interes = 20, Numero = 122, Saldo = 2000 , Vencimiento = Convert.ToDateTime("25/mayo/2020") });
            lista.Add(new CuentaAhorro { Id = 2, Titular = "Maria", Interes = 30, Numero = 133, Saldo = 3000, Vencimiento = Convert.ToDateTime("12/junio/2020") });
            lista.Add(new CuentaAhorro { Id = 2, Titular = "Paco", Interes = 40, Numero = 144, Saldo = 4000, Vencimiento = Convert.ToDateTime("31/diciembre/2020") });
            lista.Add(new CuentaAhorro { Id = 2, Titular = "Pedro", Interes = 50, Numero = 155, Saldo = 5000, Vencimiento = Convert.ToDateTime("10/noviembre/2020") });
            return lista;


        }


    }
}
