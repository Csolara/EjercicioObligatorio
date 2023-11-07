using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5mixC.Servicios
{
    /// <summary>
    /// Interfaz que declara los métodos relacionados con el funcionamiento del menú
    /// 071123 - csl
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Solicita al método un mes.
        /// 071123 - csl
        /// </summary>
        /// <returns></returns>
        public int pedirMes();
        /// <summary>
        /// Solicita al método un año.
        /// 071123 - csl
        /// </summary>
        /// <returns></returns>
        public int pedirAnyo();

        
    }
}