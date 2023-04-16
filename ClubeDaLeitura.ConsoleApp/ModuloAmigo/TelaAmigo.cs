using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class TelaAmigo
    {
        public RepositorioAmigo repositorio = null;

        public void MostrarAmigos()
        {
            ArrayList amigos = repositorio.SelecionarTodos();

            if (amigos.Count == 0)
            {
                Console.WriteLine("Não existem amigos cadastrados.");
            }
            else
            {
                
                Console.WriteLine("ID\tNome\tNome do Responsável\tEndereço\tTelefone");

                
                Console.WriteLine("===================================================");

                
                foreach (Amigo a in amigos)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", a.id, a.nome, a.nomeResponsavel, a.endereco, a.telefone);
                }
            }
        }



    }
}