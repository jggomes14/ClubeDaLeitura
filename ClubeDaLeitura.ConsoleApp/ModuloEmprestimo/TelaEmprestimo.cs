using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    public class TelaEmprestimo
    {
        public RepositorioEmprestimo repositorio = null;

        public void MostrarEmprestimos()
        {
            ArrayList emprestimos = repositorio.SelecionarTodos();

            if (emprestimos.Count == 0)
            {
                Console.WriteLine("Não existem empréstimos cadastrados.");
            }
            else
            {
                
                Console.WriteLine("Título da Revista\tNome do Amigo\tData de Empréstimo\tStatus");

                
                Console.WriteLine("===================================================================================");

                
                foreach (Emprestimo e in emprestimos)
                {
                    string status;
                    if (e.dataDeDevolucao == null)
                    {
                        status = "Não devolvido";
                    }
                    else
                    {
                        status = "Devolvido";
                    }

                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.revista.titulo, e.amigo.nome, e.dataDeEmprestimo, status);
                }
            }
        }


    }
}