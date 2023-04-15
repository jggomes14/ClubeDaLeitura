using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class RepositorioCaixa : RepositorioMae
    {
        public ArrayList SelecionarTodos()
        {
            ArrayList listaOrdenadaPelaCor = OrdenarLista();

            return listaOrdenadaPelaCor;
        }

        public void Inserir(Caixa caixa)
        {
            listaRegistros.Add(caixa);
        }

        private ArrayList OrdenarLista()
        {
            return listaRegistros;
        }

        public Caixa SelecionarPorId(int id)
        {
            Caixa caixa = null;

            foreach (Caixa c in listaRegistros)
            {
                if (c.id == id)
                {
                    caixa = c;
                    break;
                }
            }

            return caixa;
        }
        public void EditarCaixa(int id)
        {
            Caixa caixa = SelecionarPorId(id);

            if (caixa != null)
            {
                Console.WriteLine("Editar caixa: " + caixa.etiqueta);
                Console.WriteLine("Digite a nova etiqueta da caixa:");
                caixa.etiqueta = Console.ReadLine();
                Console.WriteLine("Digite a nova cor da caixa:");
                caixa.cor = Console.ReadLine();
                Console.WriteLine("Caixa editada com sucesso!");
            }
            else
            {
                Console.WriteLine("Caixa não encontrada!");
            }
        }
        public void ExcluirCaixa(int id)
        {
            Caixa caixa = SelecionarPorId(id);

            if (caixa != null)
            {
                listaRegistros.Remove(caixa);
                Console.WriteLine("Caixa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Caixa não encontrada!");
            }
        }


    }
}