using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Sistema_de_Gestão_de_Tarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prioridade = new int[5];
            string[] tarefas = new string[5];
    

            while(true)
            {
                Console.WriteLine("Escolha a uma opção");
                Console.WriteLine("A - adiconar tarefa");
                Console.WriteLine("L - listar tarefa");
                Console.WriteLine("E - excluir tarefa");
                Console.WriteLine("F - fechar o programa");

                var escolha = Console.ReadLine();
                Console.Clear();
                if (escolha.ToUpper() == "A")
                {
                   

                    for (int i = 0; i < prioridade.Length; i++)
                    {
                        Console.WriteLine("Adicione sua Tarefa: ");
                        tarefas[i] = Console.ReadLine();

                        Console.WriteLine("Digite a prioridade da tarefa (1 a 5): ");
                        prioridade[i] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Tarefa adicionada!!");
                        return;
                    }
                }
                else if (escolha.ToUpper() == "L")
                {

                }
                else if (escolha.ToUpper() == "E")
                {

                }
                else if(escolha.ToUpper() == "F")
                {
                    break;
                }
            }

            
           

        }
    }
}
