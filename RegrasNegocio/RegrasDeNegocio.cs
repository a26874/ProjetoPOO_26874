/*
*	<copyright file="RegrasDeNegocio" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/30/2023 7:57:32 PM</date>
*	<description></description>
**/

using Dados;
using Excecoes;
using ObjetosNegocio;
using Outros;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RegrasNegocio
{
    /// <summary>
    /// Classe para as regras de negócio.
    /// </summary>
    public class RegrasDeNegocio
    {
        #region ATRIBUTOS

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegrasDeNegocio()
        {

        }
        #endregion

        #region PROPRIEDADES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS        

        #region ASSISTENCIAS

        /// <summary>
        /// Recebe uma assistência e reencaminha a mesma para os dados a inserir.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.AssistException">Falha ao inserir assistencia.</exception>
        public static bool InsereAssistencia(Assist a)
        {
            if (a.TipoAssistencia is null || a.EstadoAssistencia is null)
                return false;
            try
            {
                RegistoAssist.InsereAssistLista(a);
                return true;
            }
            catch (AssistException e)
            {
                throw new AssistException("Falha ao inserir assistencia." + "-" + e.Message); // Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                              // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Recebe uma assistência e reencaminha para a lista de assistências e insere um cliente caso exista.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.ClienteException"></exception>
        public static bool InsereClienteAssistencia(Assist a)
        {
            if (a is null)
                return false;
            try
            {
                RegistoClientes.ExisteCliente(a.ClienteNIF, out Cliente clienteInserir);
                RegistoAssist.InsereClienteAssistLista(a, clienteInserir);
                return true;
            }
            catch (ClienteException e)
            {
                throw new ClienteException(e.Message + "-" + "A assistencia " + a.Id + " ja tem cliente");// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                                          // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Recebe uma assistência e reencaminha para a lista de assistências e insere um cliente caso exista.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.OperadorException"></exception>
        public static bool InsereOperadorAssistencia(Assist a)
        {
            if (a is null)
                return false;
            try
            {
                RegistoOperadores.ExisteOperador(a.OperadorId, out Operador operadorInserir);
                RegistoAssist.InsereOperadorAssistLista(a, operadorInserir);
                return true;
            }
            catch (OperadorException e)
            {
                throw new OperadorException(e.Message + "-" + "A assistencia " + a.Id + " ja tem operador");// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                                            // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Insere uma solução de um problema na assistência.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.AssistException"></exception>
        public static bool InsereSolucaoAssitencia(Assist a)
        {
            if (a is null)
                return false;
            try
            {
                RegistoProblemas.ExisteSolucao(a.TipoAssistencia.Id, out ProblemasCon problemaInserir);
                RegistoAssist.InsereSolucaoAssistLista(a, problemaInserir);
                return true;
            }
            catch (AssistException e)
            {
                throw new AssistException(e.Message + "-" + "A assistencia " + a.Id + " ja tem solucao");// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                                         // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Verifica a existência de uma assistência, a partir do seu ID.
        /// </summary>
        /// <param name="idAssist">The identifier assist.</param>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public static bool ExisteAssistencia(int idAssist, out Assist a)
        {
            RegistoAssist aux = new RegistoAssist();
            foreach (Assist b in aux.ObterAssistencias)
            {
                if (b.Id == idAssist)
                {
                    a = b;
                    return true;
                }
            }
            a = null;
            return false;
        }
        /// <summary>
        /// Mostra todas as assistências.
        /// </summary>
        /// <returns></returns>
        public static List<Assist> MostrarTodasAssistencias()
        {
            RegistoAssist aux = new RegistoAssist();
            List<Assist> copiaListaAssists = new List<Assist>();
            foreach (Assist a in aux.ObterAssistencias)
            {
                Assist clone = a.Clone();
                copiaListaAssists.Add(clone);
            }
            return copiaListaAssists;
        }
        /// <summary>
        /// Recebe todas as assistências e apenas mostra as ativas.
        /// </summary>
        public static List<Assist> MostrarAssistenciasAtivas()
        {
            RegistoAssist aux = new RegistoAssist();
            List<Assist> copiaListaAssistsAtivas = new List<Assist>();
            foreach (Assist a in aux.ObterAssistencias)
            {
                if (a.EstadoAssistencia.DescEstado == "Ativo" && a.EstadoAssistencia.Ativo == true)
                {
                    Assist clone = a.Clone();
                    copiaListaAssistsAtivas.Add(clone);
                }
            }
            return copiaListaAssistsAtivas;
        }
        /// <summary>
        /// Recebe todas as assistências e apenas mostra as concluidas.
        /// </summary>
        public static List<Assist> MostrarAssistenciasConcluidas()
        {
            RegistoAssist aux = new RegistoAssist();
            List<Assist> copiaListaAssistsConcluidas = new List<Assist>();
            foreach (Assist a in aux.ObterAssistencias)
            {
                if (a.EstadoAssistencia.DescEstado == "Completado" && a.EstadoAssistencia.Ativo == false)
                {
                    Assist clone = a.Clone();
                    copiaListaAssistsConcluidas.Add(clone);
                }
            }
            return copiaListaAssistsConcluidas;
        }
        /// <summary>
        /// Conclui uma assistência e regista a sua avaliação.
        /// </summary>
        /// <param name="idAssist">The identifier assist.</param>
        /// <param name="cls">The CLS.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.AssistException">Nao foi possivel concluir a assistencia" + "-" + e.Message</exception>
        /// <exception cref="Excecoes.ClienteException">Nao foi possivel concluir a assistencia" + "-" + e.Message</exception>
        public static bool ConcluirAssistencia(int idAssist, Avaliacao cls)
        {
            try
            {
                Assist aux = new Assist();
                RegistoAssist.ConcluirAssistencia(idAssist, out aux);
                RegistoClientes.VerificaSaldo(aux);
                RegistoAssist.RegistoAvaliacao(aux, cls);
                return true;
            }
            catch (AssistException e)
            {
                throw new AssistException("Nao foi possivel concluir a assistencia" + "-" + e.Message);// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                                       // para o main. Assim consegui explorar melhor exceções
            }
            catch (ClienteException e)
            {
                throw new ClienteException("Nao foi possivel concluir a assistencia" + "-" + e.Message);// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                                        // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Remove uma assistência do registo de assistências.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public static bool RemoverAssistencia(Assist a)
        {
            return RegistoAssist.RemoverAssistenciaEspecifica(a);
        }
        /// <summary>
        /// De todas as assistencias, mostra o preço da mais cara.
        /// </summary>
        /// <param name="listaAssistencias">The lista assistencias.</param>
        /// <returns></returns>
        public static int MostrarAssistenciaMaisCara(RegistoAssist listaAssistencias)
        {
            int maisCaro = 0;
            foreach (Assist a in listaAssistencias.ObterAssistencias)
            {
                if (a.TipoAssistencia.Preco > maisCaro && a.TipoAssistencia.Preco != -1)
                    maisCaro = a.TipoAssistencia.Preco;
            }
            return maisCaro;
        }
        /// <summary>
        /// Grava toda a informação acerca das assistências.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.EscritaFicheiro"></exception>
        public static bool GravarFicheiroAssist(string nomeFicheiro)
        {
            try
            {
                RegistoAssist.GravarFicheiroAssistencias(nomeFicheiro);
                return true;
            }
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro(e.Message + " - " + "Erro ao gravar ficheiro");// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                         // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Lê toda a informação guardada em ficheiro, acerca das assistências.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.LeituraFicheiro"></exception>
        public static bool LerFicheiroAssist(string nomeFicheiro)
        {
            try
            {
                RegistoAssist.LerFicheiroAssistencia(nomeFicheiro);
                return true;
            }
            catch (LeituraFicheiro e)
            {
                throw new LeituraFicheiro(e.Message + " - " + " Erro ao ler o ficheiro.");// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                          // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Retorna o numero de assistências realizadas.
        /// </summary>
        /// <returns></returns>
        public static int NumeroAssistRealizadas()
        {
            return RegistoAssist.NumeroAssistRealizadas();
        }
        /// <summary>
        /// Retorna uma lista das assistências em que certo cliente está associado.
        /// </summary>
        /// <param name="nifCliente">The nif cliente.</param>
        /// <returns></returns>
        public static List<Assist> ExisteClienteAssistEspecifico(int nifCliente)
        {
            RegistoAssist auxRegisto = new RegistoAssist();
            List<Assist> aux = new List<Assist>();
            foreach (Assist a in auxRegisto.ObterAssistencias)
                if (a.Cliente.NIF == nifCliente)
                    aux.Add(a);
            return aux;
        }

        /// <summary>
        /// Retorna uma lista das assistências em que certo operador está associado.
        /// </summary>
        /// <param name="idOperador">The identifier operador.</param>
        /// <returns></returns>
        public static List<Assist> ExisteOperadorAssistEspecifico(int idOperador)
        {
            RegistoAssist auxRegisto = new RegistoAssist();
            List<Assist> aux = new List<Assist>();
            foreach (Assist a in auxRegisto.ObterAssistencias)
                if (a.Operador.Id == idOperador)
                    aux.Add(a);
            return aux;
        }
        #endregion

        #region CLIENTES
        /// <summary>
        /// Recebe um cliente e reencaminha o mesmo para a "base de dados".
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.ClienteException">Falha ao inserir o cliente.</exception>
        public static bool InsereCliente(Cliente c)
        {
            if (c.NIF == -1 || c.Contacto == -1)
                return false;
            try
            {
                RegistoClientes.InsereClienteLista(c);
                return true;
            }
            catch (ClienteException e)
            {
                throw new ClienteException("Falha ao inserir o cliente." + e.Message);// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                      // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Insere saldo num cliente.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <param name="valor">The valor.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.ClienteException">Falha ao inserir saldo" + " - " + e.Message</exception>
        public static bool InsereSaldoCliente(Cliente c, int valor)
        {
            try
            {
                return RegistoClientes.InsereSaldo(c, valor);
            }
            catch (ClienteException e)
            {
                throw new ClienteException(" Falha ao inserir saldo" + " - " + e.Message);// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                          // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Mostra todos os clientes existentes.
        /// </summary>
        public static List<Cliente> MostrarTodosClientes()
        {
            RegistoClientes aux = new RegistoClientes();
            List<Cliente> listaClientes = new List<Cliente>();
            foreach (Cliente c in aux.ObterClientes)
            {
                Cliente clone = c.Clone();
                listaClientes.Add(clone);
            }
            return listaClientes;
        }
        /// <summary>
        /// Mostra a ficha completa de um cliente.
        /// </summary>
        public static List<Cliente> MostrarFichaClientesCompleto()
        {
            RegistoClientes aux = new RegistoClientes();
            List<Cliente> listaClientes = new List<Cliente>();
            foreach (Cliente c in aux.ObterClientes)
            {
                Cliente clone = c.Clone();
                listaClientes.Add(clone);
            }
            return listaClientes;
        }
        /// <summary>
        /// Grava toda a informação acerca de clientes.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.EscritaFicheiro"></exception>
        public static bool GravarFicheiroClientes(string nomeFicheiro)
        {
            try
            {
                RegistoClientes.GravarFicheiroClientes(nomeFicheiro);
                return true;
            }
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro(e.Message + " - " + "Erro ao gravar ficheiro");
            }
        }
        /// <summary>
        /// Lê toda a informação guardada em ficheiro, dos clientes.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.LeituraFicheiro"></exception>
        public static bool LerFicheiroClientes(string nomeFicheiro)
        {
            try
            {
                RegistoClientes.LerFicheiroClientes(nomeFicheiro);
                return true;
            }
            catch (LeituraFicheiro e)
            {
                throw new LeituraFicheiro(e.Message + " - " + " Erro ao ler o ficheiro.");
            }
        }
        #endregion

        #region OPERADORES
        /// <summary>
        /// Recebe um operador e reencaminha o mesmo para a "base de dados".
        /// </summary>
        /// <param name="o">The o.</param>
        /// <returns></returns>
        /// <exception cref="OperadorException">Falha ao inserir o operador.</exception>
        public static bool InsereOperador(Operador o)
        {
            if (o.Id == -1 || o.Contacto == -1)
                return false;
            try
            {
                RegistoOperadores.InsereOperadorLista(o);
                return true;
            }
            catch (OperadorException e)
            {
                throw new OperadorException(e.Message + "-" + "Falha ao inserir o operador.");// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                              // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Mostra todos os operadores existentes.
        /// </summary>
        public static List<Operador> MostrarTodosOperadores()
        {
            RegistoOperadores aux = new RegistoOperadores();
            List<Operador> listaOperadores = new List<Operador>();
            foreach (Operador o in aux.ObterOperadores)
            {
                Operador clone = o.Clone();
                listaOperadores.Add(clone);
            }
            return listaOperadores;
        }
        /// <summary>
        /// Grava toda a informação acerca de operadores.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.EscritaFicheiro"></exception>
        public static bool GravarFicheiroOperadores(string nomeFicheiro)
        {
            try
            {
                RegistoOperadores.GravarFicheiroOperadores(nomeFicheiro);
                return true;
            }
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro(e.Message + " - " + "Erro ao gravar ficheiro");
            }
        }
        /// <summary>
        /// Lê toda a informação guardada, acerca dos operadores.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.LeituraFicheiro"></exception>
        public static bool LerFicheiroOperadores(string nomeFicheiro)
        {
            try
            {
                RegistoOperadores.LerFicheiroOperadores(nomeFicheiro);
                return true;
            }
            catch (LeituraFicheiro e)
            {
                throw new LeituraFicheiro(e.Message + " - " + " Erro ao ler o ficheiro.");
            }
        }
        #endregion

        #region PRODUTOS

        /// <summary>
        /// Insere um produto na lista de produtos.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.ProdutosException"></exception>
        public static bool InserirProdutoLista(Produto p)
        {
            try
            {
                RegistoProdutos.InserirProduto(p);
                return true;
            }
            catch (ProdutosException e)
            {
                throw new ProdutosException(e.Message + "-" + "Falha ao inserir o produto.");// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                             // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Insere categorias numa lista.
        /// </summary>
        /// <param name="nomeCategoria">The nome categoria.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.CategoriaException"></exception>
        public static bool InserirCategoriasLista(string nomeCategoria, int idProd)
        {
            try
            {
                RegistoCategorias.InserirCategoria(nomeCategoria, idProd);
                return true;
            }
            catch (CategoriaException e)
            {
                throw new CategoriaException(e.Message + "-" + "Falha ao inserir categoria");// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                             // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Insere categorias num produto.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.CategoriaException"></exception>
        public static bool InserirCategoriasProduto(Produto p)
        {
            try
            {
                RegistoCategorias.ExisteCategoriasProduto(p.Id, out List<Categoria> categoriasInserir);
                RegistoProdutos.InserirCategorias(p, categoriasInserir.ToList());
                return true;
            }
            catch (CategoriaException e)
            {
                throw new CategoriaException(e.Message);
            }
        }

        /// <summary>
        /// Mostra as categorias de um produto.
        /// </summary>
        /// <returns></returns>
        public static List<Categoria> MostrarCategorias()
        {
            RegistoCategorias aux = new RegistoCategorias();
            List<Categoria> listaCategorias = new List<Categoria>();
            foreach (Categoria c in aux.ObterCategorias)
            {
                Categoria clone = c.Clone();
                listaCategorias.Add(clone);
            }
            return listaCategorias;
        }
        /// <summary>
        /// Retorna em uma lista todos os produtos existentes.
        /// </summary>
        /// <returns></returns>
        public static List<Produto> MostrarProdutos()
        {
            RegistoProdutos aux = new RegistoProdutos();
            List<Produto> listaProdutos = new List<Produto>();
            foreach (Produto p in aux.ObterProdutos)
            {
                Produto clone = p.Clone();
                listaProdutos.Add(clone);
            }
            return listaProdutos;
        }
        /// <summary>
        /// Grava toda a informação acerca dos produtos.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.EscritaFicheiro"></exception>
        public static bool GravarFicheiroProdutos(string nomeFicheiro)
        {
            try
            {
                RegistoProdutos.GravarFicheiroProdutos(nomeFicheiro);
                return true;
            }
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro(e.Message + " - " + "Erro ao gravar ficheiro");
            }
        }
        /// <summary>
        /// Lê toda a informação guardada em ficheiro, acerca dos produtos.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.LeituraFicheiro"></exception>
        public static bool LerFicheiroProdutos(string nomeFicheiro)
        {
            try
            {
                RegistoProdutos.LerFicheiroProdutos(nomeFicheiro);
                return true;
            }
            catch (LeituraFicheiro e)
            {
                throw new LeituraFicheiro(e.Message + " - " + " Erro ao ler o ficheiro");
            }
        }
        /// <summary>
        /// Grava todas as categorias existentes
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool GravarFicheiroCategorias(string nomeFicheiro)
        {
            try
            {
                RegistoCategorias.GravarFicheiroCategorias(nomeFicheiro);
                return true;
            }
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro(e.Message + " - " + "Erro ao gravar ficheiro");
            }
        }
        /// <summary>
        /// Lê toda a informação do ficheiro de categorias.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        /// <exception cref="LeituraFicheiro"></exception>
        public static bool LerFicheiroCategorias(string nomeFicheiro)
        {
            try
            {
                RegistoCategorias.LerFicheiroCategorias(nomeFicheiro);
                return true;
            }
            catch (LeituraFicheiro e)
            {
                throw new LeituraFicheiro(e.Message + " - " + "Erro ao ler ficheiro");
            }
        }
        #endregion

        #region SOLUCOES

        /// <summary>
        /// Insere uma solução na lista de soluções.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.ProblemaException"></exception>
        public static bool InsereSolucao(ProblemasCon p)
        {
            if (p.Id == -1 || p is null)
                return false;
            try
            {
                RegistoProblemas.InserirSolucaoLista(p);
                return true;
            }
            catch (ProblemaException e)
            {
                throw new ProblemaException(e.Message + "-" + "Ja existe esta solucao na lista de solucoes.");// Deveria retornar falso, entretanto ela apanha a exceção anterior e manda a anterior e a nova mensagem
                                                                                                              // para o main. Assim consegui explorar melhor exceções
            }
        }
        /// <summary>
        /// Se existir solucao para um problema, ela e mostrada.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="p">The p.</param>
        public static void MostrarSolucao(Assist a, ProblemasCon p)
        {
            bool existeSolucao = a.ExisteSolucao(a, p);
            if (existeSolucao)
            {
                Console.WriteLine(p.ToString());
            }
        }
        /// <summary>
        /// Devolve todas as soluções disponiveis.
        /// </summary>
        /// <returns></returns>
        public static List<ProblemasCon> MostrarSolucoesExistentes()
        {
            List<ProblemasCon> listaSolucoes = RegistoProblemas.ObterSolucoes;
            return listaSolucoes;
        }
        /// <summary>
        /// Verifica se existe solução para algum problema, a partir do ID.
        /// </summary>
        /// <param name="tipoId">The tipo identifier.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.SolucaoException">O problema ainda nao tem solucao.</exception>
        public static bool ExisteSolucaoProblema(int tipoId)
        {
            RegistoAssist auxRegisto = new RegistoAssist();
            List<ProblemasCon> listaSolucoes = RegistoProblemas.ObterSolucoes;
            foreach (Assist a in auxRegisto.ObterAssistencias)
            {
                if (a.TipoAssistencia.Id == tipoId)
                {
                    foreach (ProblemasCon p in listaSolucoes)
                    {
                        if (p.Id == a.TipoAssistencia.Id)
                        {
                            return true;
                        }
                    }
                }
            }
            throw new SolucaoException("O problema ainda nao tem solucao.");
        }
        /// <summary>
        /// Grava toda a informação acerca dos solucoes.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.EscritaFicheiro"></exception>
        public static bool GravarFicheiroSolucoes(string nomeFicheiro)
        {
            try
            {
                RegistoProblemas.GravarFicheiroSolucoes(nomeFicheiro);
                return true;
            }
            catch (EscritaFicheiro e)
            {
                throw new EscritaFicheiro(e.Message + " - " + "Erro ao gravar ficheiro");
            }
        }
        /// <summary>
        /// Lê toda a informação guardada em ficheiro, acerca das soluções.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.LeituraFicheiro"></exception>
        public static bool LerFicheiroSolucoes(string nomeFicheiro)
        {
            try
            {
                RegistoProblemas.LerFicheiroSolucoes(nomeFicheiro);
                return true;
            }
            catch (LeituraFicheiro e)
            {
                throw new LeituraFicheiro(e.Message + " - " + "Falha ao ler ficheiro.");
            }
        }
        #endregion


        #endregion

        #endregion
    }
}