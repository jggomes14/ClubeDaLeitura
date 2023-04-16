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

        public Emprestimo SelecionarPorId(int id)
        {
            Emprestimo emprestimo = null;

            foreach (Emprestimo e in listaRegistros)
            {
                if (e.id == id)
                {
                    emprestimo = e;
                    break;
                }
            }

            return emprestimo;
        }

        public void RemoverEmprestimo(int id)
        {
            Emprestimo emprestimo = SelecionarPorId(id);

            if (emprestimo != null)
            {
                listaRegistros.Remove(emprestimo);
                Console.WriteLine("Empréstimo removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Empréstimo não encontrado!");
            }
        }

        public void EditarEmprestimo(int id)
        {
            Emprestimo emprestimo = SelecionarPorId(id);

            if (emprestimo != null)
            {
                Console.WriteLine("Editar empréstimo: ");
                Console.WriteLine("Digite a nova data de empréstimo:");
                emprestimo.dataDeEmprestimo = Console.ReadLine();
                Console.WriteLine("Digite a nova data de devolução:");
                emprestimo.dataDeDevolucao = Console.ReadLine();
                Console.WriteLine("Empréstimo editado com sucesso!");
            }
            else
            {
                Console.WriteLine("Empréstimo não encontrado!");
            }
        }
        public void DevolverEmprestimo(int id)
        {
            Emprestimo emprestimo = SelecionarPorId(id);

            if (emprestimo != null)
            {
                if (emprestimo.dataDeDevolucao != null)
                {
                    Console.WriteLine("Este empréstimo já foi devolvido.");
                }
                else
                {
                    Console.WriteLine("Digite a data de devolução (dd/MM/yyyy):");
                    string dataDevolucao = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(dataDevolucao))
                    {
                        Console.WriteLine("Data inválida. O empréstimo não foi devolvido.");
                    }
                    else
                    {
                        emprestimo.dataDeDevolucao = dataDevolucao;
                        Console.WriteLine("Empréstimo devolvido com sucesso!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Empréstimo não encontrado!");
            }
        }

    }

}