using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class RepoBanco
    {
        //se crea la variable de tipo datos cuenta en forma global, para poder utilizar sus metodos
        DatosCuenta DC;
        
        public RepoBanco()
        {
           //Se instancia la clase en el constructor para poder utilizarlo desde el inicio
            DC = new DatosCuenta();
        }
        internal void Principal()
            //Metodo para la bienvenida donde tambien se manda a llamar al menu
        {
            Console.WriteLine("Bienvenidos a el banco");
            Menu();
            Console.ReadLine();
        }
        private void Menu()
        {//Creacion del menu con un switch
            Console.WriteLine("Bienvenido al menu \n Ingrese uno de los sigueinte numeros segun su prefrencia");
            Console.WriteLine("1- Para opciones de cuenta ahorro");
            Console.WriteLine("2- Para Opciones de pensiones");
            Console.WriteLine("3- Para opciones de cuenta corriente");
            Console.WriteLine("4- Para salir");

            var elec = Console.ReadLine();

            switch (elec)
            {
                case "1":
                    Console.WriteLine("Bienvenido a Cuenta Ahorro");
                    ObtenerDatoAhorro();
                    break;
                case "2":
                    Console.WriteLine("Bienvenido a pensiones");
                    ObtenerDatosPension();
                    break;
                case "3":
                    Console.WriteLine("Bienvenido a Cuenta Corriente");
                    ObtenerDatosCorrientes();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Seleccion no valida, regresando al menu");
                    Menu();
                    break;
            }


        }
        private void ObtenerDatosCorrientes()
        {//Se manda a llamar al metodo obtener datos para optimizar el codigo
            int numero = ObtenerDatos();
            //Se crea una variable de tipo var para pasarle la lista creada en cuenta corriente
            var lista = DC.ListaCC();
            //Se instancia la clase cuenta correinte
            CuentaCorriente cc = new CuentaCorriente();
            //Se crea un for each para pasar la lista a la variable recien creada cuenta, y se compara con el numero introducido para ver si conside con algun numerod e cuenta, de ser asi se accede al menu de usuario y se hace los mismo en los metodos consecuentes :)
            foreach(var cuenta in lista)
            {
                if(numero == cuenta.Numero)
                {
                    cc = cuenta;
                }
            }
        }
        private void ObtenerDatosPension()
        {
            int numero = ObtenerDatos();
            var lista = DC.ListaP();
            Pensiones p = new Pensiones();
            foreach (var cuenta in lista) 
            {
                if (numero == cuenta.Numero)
                {
                    p = cuenta;
                }
            }
        }
        private void ObtenerDatoAhorro()
        {
            int numero = ObtenerDatos();
            var lista = DC.ListaCA();
            CuentaAhorro ca = new CuentaAhorro();
            foreach (var cuenta in lista)
            {
                if (numero == cuenta.Numero)
                {
                    ca = cuenta;
                }
            }
        }
        private int ObtenerDatos()
        {
            Console.WriteLine("Ingresu su numero de cuenta");
            string res = Console.ReadLine();
            return Convert.ToInt32(res);
        }
        public void MenuUsuario(Cuenta p) //Se crea el menu de usuario donde se utilizan los metodos de la clase padre
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a tu cuenta :" + p.Titular);
            Console.WriteLine("1- Consultar saldo \n2. - Transferir \n3. - Interes x Mes 4. - Ingreso");
            Console.WriteLine("Elije una opcion");

            switch (Console.ReadLine())
            {
                case "1":
                    p.ConsultarSaldo(p);
                    break;
                case "2":
                    p.Transferir();
                    break;
                case "3":
                    Console.WriteLine("El interes generado es de : " + p.Interespormes(p));

                    break;

            }
        }



    }
}
