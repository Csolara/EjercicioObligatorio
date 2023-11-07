using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5mixC.Servicios
{
    /// <summary>
    /// Implementacion de la Interfaz.
    /// 071123 - csl
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int pedirAnyo()
        {
            Console.WriteLine("Escribe un Año: ");
            int anyo = int.Parse(Console.ReadLine());
            return anyo;
            //Devuelve la variable (anyo).
        }
        public int pedirMes()
        {
            Console.WriteLine("Escribe un Mes: ");
            int mes = int.Parse(Console.ReadLine());
            return mes;
            //Devuelve la variable (mes).
        }
    }
}