using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class RepositorioAmigo : RepositorioMae
    {
        public void Inserir(Amigo amigo)
        {
            listaRegistros.Add(amigo);
        }

        internal ArrayList SelecionarTodos()
        {
            return listaRegistros;
        }
        public Amigo SelecionarPorId(int id)
        {
            Amigo amigo = null;

            foreach (Amigo a in listaRegistros)
            {
                if (a.id == id)
                {
                    amigo = a;
                    break;
                }
            }

            return amigo;
        }
        public void ExcluirAmigo(int id)
        {
            Amigo amigo = SelecionarPorId(id);

            if (amigo != null)
            {
                listaRegistros.Remove(amigo);
                Console.WriteLine("Amigo excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("Amigo não encontrado!");
            }
        }


        public void EditarAmigo(int id)
        {
            Amigo amigo = SelecionarPorId(id);

            if (amigo != null)
            {
                Console.WriteLine("Editar amigo: " + amigo.nome);
                Console.WriteLine("Digite o novo nome do amigo:");
                amigo.nome = Console.ReadLine();
                Console.WriteLine("Digite o novo nome do responsável:");
                amigo.nomeResponsavel = Console.ReadLine();
                Console.WriteLine("Digite o novo endereço do amigo:");
                amigo.endereco = Console.ReadLine();
                Console.WriteLine("Amigo editado com sucesso!");
            }
            else
            {
                Console.WriteLine("Amigo não encontrado!");
            }
        }
        public Amigo SelecionarPorNome(string nome)
        {
            Amigo amigo = null;

            foreach (Amigo a in listaRegistros)
            {
                if (a.nome.ToLower() == nome.ToLower())
                {
                    amigo = a;
                    break;
                }
            }

            return amigo;
        }







    }


}