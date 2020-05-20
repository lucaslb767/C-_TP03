using System;
using System.Net.Http;

namespace TP_03_lucas_barrozo_Csharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Repositorio repositorio = new Repositorio();
            inicial();
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 0)
            {
                switch (opcao)
                {
                    case 1:
                        mostrar(repositorio);
                        voltar();
                        break;
                    case 2:
                        

                        if (repositorio.listagemNotEmpty())
                        {
                            Console.WriteLine("Digite o nome: ");
                            String nome = Console.ReadLine();
                            repositorio.buscarNome(nome);
                            Console.WriteLine("Deseja ver algum dos nomes ?");
                            Console.WriteLine("1 - Sim");
                            Console.WriteLine("0 - Nao");
                            int opcao2 = int.Parse(Console.ReadLine());

                            if (opcao2 == 1)
                            {
                                Console.WriteLine("Escolha qual dos itens a seguir");
                                repositorio.listarBuscado();
                                int op = int.Parse(Console.ReadLine());

                                Console.WriteLine(repositorio.RetornaPessoa(op-1));
                            }
                        } else
                        {
                            Console.WriteLine("Lista de nomes vazia");
                        }
                        voltar();
                        break;

                    case 3:
                        Console.WriteLine("Digite o Nome da pessoa que deseja adicionar:");
                        String name = Console.ReadLine();
                        Console.WriteLine("Digite o Sobrenome");
                        String surname = Console.ReadLine();
                        Console.WriteLine("Digite o aniversario no formato dd/MM/yyyy");
                        String aniversario = Console.ReadLine();

                        var aniversario2 = aniversario.Split('/');

                        Pessoa pessoa = new Pessoa(name, surname, new DateTime(int.Parse(aniversario2[2]), int.Parse(aniversario2[1]), int.Parse(aniversario2[0])));

                        repositorio.adiciona(pessoa);
                        voltar();
                        break;

                    case 0:
                        Console.WriteLine("Até mais");
                        break;

                    default:
                        Console.WriteLine("Opcao nao encontrada. Por favor digitar uma opcao correta");
                        break;

                }

                inicial();
                opcao = int.Parse(Console.ReadLine());
            }
        }
        
         static void inicial()
        {
            Console.Clear();
            Console.WriteLine("Gerenciador de Aniversarios");
            Console.WriteLine("Selecione uma das opcoes abaixo:");
            Console.WriteLine("1 - Listar Pessoas Cadastradas");
            Console.WriteLine("2 - Pesquisar pessoas");
            Console.WriteLine("3 - Adicionar nova pessoa");
            Console.WriteLine("0 - Sair");
        }

        static void mostrar(Repositorio repositorio)
        {
            repositorio.listar();
        }

        static void voltar()
        {
            Console.WriteLine("Aperte enter para voltar");
            Console.ReadLine();
        }

    }
}
