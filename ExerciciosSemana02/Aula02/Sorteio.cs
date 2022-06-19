namespace Aula02
{
    public class Sorteio
    {
        Random rnd = new Random();
        int numeroComputador;
        int tentativas;

        public void SorteiaNumero(){
            numeroComputador = rnd.Next(1,1000);
        }
        public bool ConfereNumero(int palpite){
            if(palpite<numeroComputador){
                tentativas = tentativas +1;
                Console.WriteLine("O número sorteado é maior que o palpite");
                return false;
            }else if(palpite>numeroComputador){
                tentativas = tentativas +1;
                Console.WriteLine("O número sorteado é menor que o palpite");
                return false;
            } else{
                Console.WriteLine("Parabéns, você acertou o número sorteado");
                Console.WriteLine($"Foram necessárias {tentativas} tentativas");
                return true;
            }
        }
    }
}