namespace sumadedosnumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Suma de dos números cualquieras
            int num_a;
            int num_b;
            int sumatotal;
            Console.WriteLine("Programa para sumar dos números cualquiera");
            Console.WriteLine("Digite dos números");
            Console.Write("Número a) ");
            num_a = int.Parse(Console.ReadLine());
            Console.Write("Número b) ");
            num_b = int.Parse(Console.ReadLine()); 
            Console.WriteLine("RESULTADO");
            sumatotal = num_a + num_b;
            Console.WriteLine("La suma es: " + sumatotal);
        }
    }
}