using CalcularNota.clase;

namespace CalcularNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nota calcularnota = new Nota();
            //se inicializa
            int cal1=0, cal2=0, cal3=0, carne=0;
            string NombreEstudiante = null;
            string apellidoestudiante = null;
            float promedio=0.00;
            //inicio del programa
            Console.WriteLine("ejemplo 2");
            Console.WriteLine("Programa que calcula el promedio de un estudiante");

            //se piden los datos
            Console.Write("Digite el nombre del estudiante: ");
            NombreEstudiante = Console.ReadLine();

            Console.Write("Digite el apellido del estudiante: ");
            apellidoestudiante = Console.ReadLine();

            Console.Write("Digite el numero de carnet del estudiante: ");
            carne = int.Parse(Console.ReadLine());

            Console.Write("Digite la primera calificacion: ");
            cal1 = int.Parse(Console.ReadLine());

            Console.Write("Digite la segunda calificacion: ");
            cal2 = int.Parse(Console.ReadLine());

            Console.Write("Digite la tercera calificacion: ");
            cal3 = int.Parse(Console.ReadLine());

            //se asignan los datos
            calcularnota.calificacion1 = cal1;
            calcularnota.calificacion2 = cal2;
            calcularnota.calificacion3 = cal3;

            //se llama la funcion donde se esta realizando el proceso
            promedio = calcularnota.CalcularPromedio();

            //se muestran los programas
            Console.WriteLine($"El estudiante {NombreEstudiante}{apellidoestudiante} obtuvo las siguientes calificaciones: ");
            Console.WriteLine($"Calificacion 1: {cal1}\n Calificacion 2: {cal2}\n Calificacion 3: {cal3}");
            Console.WriteLine($"El promedio es de: {promedio}");

        }
    }
}
