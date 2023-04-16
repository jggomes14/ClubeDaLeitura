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
                
                Console.WriteLine("ID\tCor\tEtiqueta");

                
                Console.WriteLine("===========================");

                // Dados das caixas
                foreach (Caixa caixa in caixas)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", caixa.id, caixa.cor, caixa.etiqueta);
                }
            }
        }


    }
}