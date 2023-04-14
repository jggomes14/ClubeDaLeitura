﻿using System.Collections;

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