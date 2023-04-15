using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using System.Collections;


namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class RepositorioRevista : RepositorioMae
    {
        

        
        public void Inserir(Revista revista)
        {
            listaRegistros.Add(revista);
        }

        internal ArrayList SelecionarTodos()
        {
            return listaRegistros;
        }
        public Revista SelecionarPorId(int id)
        {
            Revista revista = null;

            foreach (Revista r in listaRegistros)
            {
                if (r.id == id)
                {
                    revista = r;
                    break;
                }
            }

            return revista;
        }
        public void ExcluirRevista(int id)
        {
            Revista revista = SelecionarPorId(id);

            if (revista != null)
            {
                listaRegistros.Remove(revista);
                Console.WriteLine("Revista excluída com sucesso!");
            }
            else
            {
                Console.WriteLine("Revista não encontrada!");
            }
        }
        public void EditarRevista(int id)
        {
            Revista revista = SelecionarPorId(id);

            if (revista != null)
            {
                Console.WriteLine("Editar revista: " + revista.titulo);
                Console.WriteLine("Digite o novo título da revista:");
                revista.titulo = Console.ReadLine();
                Console.WriteLine("Digite o novo ano de publicação da revista:");
                revista.ano = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nova coleção da revista:");
                revista.colecao = Console.ReadLine();
                Console.WriteLine("Digite a nova edição da revista:");
                revista.edicao = int.Parse(Console.ReadLine());
                Console.WriteLine("Revista editada com sucesso!");
            }
            else
            {
                Console.WriteLine("Revista não encontrada!");
            }
        }





    }
}