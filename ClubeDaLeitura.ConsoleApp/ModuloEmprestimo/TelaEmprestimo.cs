using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    public class TelaEmprestimo
    {
        public RepositorioEmprestimo repositorio = null;

        public void MostrarEmprestimos()
        {
            ArrayList emprestimos = repositorio.SelecionarTodos();
            foreach (Emprestimo e in emprestimos)
            {
                Console.WriteLine($"{e.revista.titulo}, {e.amigo.nome}, {e.dataDeEmprestimo}, {e.dataDeDevolucao}");
            }

        }
    }
}