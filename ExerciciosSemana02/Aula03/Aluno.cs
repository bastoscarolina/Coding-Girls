namespace Aula03
{
    public class Aluno
    {
        
        private string nome;
        private double[] notas = new double[1];
        private string frequencia = "100%";
        private int alunoID = 01;
        private int contadorDeNotas = 0;

        public Aluno(){
            alunoID +=1;
        }

        public void CadastraAluno(string nome){
            this.nome = nome;
        }

        public void AdicionaNota(double nota){
            notas[contadorDeNotas]= nota;
            Array.Resize(ref notas, notas.Length+1);
            contadorDeNotas +=1;            
        }
        public void ConsultaAluno(int alunoID){
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine("Notas: ");
            foreach (double item in notas)
            {
                if(item !=0){
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine($"Frequência: {frequencia}");
        }
    }
}