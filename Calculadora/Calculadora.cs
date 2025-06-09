namespace EspacioCalculadora
{
    public class Calculadora{
        private double numero;
        public Calculadora(double valorInicial=0)
        {
            numero=valorInicial;
        }
        public void Sumar(double termino)
        {
            numero += termino;
        }
        public void Restar(double termino)
        {
            numero -= termino;
        }
        public void Multiplicar(double termino)
        {
            numero *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                numero /= termino;
            }
            else
            {
                throw new DivideByZeroException("No se puede dividir por cero");
            }
        }
        public double Resultado
        {
            get => numero;
        }
        public void Limpiar()
        {
            numero=0;
        }
    }
}

