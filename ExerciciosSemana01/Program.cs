// See https://aka.ms/new-console-template for more information
/*
//Aula 01

//Exercício 01
Console.WriteLine("Nome: Carolina Bastos Almeida");
Console.WriteLine("Endereço: Rua ABC do XPTO,999");
Console.WriteLine("CEP: 99.999-999");
Console.WriteLine("Telefone: (99) 9 9999-9999");
//Exercício 02
string nome = "Grace Hopper";
string formacao = "Analista de Sistemas";
string contribuicao = "Criou a Linguagem Comum Orientada para Negócios (COBOL, na sigla em inglês)";
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Formação: {formacao}");
Console.WriteLine($"Contribuição feita: {contribuicao}");
//Exercício 03
string refraoMusica ="The show must go on, the show must go on, inside my heart is breaking, my makeup may be flaking, but my smile, still, stays on";
string compositor = "Freddie Mercury, Roger Meddows-Taylor, Brian May e John Deacon";
string generoMusical = "Pop Rock/French Indie";
Console.WriteLine(refraoMusica);
Console.WriteLine($"Compositor(es): {compositor}");
Console.WriteLine($"Gênero: {generoMusical}");
//Exercício 04
string mensagemIncentivo = "Eu levanto minha voz - não para que eu possa gritar, mas para que aqueles Sem uma voz pode ser ouvida ... não podemos ter sucesso quando metade de nós são retidos. - Malala";
Console.WriteLine(mensagemIncentivo);
*/

//Aula 02

//Exercício 01
Console.WriteLine("Qual seu ano de nascimento?");
int anoNascimento = int.Parse(Console.ReadLine());
int anoAtual = 2022;
int idade = anoAtual - anoNascimento;
Console.WriteLine($"Ao final de {anoAtual} você terá {idade} anos");
//Exercício 02
int[] valores = new int[10];
int soma = 0;
for(int i =0; i<valores.Length;i++){
    Console.WriteLine($"Insira o valores na posição {i}");
    valores[i] = int.Parse(Console.ReadLine());
    soma += valores[i];
}
Console.WriteLine($"A soma dos valores deu {soma}");
//Exercício 03
Console.WriteLine("Quantas horas o funcionário trabalhou?");
float horasTrabalhadas = float.Parse(Console.ReadLine());
Console.WriteLine("Qual é o salário por hora desse funcionário?");
float salarioHora = float.Parse(Console.ReadLine());
float salarioFinal = horasTrabalhadas * salarioHora;
Console.WriteLine($"O funcionário receberá R${salarioFinal:F2} por {horasTrabalhadas} horas trabalhadas");
//Exercício 04
Console.WriteLine("Qual a idade a seu convertida?");
int anos = int.Parse(Console.ReadLine());
int meses = anos * 12;
int dias = meses * 30;
Console.WriteLine($"O usuário tem {anos} anos ou {meses} meses ou {dias} dias de idade");

//Exercício 05
Console.WriteLine("Digite o valor a ser convertido:");
float real = float.Parse(Console.ReadLine());
float dolar = real / 4.87f;
float euro = real / 5.21f;
float libra = real / 6.12f;
float dolarCanadense = real / 3.88f;
float pesoArgentino = real / 0.04f;
float pesoChileno = real / 0.0059f;

Console.WriteLine($"O valor em real corresponde a :\nUS$ {dolar:F2}\nE$ {euro:F2}\nL$ {libra:F2}\nC$ {dolarCanadense:F2}\nARS$ {pesoArgentino:F2}\nCLP$ {pesoChileno:F2}");