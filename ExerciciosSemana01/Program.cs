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
/*
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
*/
/*
//Aula 04

//Exercício 01
int[] vetor1 = new int [10];
int[] vetor2 = new int [10];
for (int i = 0; i < vetor1.Length; i++)
{
    Console.WriteLine($"Insira o número na posição {i+1}");
    vetor1[i] = int.Parse(Console.ReadLine());
    vetor2[i] = vetor1[i]*5;
};
Console.WriteLine("Vetor 1");
for(int i =0;i<vetor1.Length;i++){
    Console.Write($"{vetor1[i]} ");
};
Console.WriteLine(" ");
Console.WriteLine("Vetor 2");
for(int i =0;i<vetor2.Length;i++){
    Console.Write($"{vetor2[i]} ");
};

//Exercício 02
int[] valoresUsuario = new int[10];
int[] pares = new int[10];
int[] impares = new int[10];
for (int i = 0; i < valoresUsuario.Length; i++)
{
    Console.WriteLine($"Insira o valor {i+1}");
    int valor =int.Parse(Console.ReadLine());
    if(valor%2==0){
        pares[i] = valor;
    }else{
        impares[i]=valor;
    };
};

Console.WriteLine("Pares");
for (int i = 0; i < pares.Length; i++)
{
    if(pares[i]!=0){
    Console.WriteLine(pares[i]);
    };
};

Console.WriteLine("Impares");
for (int i = 0; i < impares.Length; i++)
{
    if(impares[i]!=0){
    Console.WriteLine(impares[i]);
    };
};

//Exercício 03
string[] palavras = new string [5];
for (int i = 0; i < palavras.Length; i++)
{
    Console.WriteLine($"Insira a palavra {i+1}");
    palavras[i] = Console.ReadLine();
};
palavras = palavras.OrderBy(_=>_.Length).ToArray();
foreach (var item in palavras)
{
    System.Console.WriteLine(item);    
}
*/

//Exercício 04
string resposta = "s";
while(resposta != "n"){

    Console.WriteLine("Insira quantas rodadas você gostaria de jogar?");
    int rodadas = int.Parse(Console.ReadLine());
    //vitorias[0] - usuario; vitorias[1] - computador
    int[] vitorias = new int[2];
    //1 - pedra; 2 - papel; 3 - tesoura
    Random rnd = new Random();
    for (int i = 0; i < rodadas; i++)
    {    
        int opcaoComputador = rnd.Next(1,3);
        Console.WriteLine("Qual sua escolha da rodada?\n1 - Pedra\n2 - Papel\n3 - Tesoura");
        int opcaoUsuario = int.Parse(Console.ReadLine());
        // if(opcaoUsuario != 1 || opcaoUsuario != 2 || opcaoUsuario !=3){
        //     Console.WriteLine("Opcão inválida, escolha de novo");
        //     i--;
        // };
        if(opcaoComputador == 1){
            if(opcaoUsuario == 2){
                vitorias[0] += 1;
            } else if(opcaoUsuario == 3){
                vitorias[1] += 1;
            }
        } else if(opcaoComputador == 2){
            if(opcaoUsuario == 3){
                vitorias[0] += 1;
            } else if(opcaoUsuario == 1){
                vitorias[1] += 1;
            }
        }  else if(opcaoComputador == 3){
            if(opcaoUsuario == 1){
                vitorias[0] += 1;
            } else if(opcaoUsuario == 2){
                vitorias[1] += 1;
            }
        }
        // Console.WriteLine(opcaoUsuario +" "+ opcaoComputador);
        // Console.WriteLine(vitorias[0] +" "+ vitorias[1]);
    }
    if(vitorias[0]> vitorias[1]){
        Console.WriteLine($"Você ganhou com {vitorias[0]} pontos contra {vitorias[1]} vitórias do computador");
    } else if(vitorias[0]< vitorias[1]){
        Console.WriteLine($"O computador ganhou com {vitorias[1]} pontos contra {vitorias[0]} vitórias suas");
    } else{
        Console.WriteLine("Deu empate!");
    }
    Console.WriteLine("Deseja jogar novamente?\n 's' para sim ou 'n' para não");
    resposta = Console.ReadLine();
}


/*
//Exercício 05
char[,] tabuleiro = {{'c','c','c'},{'c','c','c'},{'c','c','c'}};
char jogadorX = 'X';
char jogadorO = 'O';
char jogadorDaVez = jogadorX;
for(int k =0; k<tabuleiro.Length;k++){
    Console.WriteLine($"Jogador {jogadorDaVez}, escolha a coluna onde deseja jogar:");
    int coluna = int.Parse(Console.ReadLine());
    Console.WriteLine($"Jogador {jogadorDaVez}, escolha a linha onde deseja jogar:");
    int linha = int.Parse(Console.ReadLine());
    if(tabuleiro[linha-1,coluna-1] == 'c'){
        tabuleiro[linha-1,coluna-1] = jogadorDaVez;
        if(jogadorDaVez == jogadorX){
            jogadorDaVez = jogadorO;
        } else {
            jogadorDaVez = jogadorX;
        }
    }else{
        Console.WriteLine("Posição ja ocupada, por favor escolha outra.");
        k--;
    };
};
if(tabuleiro[0,0]!='c' && tabuleiro[0,0]==tabuleiro[0,1] && tabuleiro[0,0]==tabuleiro[0,2]){
    Console.WriteLine($"O Jogador {tabuleiro[0,0]} ganhou!");
}else if(tabuleiro[1,0]!='c' && tabuleiro[1,0]==tabuleiro[1,1] && tabuleiro[1,0]==tabuleiro[1,2]){
    Console.WriteLine($"O Jogador {tabuleiro[1,0]} ganhou!");
}else if(tabuleiro[2,0]!='c' && tabuleiro[2,0]==tabuleiro[2,1] && tabuleiro[2,0]==tabuleiro[2,2]){
    Console.WriteLine($"O Jogador {tabuleiro[2,0]} ganhou!");
}else if(tabuleiro[0,0]!='c' && tabuleiro[0,0]==tabuleiro[1,0] && tabuleiro[0,0]==tabuleiro[2,0]){
    Console.WriteLine($"O Jogador {tabuleiro[0,0]} ganhou!");
}else if(tabuleiro[0,1]!='c' && tabuleiro[0,1]==tabuleiro[1,1] && tabuleiro[0,1]==tabuleiro[2,1]){
    Console.WriteLine($"O Jogador {tabuleiro[0,1]} ganhou!");
}else if(tabuleiro[0,2]!='c' && tabuleiro[0,2]==tabuleiro[1,2] && tabuleiro[0,2]==tabuleiro[2,2]){
    Console.WriteLine($"O Jogador {tabuleiro[0,2]} ganhou!");
}else if(tabuleiro[0,0]!='c' && tabuleiro[0,0]==tabuleiro[1,1] && tabuleiro[0,0]==tabuleiro[2,2]){
    Console.WriteLine($"O Jogador {tabuleiro[0,0]} ganhou!");
}else if(tabuleiro[0,2]!='c' && tabuleiro[0,2]==tabuleiro[1,1] && tabuleiro[0,2]==tabuleiro[2,0]){
    Console.WriteLine($"O Jogador {tabuleiro[0,2]} ganhou!");
}else{
    Console.WriteLine("Deu velha!");
};
*/

