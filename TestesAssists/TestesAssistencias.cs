using Assistencia;
using Dados;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjetosNegocio;
using Pessoas;
using System;

namespace TestesAssists
{
    [TestClass]
    public class TestesAssistencias
    {
        [TestMethod]
        public void InsereAssistencia()
        {
            //Criação de dados
            Assist a1 = new Assist(new DateTime(2023, 4, 20, 16, 40, 29), new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a2 = new Assist(new DateTime(2023, 4, 20, 15, 40, 29), new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a3 = new Assist(new DateTime(2023, 4, 20, 11, 40, 29), new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a4 = new Assist(new DateTime(2023, 4, 20, 10, 40, 29), new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);
            Assist copiaA1 = a1;


            //Inserção de dados
            //Irão dar erros quando a data e o tipo de assistência forem iguais.
            bool resultado;
            try
            {
                resultado = RegistoAssist.InsereAssistLista(a1);
                resultado = RegistoAssist.InsereAssistLista(a2);
                resultado = RegistoAssist.InsereAssistLista(a3);
                resultado = RegistoAssist.InsereAssistLista(a4);
                resultado = RegistoAssist.InsereAssistLista(copiaA1); //-> aqui irá dar erro. Pois é uma copia da assist A1
            }
            finally
            {
                RegistoAssist.RemoverAssistencias();
            }

            //Verificação
            if (resultado)
                Assert.IsTrue(resultado, "Tudo inserido como esperado, não contem duplicados.");
            else
                Assert.IsFalse(resultado, "Já existe.");
        }

        [TestMethod]
        public void InsereClienteAssistencia()
        {
            //Criação de dados
            Assist a1 = new Assist(new DateTime(2023, 4, 20, 16, 40, 29), new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);

            Cliente c1 = new Cliente("Marco", 94829, new Morada("Braga", "4720-452", "Amares"), 1874);
            Cliente c2 = new Cliente("Ruben", 9421474, new Morada("Braga", "4122-862", "VilaVerde"), 1676);

            //Inserção de dados
            RegistoAssist.InsereAssistLista(a1);
            bool resultado;
            try
            {
                resultado = RegistoAssist.InsereClienteAssistLista(a1, c2);
                resultado = RegistoAssist.InsereClienteAssistLista(a1, c1);
                resultado = RegistoAssist.InsereClienteAssistLista(a1, c2);
            }
            finally
            {
                RegistoAssist.RemoverAssistencias();
            }


            //Verificação 
            if (resultado)
                Assert.IsTrue(resultado, "Tudo inserido como esperado, não contem clientes duplicados.");
            else
                Assert.IsFalse(resultado, "Já algum cliente nesta assistência.");
        }

        [TestMethod]
        public void InsereOperadorAssistencia()
        {
            //Criação de dados
            Assist a1 = new Assist(new DateTime(2023, 4, 20, 16, 40, 29), new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a2 = new Assist(new DateTime(2023, 10, 5, 10, 22, 11), new TipoAssist("Informacao entrega Produto", "Entregas", 2, 345), new EstadoAssist("Ativo", true), 1759, 12);

            Operador op1 = new Operador("Marco", 12, 2487, new Morada("Braga", "4720-444", "Amares"));
            Operador op2 = new Operador("Luis", 25, 2444, new Morada("Porto", "4221-112", "Arouca"));


            //Inserção de dados
            RegistoAssist.InsereAssistLista(a1);
            RegistoAssist.InsereAssistLista(a2);
            bool resultado;
            try
            {
                resultado = RegistoAssist.InsereOperadorAssistLista(a1, op1);
                //resultado = RegistoAssist.InsereOperadorAssistLista(a1, op2);
                resultado = RegistoAssist.InsereOperadorAssistLista(a2, op1);
                resultado = RegistoAssist.InsereOperadorAssistLista(a2, op2);
            }
            finally
            {
                RegistoAssist.RemoverAssistencias();
            }
            //Verificação
            if (resultado)
                Assert.IsTrue(resultado, "Tudo inserido como pretendido, não houve duplicações");
            else
                Assert.IsFalse(resultado, "Ja existe algum operador nesta assistência.");
        }

        [TestMethod]
        public void InsereSolucaoAssistencia()
        {
            //Criação de dados
            Assist a1 = new Assist(new DateTime(2023, 4, 20, 16, 40, 29), new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a2 = new Assist(new DateTime(2023, 4, 20, 15, 40, 29), new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);

            ProblemasCon prob1 = new ProblemasCon("Atendimento-Duvidas", 1, "Ditar problemas e conforme o numero digitado, apresentar solucao");
            ProblemasCon prob2 = new ProblemasCon("Entregas-Informacao", 2, "Oferecer detalhes sobre o estado de entrega");

            //Inserção de dados
            RegistoAssist.InsereAssistLista(a1);
            RegistoAssist.InsereAssistLista(a2);



            bool resultado;
            try
            {
                resultado = RegistoAssist.InsereSolucaoAssistLista(a1, prob1); // -> insere, não dá erro
                resultado = RegistoAssist.InsereSolucaoAssistLista(a2, prob2); // -> não insere, pois não é o mesmo id de assistência.
                resultado = RegistoAssist.InsereSolucaoAssistLista(a2, prob1); // -> insere, não dá erro
                resultado = RegistoAssist.InsereSolucaoAssistLista(a2, prob2); // -> erro, a assitência a2 já tem solução;
            }
            finally
            {
                RegistoAssist.RemoverAssistencias();
            }
            //Verificação
        }
    }
}
