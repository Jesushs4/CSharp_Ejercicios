namespace Ejercicio2
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuál es tu edad?");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("No puedes conducir.");
            }
            else
            {
                Console.WriteLine("¿Tienes carnet? (S/N)");
                string tieneCarnet = Console.ReadLine();

                if (tieneCarnet.Equals("S"))
                {
                    Console.WriteLine("Puedes conducir.");
                }
                else
                {
                    Console.WriteLine("No puedes conducir sin carnet.");
                }
            }
        }
    }
}