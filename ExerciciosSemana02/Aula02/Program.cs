namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExercicioAula();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
            Exercicio05();
        }

        static void ExercicioAula(){
            Quadrado quadrado = new Quadrado();
            quadrado.setLado(5.5);
            Console.WriteLine(quadrado.CalculaDimensao());

            Triangulo triangulo = new Triangulo();
            triangulo.setLados(3,4,5);
            Console.WriteLine(triangulo.CalculaDimensao());

            Circulo circulo = new Circulo();
            circulo.setRaio(3);
            Console.WriteLine(circulo.CalculaDimensao());

        }

        static void Exercicio02(){
            Console.WriteLine("Insira o nome do funcionario:");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o cargo do funcionario:");
            string cargo = Console.ReadLine();
            Console.WriteLine("Insira o salario do funcionario:");
            double salario = Convert.ToDouble(Console.ReadLine());
            Empregado empregado = new Empregado(nome, cargo, salario);
            empregado.ImprimirSalario();
            empregado.ConcedeAumento(salario);
            empregado.ImprimirSalario();
        }

        static void Exercicio03(){
            Fatura fatura = new Fatura();
            Console.WriteLine("Quais produtos tem na compra?");
            string[] descricaoProdutos = (Console.ReadLine()).Split(',');
            fatura.setDescricaoProdutos(descricaoProdutos);
            Console.WriteLine("Quais as quantidades de cada um dos produtos que tem na compra?");
            int[] quantidadeProdutos = ((Console.ReadLine()).Split(',')).Select(int.Parse).ToArray();
            fatura.setQuantidadeProdutos(quantidadeProdutos);
            Console.WriteLine("Quais os preços de cada um dos produtos que tem na compra?");
            double[] precoProdutos = ((Console.ReadLine()).Split(',')).Select(double.Parse).ToArray();
            fatura.setPrecoProdutos(precoProdutos);
            Console.WriteLine($"O valor da sua fatura é:R$ {fatura.ValorFatura(quantidadeProdutos, precoProdutos)}");
            
        }
        static void Exercicio04(){
            Sorteio sorte = new Sorteio();
            sorte.SorteiaNumero();
            bool jogada = false;
            while (jogada == false)
            {
                Console.WriteLine("Qual o seu palpite?");
                int palpite = int.Parse(Console.ReadLine());
                jogada = sorte.ConfereNumero(palpite);
            }
        }
        static void Exercicio05(){
            ManipulaString manipulacao = new ManipulaString();
            Console.WriteLine("Insira o nome a ser abreviado");
            string[] nome = (Console.ReadLine()).Split(' ');
            manipulacao.Abreviatura(nome);
            Console.WriteLine(" ");
            Console.WriteLine("Insira o nome a ser invertido");
            string nomeInvertido = Console.ReadLine();
            Console.WriteLine(manipulacao.Inverte(nomeInvertido));
            Console.WriteLine("Insira o nome que deseja saber a quantidade de vogais e consoantes");
            string nomeVogaisEConsoantes = Console.ReadLine();
            manipulacao.VogaisEConsoante(nomeVogaisEConsoantes);

        }
    }
    
}