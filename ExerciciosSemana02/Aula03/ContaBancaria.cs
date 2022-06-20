namespace Aula03
{
    public class ContaBancaria
    {
        private int numeroDaConta;
        private string nomeDoCliente;
        private double saldoDoCliente;

        public string Nome{
            get{
                return this.nomeDoCliente;
            }
        }

        public double Saldo{
            get{
                return this.saldoDoCliente;
            }
        }
    
        public void AlteraNome(string nome){
            this.nomeDoCliente = nome;
        }
        public void Deposito(double valor){
            saldoDoCliente += valor; 
        }

        public void Saque(double valor){
            if(valor<saldoDoCliente){
                saldoDoCliente -=valor;
            }else{
                Console.WriteLine("Operação não realizada pois saldo insuficiente");
            }
        }
        public ContaBancaria(int numeroConta, string nome, double saldo = 0){
            this.numeroDaConta = numeroConta;
            this.nomeDoCliente = nome;
            this.saldoDoCliente = saldo;
        }
    }
}