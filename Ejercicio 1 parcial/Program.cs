namespace Ejercicio1Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese el valor de la diagonal mayor del rombo: ");
            double diagonalMayor = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("Ingrese el valor de la diagonal menor del rombo: ");
            double diagonalMenor = Convert.ToDouble(Console.ReadLine());

      
            double area = (diagonalMayor * diagonalMenor) / 2;

            double lado = Math.Sqrt(Math.Pow(diagonalMayor / 2, 2) + Math.Pow(diagonalMenor / 2, 2));

           
            double perimetro = lado * 4;

          
            double superficie = area;

        
            Console.WriteLine($"\nEl área del rombo es: {area}");

            Console.WriteLine($"El valor del lado del rombo es: {lado}");

            Console.WriteLine($"El perímetro del rombo es: {perimetro}");

          
            Console.WriteLine($"La superficie del rombo es: {superficie}");

       
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

