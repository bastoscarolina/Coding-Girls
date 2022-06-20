namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio03();
            //Exercicio04();
            
        }

        static void Exercicio01()
        {
            Aluno aluno1 = new Aluno();
            Console.WriteLine("Insira o nome do aluno a ser cadastrado");
            aluno1.CadastraAluno(Console.ReadLine());
            Console.WriteLine("Insira a nota do aluno a ser adicionada");
            aluno1.AdicionaNota(Convert.ToDouble(Console.ReadLine()));
            aluno1.ConsultaAluno(01);
            
        }
        static void Exercicio03(){
            Console.WriteLine("Qual o nome do cliente?");
            string nome = Console.ReadLine();
            ContaBancaria contaDaJu = new ContaBancaria(01,nome);
            Console.WriteLine($"Conta da : {contaDaJu.Nome}");
            // contaDaJu.AlteraNome("Juliana");
            // Console.WriteLine($"Conta da : {contaDaJu.Nome}");
            Console.WriteLine("Qual valor será depositado?");
            double deposito = Convert.ToDouble(Console.ReadLine());
            contaDaJu.Deposito(deposito);
            Console.WriteLine("Qual valor será sacado?");
            double saque = Convert.ToDouble(Console.ReadLine());
            contaDaJu.Saque(saque);
            Console.WriteLine($"O atual saldo da conta é R${contaDaJu.Saldo}");
            Console.WriteLine("Qual valor será sacado?");
            saque = Convert.ToDouble(Console.ReadLine());
            contaDaJu.Saque(saque);
            Console.WriteLine($"O atual saldo da conta é R${contaDaJu.Saldo}");            
        }
        static void Exercicio04(){
            PetShop pet1 = new PetShop();
            pet1.CadastroPet();
            pet1.InfosPet(pet1);
        }
                
    }
}