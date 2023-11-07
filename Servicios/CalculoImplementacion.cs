using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5mixC.Servicios
{
    internal class CalculoImplementacion : CalculoInterfaz
    {
        public static bool Bisiesto(int año)
        {
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }
        public int PedirDia(int mes, int año)
        {
            int diaMes;

            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                diaMes = 30;
            }
            else if (mes == 2)
            {
                if (Bisiesto(año))
                {
                    diaMes = 29;
                }
                else
                {
                    diaMes = 28;
                }
            }
            else
            {
                diaMes = 31;
            }
            return diaMes;
        }              
    }
}