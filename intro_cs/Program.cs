﻿using System.Buffers.Binary;
using System.Reflection.Metadata;
using intro_cs.Models;





// Calculadora calc = new Calculadora();

// calc.Somar(10, 2);
// calc.Subtrair(10, 2);
// calc.Multiplicar(10, 2);
// calc.Dividir(10, 2);
// calc.Pontencia(10, 2);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

//// Calculando incremento e decremento
// int numero = 10;
// Console.WriteLine(numero);
// Console.WriteLine($"Incrementando o {numero}");
// numero++;
// Console.WriteLine(numero);
// Console.WriteLine($"Decrementando o {numero}");
// numero--;
// Console.WriteLine(numero);






// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde) {
//     Console.WriteLine("Vou pedalar");
// } else {
//     Console.WriteLine("Pedalar outro dia");
// }





// bool PossuiPresencaMinima = true;
// double media = 7;

// if (PossuiPresencaMinima && media >= 7) {
//     Console.WriteLine("Aprovado");
// } else {
//     Console.WriteLine("Reprovado");
// }





// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel) {
//     Console.WriteLine("Entrada liberada");
// } else {
//     Console.WriteLine("Entrada negada");
// }





// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra) {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é vogal");
//         break;
// }





// if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u") {
//     Console.WriteLine("Vogal");
// } else {
//     Console.WriteLine("Não é vogal");
// }





// if (letra == "a") {
//     Console.WriteLine("Vogal");
// } else if (letra == "e") {
//     Console.WriteLine("Vogal");
// } else if (letra == "i") {
//     Console.WriteLine("Vogal");
// } else if (letra == "o") {
//     Console.WriteLine("Vogal");
// } else if (letra == "u") {
//     Console.WriteLine("Vogal");
// } else 
// {Console.WriteLine("Não é Vogal");
// }





// int produto = 3;
// int quantidadeCompra = 0;
// bool verificacaoVenda = quantidadeCompra > 0 && produto >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {produto}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a compra: {verificacaoVenda}");

// if (quantidadeCompra == 0) {
//     Console.WriteLine("Venda inválida");
// } else if (verificacaoVenda) {
//     Console.WriteLine("Compra realizada com sucesso!");
// } else {
//     Console.WriteLine("Quantidade forá de estoque para a compra!");
// }





// int inteiro = 10;
// string a = Inteiro.ToString();
// Console.WriteLine(a);





// string b = "4";
// int c = int.Parse(b);
// Console.WriteLine(c);





// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(DataAtual.ToString("dd/MM/yyyy HH:mm"));





// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 2.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine($"Valor da variável Quantidade: {Quantidade}");
// Console.WriteLine($"Valor da variável Altura: {Altura.ToString("0.00")} m");
// Console.WriteLine($"Valor da variável Preço: R$ {Preco:C2}");
// Console.WriteLine($"Valor da variável Condição: {condicao}"); 





// Pessoa pessoa1 = new Pessoa();

// pessoa1.nome = "Vini";
// pessoa1.idade = 20;
// pessoa1.apresentar();