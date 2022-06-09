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
/*
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
*/

//Aula 03

//Exercício 01
Console.WriteLine("Insira o valor a ser sacado:");
float valor = float.Parse(Console.ReadLine());
int notas100 = (int)valor/100;
valor = valor % 100;
int notas50 = (int)valor/50;
valor = valor%50;
int notas20 = (int)valor/20;
valor = valor%20;
int notas10 = (int)valor/10;
valor = valor%10;
int notas5 = (int)valor/5;
valor = valor%5;
int notas2 = (int)valor/2;
valor = valor%2;
Console.WriteLine($" Seu saque será em {notas100} notas de 100, {notas50} notas de 50, {notas20} notas de 20, {notas10} notas de 10, {notas5} notas de 5, {notas2} notas de 2 e {valor:F2} em moedas");
//Exercício 02
int[] valores = new int [3];
for(int i = 0; i< valores.Length;i++){
    Console.WriteLine($"Insira o valor da posição {i}");
    valores[i]=int.Parse(Console.ReadLine());
};
int maior = valores[0];
for(int i = 1;i<valores.Length;i++){
    if(valores[i]>maior){
        maior = valores[i];
    };
};
Console.WriteLine($"{maior} é o maior valor");

//Exercício 03
float[] notas = new float[3];
for(int i =0;i<notas.Length;i++){
    Console.WriteLine($"Insira a nota {i+1}");
    float notaRecebida = float.Parse(Console.ReadLine());
    if(notaRecebida>=0 && notaRecebida<=10){
        notas[i] = notaRecebida;
    }else{
        Console.WriteLine("Insira nota válida entre 0 e 10");
        i--;
    };
}
float media = (notas[0]+notas[1]+notas[2])/3;
if(media>=7.0){
    Console.WriteLine($"Aluno aprovado com média {media:F2}");
}else{
     Console.WriteLine($"Aluno reprovado com média {media:F2}");
}
//Exercício 04
float[] notas = new float[3];
for(int i =0;i<notas.Length;i++){
    Console.WriteLine($"Insira a nota {i+1}");
    float notaRecebida = float.Parse(Console.ReadLine());
    if(notaRecebida>=0 && notaRecebida<=10){
        notas[i] = notaRecebida;
    }else{
        Console.WriteLine("Insira nota válida entre 0 e 10");
        i--;
    };
}
float media = (notas[0]+notas[1]+notas[2])/3;

 if (media>0 && media<6){
    Console.WriteLine($"Reprovado com média {media:F2}: nota F");
 } else if (media>=6 && media<7){
    Console.WriteLine($"Reprovado com média {media:F2}: nota D");
 } else if(media>=7 && media<8){
    Console.WriteLine($"Aprovado com média {media:F2}: nota C");
 } else if(media>=8 && media<9){
    Console.WriteLine($"Aprovado com média {media:F2}: nota B");
 } else if(media>=9){
    Console.WriteLine($"Aprovado com média {media:F2}: nota A. Parabéns!");
 }
//Exercício 05
Console.WriteLine("Qual é o salário atual do funcionário?");
float salarioAtual = float.Parse(Console.ReadLine());
float novoSalario = (salarioAtual>0 && salarioAtual<=400)? (novoSalario = salarioAtual*1.15f):(salarioAtual<=800)?(novoSalario = salarioAtual*1.12f): (salarioAtual<=1200)?(novoSalario = salarioAtual*1.1f): (salarioAtual<=2000)?(novoSalario = salarioAtual*1.07f): (novoSalario = salarioAtual*1.04f);

Console.WriteLine($"O salário sofreu um reajuste de R${novoSalario-salarioAtual:F2}, correspondente a {(novoSalario/salarioAtual*100)-100:F2}%. O novo salário será de {novoSalario:F2}");