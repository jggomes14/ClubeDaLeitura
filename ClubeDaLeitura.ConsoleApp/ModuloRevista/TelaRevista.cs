using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class TelaRevista
    {
        public RepositorioRevista repositorio = null;

        public void MostrarRevistas()
        {
            ArrayList revistas = repositorio.SelecionarTodos();

            if (revistas.Count == 0)
            {
                Console.WriteLine("Não existem revistas cadastradas.");
            }
            else
            {
                
                Console.WriteLine("ID\tTítulo\tEdição\tAno\tColeção\tEtiqueta da Caixa");

                
                Console.WriteLine("===============================================================");

                
                foreach (Revista r in revistas)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", r.id, r.titulo, r.edicao, r.ano, r.colecao, r.caixa.etiqueta);
                }
            }
        }




    }
}