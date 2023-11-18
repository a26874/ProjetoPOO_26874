using Assistencia;
using FrontEnd;
using Outros;
using Pessoas;
using System;


namespace ProjetoPOO_26874
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array de registo Assistencias, Clientes, Operadores, produtos 
            RegistoAssist listaAssist = new RegistoAssist();
            RegistoClientes listaClientes = new RegistoClientes();
            RegistoOperadores listaOperadores = new RegistoOperadores();
            RegistoProdutos listaProdutos = new RegistoProdutos();


            //Nova assistencias
            Assist a1 = new Assist(DateTime.Now, new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a2 = new Assist(DateTime.Now, new TipoAssist("Informacao entrega Produto", "Entregas", 2, 345), new EstadoAssist("Ativo", true), 1759, 12);
            Assist a3 = new Assist(DateTime.Now, new TipoAssist("Encomendas de produtos", "Entregas", 2, 255), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a4 = new Assist(DateTime.Now, new TipoAssist("Servico Manutencao", "Assistencia", 4, 1000), new EstadoAssist("Ativo", true), 1676, 12);

            //Criação de um novo cliente
            Cliente c1 = new Cliente("Marco", 94829, new Moradas("Braga", "4720-452", "Amares"), 1874);
            Cliente c2 = new Cliente("Ruben", 9421474, new Moradas("Braga", "4122-862", "VilaVerde"), 1676);
            Cliente c3 = new Cliente("Andre", 94, new Moradas("Braga", "4000-221", "Barcelos"), 1266);
            Cliente c4 = new Cliente("Macedo", 274, new Moradas("Porto", "4218-211", "Arouca"), 1759);
            Cliente c5 = new Cliente("Nuno", 974, new Moradas("Porto", "4117-222", "Espinho"), 1911);
            Cliente c6 = new Cliente("Flavia", 244, new Moradas("Porto", "478-222", "Arcos"), 1898);

            //Inserir clientes na array listaClientes
   
            listaClientes.InsereCliente(c1);
            listaClientes.InsereCliente(c2);        
            listaClientes.InsereCliente(c3);
            listaClientes.InsereCliente(c4);
            listaClientes.InsereCliente(c5);
            listaClientes.InsereCliente(c6);

            //Criar novos operadores
            Operador op1 = new Operador("Marco", 12, 2487, new Moradas("Braga", "4720-444", "Amares"));
            Operador op2 = new Operador("Joao", 2, 2222, new Moradas("Braga", "4700-124", "VilaVerde"));
            Operador op3 = new Operador("Goncalo", 34, 2444, new Moradas("Porto", "4262-244", "Arouca"));
            Operador op4 = new Operador("Rui", 14, 11123, new Moradas("Braga", "4991-242", "VilaVerde"));
            Operador op5 = new Operador("Luis", 25, 2444, new Moradas("Porto", "4221-112", "Arouca"));
            Operador op6 = new Operador("Diogo", 6, 4959, new Moradas("Braga", "4872-111", "Barcelos"));

            int numeroOperadores = listaOperadores.NumeroOperadoresExistentes();

            //Inserir operadores.
            listaOperadores.InserirOperador(op1);
            listaOperadores.InserirOperador(op2);
            listaOperadores.InserirOperador(op3);
            listaOperadores.InserirOperador(op4);
            listaOperadores.InserirOperador(op5);
            //bool teste2 = listaOperadores.InserirOperador(op6);



            //Print de cada array
            Console.WriteLine("Operadores:");
            //Operadores
            IO.MostrarOperadores(listaOperadores);

            Console.WriteLine("Clientes");
            //Clientes
            IO.MostrarClientes(listaClientes);

            bool resultadoClientes = listaClientes.RemoverClienteEspecifico(new Cliente("teste", 9191, new Moradas("asd", "asdad", "asdasda"), 82748));
            bool resultadoClientes2 = listaClientes.RemoverClienteEspecifico(c3);
            Console.WriteLine(resultadoClientes);
            Console.WriteLine(resultadoClientes2);
            Console.WriteLine("Clientes removidos");
            //Clientes removidos
            IO.MostrarClientes(listaClientes);

            bool resultadoOperador = listaOperadores.RemoverOperadorEspecifico(new Operador("teste", 187, 9888, new Moradas("asda", "qwdq", "awsdd")));
            bool resultadoOperador2 = listaOperadores.RemoverOperadorEspecifico(op2);
            Console.WriteLine(resultadoOperador);
            Console.WriteLine(resultadoOperador2);
            Console.WriteLine("Operadores removidos");
            //Operadores removidos
            IO.MostrarOperadores(listaOperadores);

            //Produtos
            RegistoCategorias listaCategoriasProd1 = new RegistoCategorias();
            listaCategoriasProd1.InserirCategoria("SMARTPHONE");
            listaCategoriasProd1.InserirCategoria("5G");
            Produto prdt1 = new Produto("Telemovel", 1, 2000, "SAMSUNG", listaCategoriasProd1.ObterCategorias);


            listaProdutos.InserirProduto(prdt1);

            Console.WriteLine("teste....");
            IO.MostrarProdutos(listaProdutos);

            //BubbleSortClientes
            listaClientes.BubbleSortClientes();
            Console.WriteLine("Ordenado por NIF");
            IO.MostrarClientes(listaClientes);


            //BubbleSortOperadores
            listaOperadores.BubbleSortOperadores();
            Console.WriteLine("Ordenado por ID");
            IO.MostrarOperadores(listaOperadores);


            //Inserir nova assistencia;
            listaAssist.InsereAssist(listaOperadores.ObterOperadores, listaClientes.ObterClientes, a1);
            listaAssist.InsereAssist(listaOperadores.ObterOperadores, listaClientes.ObterClientes, a2);
            listaAssist.InsereAssist(listaOperadores.ObterOperadores, listaClientes.ObterClientes, a3);
            listaAssist.InsereAssist(listaOperadores.ObterOperadores, listaClientes.ObterClientes, a4);
            //Assistencias
            Console.WriteLine();
            Console.WriteLine("Assistencias:");
            IO.MostrarAssistencias(listaAssist);


            int resultado = IO.MostrarAssistenciaMaisCara(listaAssist);
            Console.WriteLine(resultado);
            int assistenciasRea = listaAssist.MostrarAssistenciasRealizadas();
            Console.WriteLine(assistenciasRea);
            listaAssist.ConcluirAssistencia(a4);
            assistenciasRea = listaAssist.MostrarAssistenciasRealizadas();
            Console.WriteLine(assistenciasRea);
            Console.WriteLine(numeroOperadores);
            listaOperadores.RemoverOperadores();
            numeroOperadores = listaOperadores.NumeroOperadoresExistentes();
            Console.WriteLine("operadores:{0}",numeroOperadores);
        }

    }
}
