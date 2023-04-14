using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class RepositorioRevista : RepositorioMae
    {
        public void Inserir(Revista revista)
        {
            listaRegistros.Add(revista);
        }

        internal ArrayList SelecionarTodos()
        {
            return listaRegistros;
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