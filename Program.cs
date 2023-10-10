using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            Console.WriteLine("Digite o tamanho da fila: ");
            int tamanho = int.Parse(Console.ReadLine());

            Fila fila = new Fila(tamanho);

            while(opcao != 4)
            {
                Console.WriteLine("MENU\n1) Inserir arquivo na fila de impressão\n2) Executar impressão\n3) Exibir fila de impressão\n4) Sair\nDigite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do arquivo: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o numero de paginas: ");
                        int numeroPaginas = int.Parse(Console.ReadLine());

                        Arquivo arquivo = new Arquivo(nome, numeroPaginas);

                        fila.Inserir(arquivo);
                        break;
                    case 2:
                        Console.WriteLine("Arquivo " + fila.Remover() + " encaminhado para impressão.");
                        break;
                    case 3:
                        Console.WriteLine("Fila:");
                        fila.Mostrar();
                        break;
                    case 4:
                        Console.WriteLine("FIM");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }
        }
    }
}
