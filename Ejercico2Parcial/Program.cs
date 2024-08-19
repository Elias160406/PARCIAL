namespace Ejercicio2Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadRombos = 5;
            double[] diagonalesMayores = new double[cantidadRombos];
            double[] diagonalesMenores = new double[cantidadRombos];
            double[] perimetros = new double[cantidadRombos];
            double mayorArea = 0;
            int iteracionMayorRombo = 0;

            for (int i = 0; i < cantidadRombos; i++)
            {
                Console.WriteLine($"\nIngrese los datos para el rombo {i + 1}:");

               
                double diagonalMayor;
                do
                {
                    Console.Write("Diagonal Mayor: ");
                    diagonalMayor = Convert.ToDouble(Console.ReadLine());
                    if (diagonalMayor <= 0)
                    {
                        Console.WriteLine("Error: La diagonal mayor debe ser un valor positivo.");
                    }
                } while (diagonalMayor <= 0);

                diagonalesMayores[i] = diagonalMayor;

                double diagonalMenor;
                do
                {
                    Console.Write("Diagonal Menor: ");
                    diagonalMenor = Convert.ToDouble(Console.ReadLine());
                    if (diagonalMenor <= 0)
                    {
                        Console.WriteLine("Error: La diagonal menor debe ser un valor positivo.");
                    }
                } while (diagonalMenor <= 0);

                diagonalesMenores[i] = diagonalMenor;

                
                double area = (diagonalMayor * diagonalMenor) / 2;

          
                double lado = Math.Sqrt(Math.Pow(diagonalMayor / 2, 2) + Math.Pow(diagonalMenor / 2, 2));

              
                double perimetro = lado * 4;
                perimetros[i] = perimetro;

                
                double superficie = area;

                
                if (area > mayorArea)
                {
                    mayorArea = area;
                    iteracionMayorRombo = i + 1; 
                }

            
                Console.WriteLine($"\nResultados para el rombo {i + 1}:");
                Console.WriteLine($"Área: {area}");
                Console.WriteLine($"Lado: {lado}");
                Console.WriteLine($"Perímetro: {perimetro}");
                Console.WriteLine($"Superficie: {superficie}");
            }

    
            double promedioPerimetros = 0;
            foreach (double perimetro in perimetros)
            {
                promedioPerimetros += perimetro;
            }
            promedioPerimetros /= cantidadRombos;

            
            Console.WriteLine($"\nEl rombo con mayor tamaño (mayor área) fue ingresado en la iteración {iteracionMayorRombo}, con un área de {mayorArea}.");
            Console.WriteLine($"El promedio de los perímetros de los rombos ingresados es: {promedioPerimetros}");

            
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
