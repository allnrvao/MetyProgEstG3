namespace area_de_un_circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radio;
            float area;
            Console.WriteLine("Ejemplo 5");
            Console.WriteLine("Programa para calcular el area de un circulo");
            Console.Write("Digite el radio del circulo: ");
            radio = int.Parse(Console.ReadLine());
            area = (float)Math.PI * (float)Math.Pow(radio, 2);
            Console.WriteLine(" El area del circulo es de : " + area);

        }
    }
}
