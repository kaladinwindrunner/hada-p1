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
                    Console.WriteLine("¿Unidad de partida (minutos/segundos)? ");
                    unidad = Console.ReadLine();
                    if (unidad != "segundos" && unidad != "minutos") Console.WriteLine("¡Error: Unidad incorrecta!\n");
                } while (unidad != "segundos" && unidad != "minutos");

                Console.WriteLine("¿Cantidad? ");
                double cantidad = double.Parse(Console.ReadLine());
                if (unidad == "segundos") Console.WriteLine("{0} segundos son {1} minutos.\n", cantidad, HadaP1.Seconds2Minutes(cantidad));
                else Console.WriteLine("{0} minutos son {1} segundos.\n", cantidad, HadaP1.Minutes2Seconds(cantidad));

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
