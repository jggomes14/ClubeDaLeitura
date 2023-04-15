using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;
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
            RepositorioRevista repositorioRevista = new RepositorioRevista();
            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
            RepositorioAmigo repositorioAmigo = new RepositorioAmigo(); 
            RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
            
            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║         MENU PRINCIPAL           ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                Console.WriteLine("║ 1.  Gerenciar Revistas           ║");
                Console.WriteLine("║ 2.  Gerenciar Amigos             ║");
                Console.WriteLine("║ 3.  Gerenciar Caixas             ║");
                Console.WriteLine("║ 4.  Gerenciar Empréstimos        ║");
                Console.WriteLine("║ 0.  Sair do programa             ║");
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.Write("Digite a opção desejada: ");

                opcao = int.Parse(Console.ReadLine());



                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                        Console.WriteLine("╔══════════════════════════════════╗");
                        Console.WriteLine("║      GERENCIAMENTO DE REVISTAS   ║");
                        Console.WriteLine("╠══════════════════════════════════╣");
                        Console.WriteLine("║ 1. Cadastrar Revista             ║");
                        Console.WriteLine("║ 2. Visualizar Revistas           ║");
                        Console.WriteLine("║ 3. Editar Revista                ║");
                        Console.WriteLine("║ 4. Excluir Revista               ║");
                        Console.WriteLine("║ 0. Voltar ao menu principal      ║");
                        Console.WriteLine("╚══════════════════════════════════╝");
                        Console.Write("Digite a opção desejada: ");

                        int opcaoRevistas = int.Parse(Console.ReadLine());

                        switch (opcaoRevistas)
                        {
                            case 1:


                                Revista revista = new Revista();
                                Console.WriteLine("Qual o Id da revista?");
                                revista.id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Qual o titulo da revista?");
                                revista.titulo = Console.ReadLine();
                                Console.WriteLine("Qual o ano de publicação da revista?");
                                revista.ano = int.Parse(Console.ReadLine());
                                Console.WriteLine("Qual a coleção da Revista?");
                                revista.colecao = Console.ReadLine();
                                Console.WriteLine("Qual a Edição da Revista?");
                                revista.edicao = int.Parse(Console.ReadLine());
                                Console.WriteLine("Selecione o id da caixa");
                                int opcaodeselecao = int.Parse(Console.ReadLine());
                                revista.caixa = repositorioCaixa.SelecionarPorId(opcaodeselecao);

                               

                                repositorioRevista.Inserir(revista);


                                break;



                            case 2:
                                TelaRevista telaRevista = new TelaRevista();
                                telaRevista.repositorio = repositorioRevista;
                                telaRevista.MostrarRevistas();


                                Console.ReadKey();

                                break;

                            case 3:
                                Console.WriteLine("Insira o Id da Revista que você quer editar");
                                int idi = int.Parse(Console.ReadLine());
                                repositorioRevista.EditarRevista(idi);

                                break;

                            case 4:
                                Console.WriteLine("Insira o ID da Revista que você quer excluir");
                                int id = int.Parse(Console.ReadLine());
                                repositorioRevista.ExcluirRevista(id);


                                Console.ReadKey();

                                break;

                            case 0:
                                Console.WriteLine("Voltando ao Menu Principal");
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                Console.ReadKey();
                                break;

                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        Console.WriteLine("╔══════════════════════════════════╗");
                        Console.WriteLine("║      GERENCIAMENTO DE AMIGOS     ║");
                        Console.WriteLine("╠══════════════════════════════════╣");
                        Console.WriteLine("║ 1. Cadastrar amigo               ║");
                        Console.WriteLine("║ 2. Remover amigo                 ║");
                        Console.WriteLine("║ 3. Consultar amigo               ║");
                        Console.WriteLine("║ 4. Editar amigo                  ║");
                        Console.WriteLine("║ 0. Voltar ao menu principal      ║");
                        Console.WriteLine("╚══════════════════════════════════╝");
                        Console.Write("Digite a opção desejada: ");

                        int opcaoAmigo = int.Parse(Console.ReadLine());
                        switch (opcaoAmigo)
                        {
                            case 1:
                                Amigo amigo = new Amigo();
                                Console.WriteLine("Insira o id do Amigo");
                                amigo.id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Qual o Nome do Amigo?");
                                amigo.nome = Console.ReadLine();
                                Console.WriteLine("Qual o Nome do Responsavel do Amigo?");
                                amigo.nomeResponsavel = Console.ReadLine();
                                Console.WriteLine("Qual o número de Telefone do Amigo?");
                                amigo.telefone = Console.ReadLine();
                                Console.WriteLine("Qual o Endereço do Amigo?");
                                amigo.endereco = Console.ReadLine();
                                repositorioAmigo.Inserir(amigo);
                                break;

                            case 2:
                                Console.WriteLine("Insira o ID do Amigo que você quer excluir");
                                int id = int.Parse(Console.ReadLine());
                                repositorioAmigo.ExcluirAmigo(id);
                                Console.ReadKey();

                                break;

                            case 3:
                                Console.WriteLine("Insira o Id do Amigo que você quer editar");
                                int idi = int.Parse(Console.ReadLine());
                                repositorioAmigo.EditarAmigo(idi);
                                Console.ReadKey();
                                break;

                            case 4:
                                TelaAmigo telaAmigo = new TelaAmigo();
                                telaAmigo.repositorio = repositorioAmigo;
                                telaAmigo.MostrarAmigos();
                                Console.ReadKey();


                                break;

                            case 0:
                                Console.WriteLine("Voltando ao Menu Principal");
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                Console.ReadKey();
                                break;

                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                        Console.WriteLine("╔══════════════════════════════════════╗");
                        Console.WriteLine("║        GERENCIAMENTO DE CAIXAS       ║");
                        Console.WriteLine("╠══════════════════════════════════════╣");
                        Console.WriteLine("║ 1 - Adicionar Caixa                  ║");
                        Console.WriteLine("║ 2 - Remover Caixa                    ║");
                        Console.WriteLine("║ 3 - Editar Caixa                     ║");
                        Console.WriteLine("║ 4 - Lista de Caixa                   ║");
                        Console.WriteLine("║ 0 - Voltar ao menu principal         ║");
                        Console.WriteLine("╚══════════════════════════════════════╝");
                        Console.Write("Digite a opção desejada: ");

                        int opcaoCaixa = int.Parse(Console.ReadLine());
                        switch (opcaoCaixa)
                        {
                            case 1:
                                Caixa caixa = new Caixa();
                                Console.WriteLine("Insira o id da Caixa");
                                caixa.id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Insira a Etiqueta da Caixa");
                                caixa.etiqueta = Console.ReadLine();
                                Console.WriteLine("Qual a Cor da Caixa?");
                                caixa.cor = Console.ReadLine();
                                repositorioCaixa.Inserir(caixa);
                                break;

                            case 2:
                                Console.WriteLine("Insira o ID da Caixa que você quer excluir");
                                int id = int.Parse(Console.ReadLine());
                                repositorioCaixa.ExcluirCaixa(id);
                                Console.ReadKey();

                                break;

                            case 3:
                                Console.WriteLine("Insira o Id da Caixa que você quer editar");
                                int idi = int.Parse(Console.ReadLine());
                                repositorioCaixa.EditarCaixa(idi);
                                Console.ReadKey();


                                break;

                            case 4:
                                TelaCaixa telaCaixa = new TelaCaixa();
                                telaCaixa.repositorio = repositorioCaixa;
                                telaCaixa.MostrarCaixas();


                                Console.ReadKey();
                                break;
                           

                            case 0:
                                Console.WriteLine("Voltando ao Menu Principal");
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                Console.ReadKey();
                                break;

                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine("╔══════════════════════════════════════════╗");
                        Console.WriteLine("║      GERENCIAMENTO DE EMPRÉSTIMOS        ║");
                        Console.WriteLine("╠══════════════════════════════════════════╣");
                        Console.WriteLine("║ 1. Cadastrar Empréstimo                  ║");
                        Console.WriteLine("║ 2. Remover Empréstimo                    ║");
                        Console.WriteLine("║ 3. Consultar Empréstimo                  ║");
                        Console.WriteLine("║ 4. Devolver Empréstimo                   ║");
                        Console.WriteLine("║ 5. Editar Empréstimo                     ║");
                        Console.WriteLine("║ 0. Voltar ao menu principal              ║");
                        Console.WriteLine("╚══════════════════════════════════════════╝");
                        Console.Write("Digite a opção desejada: ");


                        int opcaoEmprestimo = int.Parse(Console.ReadLine());

                        switch (opcaoEmprestimo)
                        {
                            case 1:
                                break;

                            case 2:

                                break;

                            case 3:
                                break;

                            case 4:
                                break;
                            case 5:
                                break;

                            case 0:
                                Console.WriteLine("Voltando ao Menu Principal");
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                Console.ReadKey();
                                break;

                        }

                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 0);
        }


    }
}