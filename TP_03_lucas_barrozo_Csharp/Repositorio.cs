using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TP_03_lucas_barrozo_Csharp
{
    class Repositorio
    {
        List<Pessoa> Listagem = new List<Pessoa>();
        List<Pessoa> Buscados = new List<Pessoa>();

        public void adiciona(Pessoa pessoa)
        {
            Listagem.Add(pessoa);
        }

        public void buscarNome (String nome)
        {
            Console.WriteLine("Resultado da Busca");
            foreach (Pessoa pessoa in Listagem)
            {
                if(pessoa.Nome.Contains(nome) || pessoa.SobreNome.Contains(nome))
                {
                    Buscados.Add(pessoa);
                    Console.WriteLine(pessoa.Nome +" "+pessoa.SobreNome);
                }
            }
        }

        public void listar()
        {
            Console.WriteLine("Pessoas cadastradas: ");
            foreach (Pessoa pessoa in Listagem)
            {
                Console.WriteLine(pessoa.Nome + " " + pessoa.SobreNome);
            }
        }

        public bool listagemNotEmpty()
        {
            bool answer;
            
            if(Listagem.Count != 0)
            {
                answer = true;
            } else
            {
                answer = false;
            }

            return answer;
        }

        public void listarBuscado()
        {
            int a = 1;
            Console.WriteLine("Pessoas buscadas: ");
            foreach(Pessoa pessoa in Buscados)
            {
                Console.WriteLine($"{a} - {pessoa.Nome} {pessoa.SobreNome}");
                a++;
            }
        }

        public bool BuscadosNotEmpty()
        {
            bool answer;

            if (Buscados.Count != 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }

        public String RetornaPessoa(int index)
        {
            return $"{Buscados[index].Nome} {Buscados[index].SobreNome} - Faltam {Buscados[index].CalculaNiver()} dias para o seu aniversário!";
        }
    }
}
