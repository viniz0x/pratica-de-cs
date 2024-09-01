using System.Buffers.Binary;
using System.Reflection.Metadata;
using intro_cs.Models;





List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"\nItens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"\nItens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");



// foreach (string str in listaString) {
//     Console.WriteLine(str);
// } //Perconrendo com foreach simples

// //OR

// for(int contador = 0; contador < listaString.Count; contador++) {
//     Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
// } //Percorendo com for simples









// int[] arrayInteiros = new int[3];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;


// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); //A ação correta dessa fução não é aumentar o valor do array, e sim criar uma nova array com o dobro de tamanho e copiar os valores do anterior.


// Console.WriteLine("\nPercorrendo o Array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++) {
//     Console.WriteLine($"Possição N° {contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine("\nPercorrendo o Array com o FOREACH");
// int contadorForeach = 0;
// foreach (int valor in arrayInteiros) {
//     Console.WriteLine($"Possição N° {contadorForeach} - {valor}");
//     contadorForeach++;
// }










// string opcao;
// bool exibirMenu = true;

// while (exibirMenu) {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opeção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     // Captura a tecla pressionada diretamente, sem ser necessário apertar o Entar #ByChatGPT
//     ConsoleKeyInfo tecla = Console.ReadKey(intercept: true);
//     opcao = tecla.KeyChar.ToString();

//     switch (opcao) {
//         case "1":
//             Console.WriteLine("\n[Cadastro de cliente]");
//             break;

//         case "2":
//             Console.WriteLine("\n[Busca de cliente]");
//             break;

//         case "3":
//             Console.WriteLine("\n[Apagar cliente]");
//             break;

//         case "4":
//             Console.WriteLine("\n[Encerrar]");
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("\n[Opção inválida]");
//             break;

//     }

//         if (opcao != "4") {
//             Console.WriteLine("Pressione qualquer tecla para continuar...");
//             Console.ReadKey(); //#ByChatGPT
//     }
// }

// Console.WriteLine("O programa se encerrou");










// int soma = 0, numero = 0;

// do {
//     Console.WriteLine("Digite um número (0 para)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
// } while (numero != 0);

// Console.WriteLine($"A soma total dos números é igual á {soma}");










// int numero = 5;
// int contador = 1;

// while (contador <= 10) {


//     Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6) {
//         break;
//     }
// }










// int numero = 5;

// for (int contador = 0; contador <= 10; contador++) {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }










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