using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp
{
    // modelo tres camadas :

    /* Apresentação
     * 
     *  Telas:
     *      -TelaCaixa
     */

    /* Dados
     * 
     *  Repositórios:
     *  
     *      -RepositorioCaixa
     */

    /* Negocio
     * 
     *  Entidades:
     *  
     *      -Caixa
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa caixa = new Caixa();
            caixa.id = 1;
            caixa.etiqueta = "abc-123";
            caixa.cor = "vermelha";

            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
            repositorioCaixa.Inserir(caixa);

            TelaCaixa telaCaixa = new TelaCaixa();
            telaCaixa.repositorio = repositorioCaixa;

            telaCaixa.MostrarCaixas();

            Revista revista = new Revista();
            revista.id = 1;
            revista.titulo = "As aventuras de superman";
            revista.ano = 2023;
            revista.caixa = repositorioCaixa.SelecionarPorId(1);

            RepositorioRevista repositorioRevista = new RepositorioRevista();
            repositorioRevista.Inserir(revista);

            TelaRevista telaRevista = new TelaRevista();
            telaRevista.repositorio = repositorioRevista;
            telaRevista.MostrarRevistas();

            Console.ReadLine();
        }
    }

    #region 

    //Program - Arquivo 01
    //Cadastro de Equipamento - Arquivo 02

    //6 listas - reduzir e 1 lista utilizando Objetos Classe Equipamento

    // Classe Equipamento - Arquivo 03

    // Interação com usuário e também cuidava do armazenamento da informções de equjipamento

    // Classe TelaEquipamento - Arquivo 04

    // Classe RepositorioEquipamento - Arquivo 05

    // Toda a comunidade de desenvolvedores de software, utilizam este padrão: Tela, Dados, Negocio - 3 camadas

    //Cadastro de Chamado - Arquivo 06

    //6 listas - reduzir e 1 lista utilizando Objetos Classe Chamado

    #endregion
}