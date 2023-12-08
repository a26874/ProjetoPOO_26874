/*
*	<copyright file="Excecoes" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/28/2023 8:21:22 PM</date>
*	<description></description>
**/

using System;

namespace Excecoes
{
    /// <summary>
    /// Exceção para verificação de existência de cliente.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ClienteNaoExisteException : Exception
    {
        public ClienteNaoExisteException(string message) : base(message)
        { }
    }
    /// <summary>
    /// Exceção para escrita de assistências.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EscritaFicheiro : Exception
    {
        public EscritaFicheiro() { }

        public EscritaFicheiro(string message) : base(message) { }
    }

    public class LeituraFicheiro : Exception
    {
        public LeituraFicheiro() { }

        public LeituraFicheiro (string message) : base(message) { }
    }
    /// <summary>
    /// Exceção para Soluções.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class NaoExisteSolucaoException : Exception
    {
        public NaoExisteSolucaoException(string message) : base(message) { }
    }
    /// <summary>
    /// Exceção para assistências.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class AssistException : Exception
    {
        public AssistException() { }

        public AssistException(string message) : base(message) { }
    }
    /// <summary>
    /// Exceção para Clientes.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ClienteException : Exception
    {
        public ClienteException() { }

        public ClienteException(string message) : base(message)
        {

        }
    }
    /// <summary>
    /// Exceção para operadores.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class OperadorException : Exception
    {
        public OperadorException() { }

        public OperadorException(string message) : base(message)
        {

        }
    }
    /// <summary>
    /// Exceção para solucoes.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ProblemaException : Exception
    {
        public ProblemaException() { }

        public ProblemaException(string message) : base(message) { }
    }
    /// <summary>
    /// Exceção para produtos.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ProdutosException : Exception
    {
        public ProdutosException() { }

        public ProdutosException(string message) : base(message) { }
    }
    /// <summary>
    /// Exceção para categorias.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class CategoriaException : Exception
    {
        public CategoriaException() { }

        public CategoriaException(string message) : base(message) { }
    }

}