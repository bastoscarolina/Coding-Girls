namespace Aula05
{
    public abstract class Calculadora
    {
        public double Soma(double numero1, double numero2){
            return numero1 + numero2;
        }

        public double Subtracao(double numero1, double numero2){
            return numero1-numero2;
        }
        public double Multiplicacao(double numero1, double numero2){
            return numero1 * numero2;
        }
        public double Divisao(double numero1, double numero2){
            return numero1/numero2;
        }
    }

    public class CalculadoraCientifica : Calculadora
    {
        public int Soma(int numero1, int numero2){
            return numero1 + numero2;
        }
        public int Subtracao(int numero1, int numero2){
            return numero1-numero2;
        }
        public int Multiplicacao(int numero1, int numero2){
            return numero1 * numero2;
        }
        public int Divisao(int numero1, int numero2){
            return numero1/numero2;
        }
        public double RaizQuadrada(double numero){
            return Math.Sqrt(numero);
        }
        public double RaizQuadrada(int numero1){
            return Math.Sqrt(numero1);
        }

        public double Potencia(double numero, double numero2){
           return  Math.Pow(numero,numero2);
        }
        public double Potencia(int numero, int numero2){
           return  Math.Pow(numero,numero2);
        }
    }
}