using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5mixC.Servicios
{
    /// <summary>
    /// Interfaz que declara la operativa de los métodos.
    /// 071123 - csl
    /// </summary>
    internal interface CalculoInterfaz
    {
        /// <summary>
        /// Solicita al usuario un mes y un año y devuelve el número de dias del mes solicitado dependiendo de si el año es bisiesto o no.
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="año"></param>
        /// <returns></returns>
        public int PedirDia(int mes, int año);
    }
}