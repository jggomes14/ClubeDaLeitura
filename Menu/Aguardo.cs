using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Aguardo
    {
        Caixa caixa = new Caixa();
        caixa.id = 1;
            caixa.etiqueta = "Esportes";
            caixa.cor = "Azul";

            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
        repositorioCaixa.Inserir(caixa);

            TelaCaixa telaCaixa = new TelaCaixa();
        telaCaixa.repositorio = repositorioCaixa;

            telaCaixa.MostrarCaixas();

            Revista revista = new Revista();
        revista.id = 1;
            revista.titulo = "Placar";
            revista.ano = 2023;
            revista.colecao = "Abril";
            revista.edicao = 1;
            revista.caixa = repositorioCaixa.SelecionarPorId(1);

            RepositorioRevista repositorioRevista = new RepositorioRevista();
        repositorioRevista.Inserir(revista);

            TelaRevista telaRevista = new TelaRevista();
        telaRevista.repositorio = repositorioRevista;
            telaRevista.MostrarRevistas();

            Amigo amigo = new Amigo();
        amigo.id = 1;
            amigo.nome = "João";
            amigo.nomeResponsavel = "Rose";
            amigo.endereco = "Rua Visconde de Taunay, N 420";
            amigo.telefone = "(61) 98258-4084";

            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
        repositorioAmigo.Inserir(amigo);

            TelaAmigo telaAmigo = new TelaAmigo();
        telaAmigo.repositorio = repositorioAmigo;
            telaAmigo.MostrarAmigos();

            Emprestimo emprestimo = new Emprestimo();
        emprestimo.amigo = repositorioAmigo.SelecionarPorId(1);
            emprestimo.revista = repositorioRevista.SelecionarPorId(1);
            emprestimo.dataDeEmprestimo = "12/04/2023";
            emprestimo.dataDeDevolucao = "14/04/2023";

            RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
        repositorioEmprestimo.Inserir(emprestimo);

            TelaEmprestimo telaEmprestimo = new TelaEmprestimo();
        telaEmprestimo.repositorio = repositorioEmprestimo;
            telaEmprestimo.MostrarEmprestimos();



            Console.ReadKey();
        }
}