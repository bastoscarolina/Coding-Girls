namespace Aula02
{
    public class Empregado
    {
        private string nome = String.Empty;
        private string cargo = String.Empty;
        private double salario;
        private double aumento;

        public Empregado(string Nome, string Cargo, double Salario){
            this.nome = Nome; 
            this.cargo = Cargo;
            if(Salario<0){
                this.salario = 0;
            } else {
                this.salario = Salario;
            }
        }

        public void ConcedeAumento(double salario){
            aumento = 0;
            if(salario<=400){
                aumento = salario*0.15;
            } else if(salario<=800){
                aumento = salario *0.12;
            } else if(salario<=1200){
                aumento = salario*0.10;
            } else if (salario<=2000){
                aumento = salario*0.07;
            } else{
                aumento = salario *0.04;
            }
            this.salario += aumento;
            
        }

        public void ImprimirSalario(){
            Console.WriteLine($"O salario do funcionário {nome} é de {salario}");
        }

        
    }
}