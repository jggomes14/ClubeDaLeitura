using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class TelaCaixa
    {
        public RepositorioCaixa repositorio = null;

        public void MostrarCaixas()
        {
            ArrayList caixas = repositorio.SelecionarTodos();

            if (caixas.Count == 0)
            {
                Console.WriteLine("Não existem caixas cadastradas.");
            }
            else
            {
                foreach (Caixa caixa in caixas)
                {
                    Console.WriteLine(caixa.id + ", "
                        + caixa.cor + ", " + caixa.etiqueta);
                }
            }
        }

    }
}