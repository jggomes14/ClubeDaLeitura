using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    public class RepositorioEmprestimo : RepositorioMae
    {
        public void Inserir(Emprestimo emprestimo)
        {
            listaRegistros.Add(emprestimo);
        }

        internal ArrayList SelecionarTodos()
        {
            return listaRegistros;
        }


    }
}