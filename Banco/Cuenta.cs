using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cuenta
    {//Creacion de los atributos de la clase Padre llamada cuenta
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double Interes { get; set; }
        //Metodo para ingresar valores
        public bool Ingreso()
        {
            return false;
        }
        //Metodo para ver el interes por mes
        public double Interespormes(Cuenta P)
        {
            //Se hace la multiplicacion del interes
            var iTotal = Interes * .16;
            //se regresa el valor del interes
            return iTotal;
        }
        public void ConsultarSaldo(Cuenta cuenta)
        {
            //Metodo para consultar saldo 
            Console.WriteLine("Su saldo actual es de  $" + cuenta.Saldo);
        }
        //Metodo para transferir
        public void Transferir()
        {

        }

    }
}
