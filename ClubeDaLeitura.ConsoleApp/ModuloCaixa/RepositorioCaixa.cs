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
    }
}