using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir;

            do
            {
                string unidad = null;

                do
                {
                    Console.WriteLine("¿Unidad de partida (minutos/segundos/horas)? ");
                    unidad = Console.ReadLine();
                    if (unidad != "segundos" && unidad != "minutos" && unidad != "horas") Console.WriteLine("¡Error: Unidad incorrecta!\n");
                } while (unidad != "segundos" && unidad != "minutos" && unidad != "horas");

                Console.WriteLine("¿Cantidad? ");
                double cantidad = double.Parse(Console.ReadLine());
                if (unidad == "segundos") Console.WriteLine("{0} segundos son {1} minutos.\n", cantidad, HadaP1.Seconds2Minutes(cantidad));
                else if (unidad == "minutos") Console.WriteLine("{0} minutos son {1} segundos.\n", cantidad, HadaP1.Minutes2Seconds(cantidad));
                else Console.WriteLine("{0} horas son {1} minutos.\n", cantidad, HadaP1.Hours2Minutes(cantidad));

                do
                {
                    Console.WriteLine("¿Realizar más conversiones (s/n)? ");
                    seguir = char.Parse(Console.ReadLine());
                    if (seguir != 's' && seguir != 'n') Console.WriteLine("¡Error: Opción incorrecta!\n");
                } while (seguir != 's' && seguir != 'n');

            } while (seguir == 's');
        }
    }
}
