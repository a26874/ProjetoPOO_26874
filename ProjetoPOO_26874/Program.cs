﻿using Assistencia;
using System;
using EstadoAssistencia;
using TipoAssistencia;
using Produtos;
using RegistoAssistencias;
using Pessoas;

namespace ProjetoPOO_26874
{
    internal class Program
    {
        const int MAXCLIENTES = 10;
        static void Main(string[] args)
        {
            //Array de registo Clientes, Operadores;
            RegistoAssist listaAssist = new RegistoAssist();
            RegistoClientes listaClientes = new RegistoClientes();
            RegistoOperadores listaOperadores = new RegistoOperadores();

            //Nova assistencias
            Assist a1 = new Assist(1, DateTime.Now);
            Assist a2 = new Assist(2, DateTime.Now);
            Assist a3 = new Assist(1, DateTime.Now, new TipoAssist("Esclarecimento", "Atendimento", 2, 500), new EstadoAssist("Ativo", true), 1, 1);
            a1.ClienteId = 1;
            a1.OperadorId = 1;
            a2.tipoAssis = new TipoAssist();
            a2.estadoA = new EstadoAssist();


            //Tipo assistencias
            TipoAssist descAssist1 = new TipoAssist();
            descAssist1.Desc = "Realizada Chamada para resolucao problemas";
            descAssist1.NomeTipo = "Telefone/Telemovel";
            descAssist1.Id = 1;
            descAssist1.Preco = 20000;
            a1.tipoAssis = descAssist1;





            //Estado Assistencias
            EstadoAssist estado1 = new EstadoAssist();
            estado1.Ativo = true;
            estado1.DescEstado = "Ainda objetivos para realizar.";
            a1.estadoA = estado1;

            //Inserir nova assistencia;
            listaAssist.InsereAssist(a3);


            //Criação de um novo cliente
            Cliente c1 = new Cliente("aaaa", 94829, new Moradas("Braga", "dsad", "4444-444"), 2498289);
            Cliente c2 = new Cliente("Marco", 9421474, new Moradas("asd", "222", "Braga"), 284719);
            Cliente c3 = new Cliente("aadasd", 94, new Moradas("fdkk", "4718-22", "Braga"), 2424);
            Cliente c4 = new Cliente("ascxzc", 274, new Moradas("zcxc", "4718-2", "Braga"), 219);
            Cliente c5 = new Cliente("cxzv", 974, new Moradas("lk", "47-222", "Braga"), 29);
            Cliente c6 = new Cliente("Mo", 244, new Moradas("zxc", "478-222", "Braga"), 2119);

            //Inserir clientes na array listaClientes
            listaClientes.InsereCliente(c1);
            listaClientes.InsereCliente(c2);
            listaClientes.InsereCliente(c3);
            listaClientes.InsereCliente(c4);
            listaClientes.InsereCliente(c5);
            listaClientes.InsereCliente(c6);

            //Criar novos operadores
            Operador op1 = new Operador("Marco", 1, 2487);
            Operador op2 = new Operador("asd", 2, 2222);
            Operador op3 = new Operador("Mar", 3, 2444);
            Operador op4 = new Operador("Mao", 4, 11123);
            Operador op5 = new Operador("Maco", 5, 2444);
            Operador op6 = new Operador("arco", 6, 4959);

            //Inserir operadores.
            listaOperadores.InserirOperador(op1);
            listaOperadores.InserirOperador(op2);
            listaOperadores.InserirOperador(op3);
            listaOperadores.InserirOperador(op4);
            listaOperadores.InserirOperador(op5);
            //bool teste2 = listaOperadores.InserirOperador(op6);



            //Print de cada array

            //Assistencias
            Console.WriteLine("Assistencias:");
            foreach (Assist a in listaAssist.TodasAssistencias)
            {
                if (a.Id == -1)
                    continue;
                Console.WriteLine(a.ToString());
            }

            Console.WriteLine("Operadores:");
            //Operadores
            foreach (Operador o in listaOperadores.ObterOperadores)
            {
                if (o.Id == -1)
                    continue;
                Console.WriteLine(o.ToString());
            }

            Console.WriteLine("Clientes");
            //Clientes
            foreach (Cliente c in listaClientes.ObterClientes)
            {
                if (c.NIF == -1)
                    continue;
                Console.WriteLine(c.ToString());
            }
            //Produtos
            Produto prdt1 = new Produto("Telemovel", 1, 2000, "SAMSUNG");

        }
    }
}
