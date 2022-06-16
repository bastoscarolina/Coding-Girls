namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01();
            Exercicio02();
            //Exercicio03();

        }


        //Exercicio da Aula
        static void ExercicioAula()
        {
            Console.WriteLine("Insira sua altura em metros");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu peso em kgs");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine(retornarDiagnostico(altura, peso));

            static string retornarDiagnostico(float altura, float peso)
            {
                float IMC = peso / (altura * altura);
                string mensagem;
                if (IMC < 18.5)
                {
                    mensagem = "Seu diagnóstico é: anêmico";
                } else if (IMC < 25)
                {
                    mensagem = "Seu diagnóstico é: normal";
                } else if(IMC < 30)
                {
                    mensagem = "Seu diagnóstico é: sobrepeso";
                } else if(IMC < 40)
                {
                    mensagem = "Seu diagnóstico é: obesidade";
                }
                else
                {
                    mensagem = "Seu diagnóstico é: obesiade grave";
                }
                return mensagem;
            }
        }

        static void Exercicio01()
        {
            Console.WriteLine("Quantos alunos deseja inserir?");
            int tamanho = int.Parse(Console.ReadLine());
            Aluno[] alunos = new Aluno[tamanho]; 
            for(int i = 0; i < tamanho; i++)
            {
                alunos[i] = new Aluno();
                Console.WriteLine($"Insira o nome do aluno {i+1}:");
                alunos[i].nome = Console.ReadLine();
                Console.WriteLine($"Insira a matrícula do aluno {i + 1}:");
                alunos[i].matricula = Console.ReadLine();
                Console.WriteLine($"Insira a nota da primeira prova do aluno {i + 1}:");
                alunos[i].notaProva1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Insira a nota da segunda prova do aluno {i + 1}:");
                alunos[i].notaProva2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Insira a nota do trabalho do aluno {i + 1}:");
                alunos[i].notaTrabalho = Convert.ToDouble(Console.ReadLine());
            };
            for (int i = 0; i < tamanho; i++)
            {
                double resultado = alunos[i].calculaMedia(alunos[i].notaProva1, alunos[i].notaProva2, alunos[i].notaTrabalho);
                if(resultado >= 7)
                {
                    Console.WriteLine($"{alunos[i].nome} foi aprovado com a média {resultado:F2}");
                } else if (resultado >= 5)
                {
                    double notaFinal = alunos[i].calculaNotaFinal(alunos[i].notaProva1, alunos[i].notaProva2, alunos[i].notaTrabalho);
                    Console.WriteLine($"{alunos[i].nome} teve média {resultado:F2} e vai para a final precisando de {notaFinal:F2}");
                } else
                {
                    Console.WriteLine($"{alunos[i].nome} foi reprovado com a média {resultado:F2}");
                }
            }

            
            
        }

        static void Exercicio02()
        {
            Voo voo = new Voo();
            DateTime data = new DateTime(2022,09,11,09,25,00);
            voo.data = data;
            Console.WriteLine($"O voo tem {voo.VagasLivre()} vagas livres");
            Console.WriteLine("Qual assento gostaria de reservar?");
            int assento = int.Parse(Console.ReadLine());
            voo.OcuparVaga(assento);
            Console.WriteLine($"O voo tem {voo.VagasLivre()} vagas livres");
            Console.WriteLine($"A próxima poltrona livre é a {voo.CadeiraLivre()}");
            voo.verHorario();
        }

        static void Exercicio03()
        {
            Calculadora calculadora = new Calculadora();
            int opcao;
            double numero1;
            double numero2;
            do
            {
                Console.WriteLine("<-- Qual operação você deseja realizar? -->");
                Console.WriteLine("1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair");
                opcao = int.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Qual o primeiro número da operação?");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Qual o segundo número da operação?");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"A soma de {numero1} e {numero2} é {calculadora.Adicao(numero1,numero2):F2}");
                        break;
                    case 2:
                        Console.WriteLine("Qual o primeiro número da operação?");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Qual o segundo número da operação?");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"A subtração de {numero1} e {numero2} é {calculadora.Subtracao(numero1,numero2):F2}");
                        break;
                    case 3:
                        Console.WriteLine("Qual o primeiro número da operação?");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Qual o segundo número da operação?");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"A multiplicação de {numero1} e {numero2} é {calculadora.Multiplicacao(numero1,numero2):F2}");
                        break;
                    case 4:
                        Console.WriteLine("Qual o primeiro número da operação?");
                        numero1 = Convert.ToDouble(Console.ReadLine ());
                        Console.WriteLine("Qual o segundo número da operação?");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"A divisão de {numero1} e {numero2} é {calculadora.Divisao(numero1,numero2):F2}");
                        break;
                    default:
                        opcao = 5;
                        break;
                }
            } while (opcao != 5);
            
        }
    }

    
}