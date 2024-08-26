namespace cubo__de_un_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            float cubo;
            Console.WriteLine("Ejemplo 3");
            Console.WriteLine("Programa que calcula el cubo de un numero x");
            Console.WriteLine("Digite un numero: ");
            num = int.Parse(Console.ReadLine());
            cubo = (float)Math.Pow(num, 3);
            Console.WriteLine("El cubo del numero es: " + cubo);

        }
    }
}
