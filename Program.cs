internal class Program
{
    private static void Main(string[] args)
    {
        int numerodia = 0;
        Console.WriteLine("EJERCICIO 2");
        Console.WriteLine("Ingrese un número de día ");

        numerodia = Convert.ToInt32(Console.ReadLine());

        if (numerodia == 1)
        {
            Console.WriteLine("Su día es lunes");
        }

        else if (numerodia == 2)
        {
            Console.WriteLine("Su día es martes");
        }

        else if (numerodia == 3)
        {
            Console.WriteLine("Su día es miercoles");
        }

        else if (numerodia == 4)
        {
            Console.WriteLine("Su día es jueves");
        }

        else if (numerodia == 5)
        {
            Console.WriteLine("Su día es viernes");
        }

        else if (numerodia == 6)
        {
            Console.WriteLine("Su día es sábado");
        }

        else if (numerodia == 7)
        {
            Console.WriteLine("Su día es domingo");
        }

        else if (numerodia <= 0)
        {
            Console.WriteLine("Error: su número debe estar entre 1 y 7");
        }

        else if (numerodia > 7)
        {
            Console.WriteLine("Error: su número debe estar entre 1 y 7");
        }
    }
}