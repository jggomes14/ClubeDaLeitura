using ClubeDaLeitura.ConsoleApp.Compartilhado;
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
    }
}