using compras.clases;

namespace compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ejemplo 1");
            // crear el primer objeto
            Factura fact = new Factura();
            string producto=null;
            double precio=0, monto=0;
            int cantidad=0;

            Console.Write("producto: ");

            producto= Console.ReadLine();
            Console.Write("precio: ");
            precio = double.Parse(Console.ReadLine());
            Console.Write("cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            fact.producto = producto;
            fact.precio = precio;
            fact.cantidad = cantidad;

            monto = fact.CalcularMonto();

            Console.WriteLine($"{producto}");
            Console.WriteLine($"{precio}");
            Console.WriteLine($"{cantidad}");
            Console.WriteLine($"{monto}");
        }
    }
}
