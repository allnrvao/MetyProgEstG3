namespace raiz_cuadrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            float raiz;
            Console.WriteLine("Ejemplo 4");
            Console.WriteLine("Programa para calcular la raiz cuadrada de un numero x");
            //se pide el numero
            Console.Write("Digite un numero: ");
            // se lee el numero
            num = int.Parse(Console.ReadLine());
            //se hace el calculo de la raiz al numero dado
            raiz = (float)Math.Sqrt(num);
            // se muestra el resultado
            Console.WriteLine($"La raiz del numero {num} es: " + raiz);
        }
    }
}
