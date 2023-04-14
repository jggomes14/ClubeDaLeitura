using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class TelaRevista
    {
        public RepositorioRevista repositorio = null;

        public void MostrarRevistas()
        {
            ArrayList revistas = repositorio.SelecionarTodos();

            foreach (Revista r in revistas)
            {
                Console.WriteLine(r.id + ", " + r.titulo + ", " + r.caixa.etiqueta);
            }
        }
    }   
}