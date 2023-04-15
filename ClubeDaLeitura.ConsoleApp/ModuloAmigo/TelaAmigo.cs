using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class TelaAmigo
    {
        public RepositorioAmigo repositorio = null;

        public void MostrarAmigos()
        {
            ArrayList amigos = repositorio.SelecionarTodos();
            foreach (Amigo a in amigos)
            {
                Console.WriteLine($"{a.id}, {a.nome}, {a.nomeResponsavel}, {a.endereco}, {a.telefone}");
            }

        }


    }
}