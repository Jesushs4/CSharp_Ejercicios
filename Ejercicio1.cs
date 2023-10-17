namespace HolaMundo
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;

            Console.WriteLine("Introduzca un radio");
            int radius = int.Parse(Console.ReadLine());

            double area = Math.Pow(radius, 2)*PI;
            Console.WriteLine("El area es de "+area);

        }
    }
}