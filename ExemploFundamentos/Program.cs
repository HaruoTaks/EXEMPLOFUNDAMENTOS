﻿using ExemploFundamentos.Common.Models;


List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Console.WriteLine("Percorrendo a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a lista com o FOR");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {item}");
//     contadorForeach++;
// }





// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// // parecido com o resize, porem ele copia os dados para um array diferente
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// // // Resize ele internamente cria um novo array de mesmo nome com capacidade maior e copia os elementes do array anterior
// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o array com FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} = {arrayInteiros[contador]}");
// }

// Console.WriteLine("Percorrendo o array com FOREACH");

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} = {valor}");
//     contadorForeach++;
// }

// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Rodrigo";
// pessoa1.Idade = 32;
// pessoa1.Apresentar();


// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             //Environment.Exit(0);
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa se encerrou");


// int soma = 0, numero = 0;
// do
// {
//    Console.WriteLine("Digite um número (0 para parar)");
//    numero = Convert.ToInt32(Console.ReadLine());

//    soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");


// int numero = 5;
// int contador = 1;
// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}° Execução:{numero} X {contador} = {numero * contador}");
//     contador++;
//     if (contador == 6)
//     {
//         break;
//     }
// }


// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
// }


//Calculadora calc = new Calculadora();

// // calc.Somar(10, 30);
// // calc.Subtrair(10, 50);
// // calc.Multiplicar(15, 45);
// // calc.Dividir(2, 2);
// //calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
//calc.RaizQuadrada(9);

// // incremento

// int numeroIncremento = 10;

// Console.WriteLine("Incrementando o 10");
// // numero = numero +1;
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);
// // Decremento

// int numeroDecremento = 20;

// Console.WriteLine("Decrementando o 20");
// // numero = numero -1;
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);


// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }

// bool possuiPresencaMinima = true;
// double media = 5.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reporvado!");
// }



// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }





//  || - sinal de pipe - verifica se uma das condiçoes e verdadeira
// if (letra == "a"||
//     letra == "e"||
//     letra == "i"||
//     letra == "o"||
//     letra == "u"||)
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }
// int quantidadeEmEstoque = 3;
// int quantidadeCompra =0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else

// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }


// string a = "15-";

// //int b = Convert.ToInt32(a);

// // int b = 0;
// // int.TryParse(a, out b);

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso");


// // C# usa ordem matemática para realizar as operações, caso queira dar prioridade para uma conta deve colocar a mesma em ()
// double a = 4 / (2 + 2);

// Console.WriteLine(a);



// // Cast implicito
// // int a = 5;
// // double b = a;

// // int a = 5;
// // long b = a;

// // //Apresenta erro pois o maxlong extrapola o limite do inteiro
// // long a = long.MaxValue;
// // int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);

// int inteiro = 5;
// String a  = inteiro.ToString();
// Console.WriteLine(a);



// Cast - Casting = conversão de string para inteiro
//int a = Convert.ToInt32("5");
//int a = int.Parse("5c");

// No convert ele realiza a conversão
// int a = Convert.ToInt32(null);

// // No Parse apresenta exceçao e encerra o programa
// //int a = int.Parse(null);
// Console.WriteLine(a);


// int a = 10;
// int b = 20;

// int c = a + b;

// // c += 5; // equivalente a c = c + 5;

// c -= 5; // equivalente a c = c - 5;

// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// string Apresentacao = "Olá seja bem vindo";

// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao =  true;

// Console.WriteLine(Apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Rodrigo";
// pessoa1.Idade = 31;
// pessoa1.Apresentar();

// Pessoa pessoaFisicaRepresentacao = new Pessoa();
