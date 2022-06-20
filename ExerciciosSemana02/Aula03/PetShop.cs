namespace Aula03
{
    public class PetShop
    {
        string nomeAnimal = String.Empty;
        string especieAnimal = String.Empty;
        string corAnimal = String.Empty;
        string idadeAnimal = String.Empty;
        string observacoes = "Nenhuma observação";

        private Tutor dadosTutor = new Tutor();
        public void CadastroPet(){
            Console.WriteLine("Qual o nome do pet?");
            this.nomeAnimal = Console.ReadLine();
            Console.WriteLine("Qual a espécie do pet?");
            this.especieAnimal = Console.ReadLine();
            Console.WriteLine("Qual a cor do pet?");
            this.corAnimal = Console.ReadLine();
            Console.WriteLine("Qual a idade do pet?");
            this.idadeAnimal = Console.ReadLine();
            Console.WriteLine("Qual o nome do Tutor?");
            this.dadosTutor.setNome(Console.ReadLine());
            Console.WriteLine("Qual o telefone de contato do Tutor?");
            this.dadosTutor.setContato(Console.ReadLine());
        }
        public void InserirObservacao(string observacao){
            this.observacoes = observacao;
        }
        public void InfosPet(PetShop animal){
            Console.WriteLine($"Nome do pet: {animal.nomeAnimal}");
            Console.WriteLine($"Espécie do pet: {animal.especieAnimal}");
            Console.WriteLine($"Cor do pet: {animal.corAnimal}");
            Console.WriteLine($"Idade do pet: {animal.idadeAnimal}");
            Console.WriteLine($"Observações do pet: {animal.observacoes}");
        }
    }

    public class Tutor{
        string nome = String.Empty;
        string telefoneContato = String.Empty;

        public string getNome(){
            return nome;
        }
        public void setNome(string nome){
            this.nome = nome;
        }
        public string getContato(){
            return telefoneContato;
        }
        public void setContato(string contato){
            this.telefoneContato = contato;
        }
    }
}