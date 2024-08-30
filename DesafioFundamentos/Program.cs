using DesafioFundamentos.Models;

Estacionamento execucao = new Estacionamento();

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");

Console.WriteLine("Digite o preço inicial: ");
double preco_inicial = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor da hora: ");
double valor_hora = Convert.ToDouble(Console.ReadLine());

execucao.Programa(preco_inicial, valor_hora);
