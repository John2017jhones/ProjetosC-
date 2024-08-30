using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesafioFundamentos.Models
{
    public class Estacionamento {
         public void Programa(double preco_inicial, double valor_hora) {
             List <string> placasregistradas = new List<string>();
            

             while(true) {
                 Console.WriteLine("Digite a sua opção:\n1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículos\n4 - Encerrar");
                 string opcao = Console.ReadLine();

                if (opcao=="1") {
                    Console.WriteLine("Digite a placa do veículo para estacionar: ");
                    string placa = Console.ReadLine();
                    
                    placasregistradas.Add(placa);
                    
                    Console.WriteLine("Digite uma tecla pra continuar");
                    Console.ReadKey();
                    }

                else if (opcao=="2") {
                        Console.WriteLine("Digite o veículo que deseja remover");
                        string remover_veiculo = Console.ReadLine();

                        placasregistradas.Remove(remover_veiculo);
                        
                        Console.WriteLine("Quantas horas o veículo permaneceu no estacionamento: ");
                        double horas_permanecida = Convert.ToDouble(Console.ReadLine());

                        double calculo_total = preco_inicial+(valor_hora*horas_permanecida); 
                        
                        Console.WriteLine($"O veículo {remover_veiculo} foi removido e o preço total foi de R${calculo_total}");

                        Console.WriteLine("Digite uma tecla pra continuar");
                        Console.ReadKey();  
                        }

                else if (opcao=="3") {
                    foreach (string lista in placasregistradas) {
                    Console.WriteLine(lista);
                    }
                    
                    Console.WriteLine("Digite uma tecla pra continuar");
                    Console.ReadKey();
                }

                else if (opcao=="4") {
                    Console.WriteLine("O programa foi finalizado!");
                    break;
                    }

                else {
                    Console.WriteLine("Opção inválida!");
                    }
                 }
             }
        
        }
    }