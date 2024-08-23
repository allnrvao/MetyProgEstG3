namespace aumentar_salario_ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programa para aumentar el salario de los empleados");
            string nombre;
            string cargo;
            double salario;
            double aumento;
            Console.WriteLine("Digite el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite el cargo del empleado: ");
            cargo = Console.ReadLine();
            Console.WriteLine("Digite el salario del empleado: ");
            salario = Double.Parse(Console.ReadLine());
            aumento = salario * 0.1;
            Console.WriteLine("El nuevo salario del empleado es: " + aumento);

            

        }
    }
}
