using System.Collections;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("----- Menu de opções -----");
                Console.WriteLine("1 - Gerenciar Revistas");
                Console.WriteLine("2 - Gerenciar Amigos");
                Console.WriteLine("3 - Gerenciar Caixas");
                Console.WriteLine("4 - Gerenciar Empréstimos");
                Console.WriteLine("0 - Sair do programa");
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("----- Gerenciamento de Revistas -----");
                        Console.WriteLine("1 - Cadastrar Revista");
                        Console.WriteLine("2 - Visualizar Revistas");
                        Console.WriteLine("3 - Editar Revista");
                        Console.WriteLine("4 - Excluir Revista");
                        Console.WriteLine("0 - Voltar ao menu principal");
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

                                RepositorioRevista repositorioRevista = new RepositorioRevista();

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
                        Console.WriteLine("Gerenciamento de Amigos:");
                        Console.WriteLine("1 - Cadastrar amigo");
                        Console.WriteLine("2 - Remover amigo");
                        Console.WriteLine("3 - Consultar amigo");
                        Console.WriteLine("4 - Voltar");

                        Console.Write("Digite uma opção: ");
                        int opcaoAmigo = int.Parse(Console.ReadLine());
                        switch (opcaoAmigo)
                        {
                            case 1:
                                break;

                            case 2:

                                break;

                            case 3:
                                break;

                            case 4:
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
                        Console.WriteLine("Escolha uma opção:");
                        Console.WriteLine("1 - Adicionar Caixa");
                        Console.WriteLine("2 - Remover Caixa");
                        Console.WriteLine("3 - Verificar Etiqueta");
                        Console.WriteLine("4 - Obter Caixa");
                        Console.WriteLine("0 - Voltar");

                        int opcaoCaixa = int.Parse(Console.ReadLine());
                        switch (opcaoCaixa)
                        {
                            case 1:
                                break;

                            case 2:

                                break;

                            case 3:
                                break;

                            case 4:
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
                        Console.WriteLine("Escolha uma opção:");
                        Console.WriteLine("1 - Cadastrar Empréstimo");
                        Console.WriteLine("2 - Devolver Empréstimo");
                        Console.WriteLine("3 - Consultar Empréstimo");
                        Console.WriteLine("0 - Voltar");

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