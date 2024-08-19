using Entidades;
namespace Ejercicio3Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            
                Console.Write("Ingrese el valor de la diagonal mayor del rombo: ");
                double diagonalMayor = Convert.ToDouble(Console.ReadLine());

                
                Console.Write("Ingrese el valor de la diagonal menor del rombo: ");
                double diagonalMenor = Convert.ToDouble(Console.ReadLine());

                
                Rombo rombo = new Rombo(diagonalMayor, diagonalMenor);

                
                double lado = rombo.ObtenerLado();
                double perimetro = rombo.ObtenerPerimetro();
                double superficie = rombo.ObtenerSuperficie();

                Console.WriteLine($"\nResultados del rombo:");
                Console.WriteLine($"Diagonal Mayor: {rombo.ObtenerDiagonalMayor()}");
                Console.WriteLine($"Diagonal Menor: {rombo.ObtenerDiagonalMenor()}");
                Console.WriteLine($"Lado: {lado}");
                Console.WriteLine($"Perímetro: {perimetro}");
                Console.WriteLine($"Superficie: {superficie}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Formato de entrada inválido. Ingrese un número válido.");
            }

           
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

