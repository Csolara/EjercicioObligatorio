using Ejercicio5mixC.Servicios;

namespace Ejercicio5mixC
{
    /// <summary>
    /// Clase principal de la aplicación.
    /// 071123 - csl
    /// </summary>
    class program
    {
        /// <summary>
        /// Método main de la aplicación.     
        /// 171023 - csl
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {
            string caracter;    
            do
            {
                MenuInterfaz mi = new MenuImplementacion();
                int m = mi.pedirMes();
                int a = mi.pedirAnyo();
                CalculoInterfaz ci = new CalculoImplementacion();

                Console.WriteLine("El mes " + m + " del año " + a + " tiene " + ci.PedirDia(m, a));

                if (CalculoImplementacion.Bisiesto(a))
                {
                    Console.WriteLine("Es bisiesto");
                }
                else
                {
                    Console.WriteLine("No es bisiesto");
                }
                Console.Write("Presiona 's' para continuar o 'n' para salir: ");
                caracter = Console.ReadLine();
                                
            } while (caracter == "s");        
        }
    }
}