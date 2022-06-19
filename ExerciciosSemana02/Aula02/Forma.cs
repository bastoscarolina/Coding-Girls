namespace Aula02
{
    public abstract class Forma
    {
        public abstract double CalculaDimensao();
    }


    public class Quadrado : Forma
    {
        double lado;

        public void setLado(double lado){
            this.lado = lado;
        }
        public override double CalculaDimensao(){
            return lado*lado;
        }
    }

    public class Triangulo : Forma
    {
        double lado1;
        double lado2;
        double lado3;

        public void setLados(double lado1, double lado2, double lado3){
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }
        public override double CalculaDimensao(){
            double semiPerimetro = (lado1 + lado2 + lado3)/2;
            double area = Math.Sqrt(semiPerimetro*(semiPerimetro-lado1)*(semiPerimetro-lado2)*(semiPerimetro-lado3));
            return area;
        }

    }

    public class Circulo :Forma
    {
        double raio;
        public void setRaio(double raio){
            this.raio = raio;
        }
        public override double CalculaDimensao(){
            double area = Math.PI*(raio*raio);
            return area;
        }
    }

}