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

            foreach (Revista r in revistas)
            {
                Console.WriteLine(r.id + ", " + r.titulo + ", " + r.edicao + ", " + r.ano + ", " + r.colecao + ", " + r.caixa.etiqueta);
            }
        }



    }
}