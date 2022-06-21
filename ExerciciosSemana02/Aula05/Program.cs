namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Exercicio02();
            // Exercicio03();
            // Exercicio04();
            
        }

        static void Exercicio01(){
            // projeto feito na aula 02
        }
        static void Exercicio02(){
            CalculadoraCientifica calculadora = new CalculadoraCientifica();
            Console.WriteLine(calculadora.Soma(2.3,2.7));
            Console.WriteLine(calculadora.Soma(2,7));
        }
        static void Exercicio03(){
            Bicicleta bicicleta1 = new Bicicleta();
            bicicleta1.Marca = "Kaloi";
            bicicleta1.Acelerar();
            Console.WriteLine($"Velocidade da bicicleta: {bicicleta1.Velocidade}");
            Onibus onibus1 = new Onibus();
            onibus1.Acelerar();
            Console.WriteLine($"Velocidade do onibus: {onibus1.Velocidade}");
        }
        static void Exercicio04(){
            Biblioteca biblioteca = new Biblioteca();
            Livro livro = biblioteca.AdicionaLivro("A Culpa é das Estrelas");
            biblioteca.AcervoBiblioteca();
            biblioteca.Emprestimo(livro);
            biblioteca.AcervoBiblioteca();
            biblioteca.Devolucao(livro);
            Periodico periodico = biblioteca.AdicionaPeriodico("Science", 76);
            biblioteca.LerPeriodico(periodico);
            biblioteca.AcervoBiblioteca();
        }
        
    }
}