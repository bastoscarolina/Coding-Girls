namespace Aula05
{
    public abstract class Veiculos
    {
        protected string marca = String.Empty;
        protected int quantidadeDeRodas;
        protected bool motorizado;
        protected double velocidade = 0;

        public abstract void Frear();

        public abstract void Acelerar();
    }

    public class Bicicleta : Veiculos
    {

        public Bicicleta(){
            this.quantidadeDeRodas = 2;
            this.motorizado = false;
        }
        public string Marca{
            get{
                return marca;
            }
            set{
                marca = value;
            }
        }

        public int QuantidadeDeRodas{
            get{
                return quantidadeDeRodas;
            }
        }
        public bool Motorizados{
            get{
                return motorizado;
            }
        }
        public double Velocidade{
            get{
                return velocidade;
            }
        }
        public override void Frear(){
            if(velocidade > 0){
                velocidade -= 1;
            } else{
                Console.WriteLine("Bicicleta parada");
            }
        }
        public override void Acelerar()
        {
            velocidade +=1;
        }

        public void AjusteCorreias(){
            Console.WriteLine("Correias ajustadas");
        }
    }

    public class Onibus:Veiculos
    {
        public Onibus(){
            this.quantidadeDeRodas = 6;
            this.motorizado = true;
        }
        public string Marca{
            get{
                return marca;
            }
            set{
                marca = value;
            }
        }
        public int QuantidadeDeRodas{
            get{
                return quantidadeDeRodas;
            }
        }
        public bool Motorizados{
            get{
                return motorizado;
            }
        }
        public double Velocidade{
            get{
                return velocidade;
            }
        }
        public override void Frear(){
            if(velocidade - 5 > 0){
                velocidade -= 5;
            } else{
                Console.WriteLine("Onibus parado");
            }
        }
        public override void Acelerar()
        {
            velocidade +=10;
        }
        public void TrocarDeOleo(){
            Console.WriteLine("Oleo trocado com sucesso.");
        }
    }
}