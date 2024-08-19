namespace Entidades
{
    public class Rombo
    {
     
        private double _diagonalMayor;
        private double _diagonalMenor;

        public Rombo(double diagonalMayor, double diagonalMenor)
        {
            AsignarDiagonales(diagonalMayor, diagonalMenor);
        }

        public void AsignarDiagonales(double diagonalMayor, double diagonalMenor)
        {
            if (diagonalMayor <= 0 || diagonalMenor <= 0)
            {
                throw new ArgumentException("Las diagonales deben ser valores positivos.");
            }
            _diagonalMayor = diagonalMayor;
            _diagonalMenor = diagonalMenor;
        }

     
        public double ObtenerDiagonalMayor()
        {
            return _diagonalMayor;
        }

        public double ObtenerDiagonalMenor()
        {
            return _diagonalMenor;
        }

      
        public double CalcularLado()
        {
            return Math.Sqrt(Math.Pow(_diagonalMayor / 2, 2) + Math.Pow(_diagonalMenor / 2, 2));
        }

        public double CalcularPerimetro()
        {
            double lado = CalcularLado();
            return lado * 4;
        }

        public double CalcularSuperficie()
        {
            return (_diagonalMayor * _diagonalMenor) / 2;
        }

       
        public double ObtenerLado()
        {
            return CalcularLado();
        }

        public double ObtenerPerimetro()
        {
            return CalcularPerimetro();
        }

        public double ObtenerSuperficie()
        {
            return CalcularSuperficie();
        }
    }
}

