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
    public class EscritaFicheiroAssistException : Exception
    {
        public EscritaFicheiroAssistException() { }

        public EscritaFicheiroAssistException(string message) : base(message) { }
    }
    /// <summary>
    /// Exceção para escrita de clientes.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EscritaFicheiroClientesException : Exception
    {
        public EscritaFicheiroClientesException() { }

        public EscritaFicheiroClientesException(string message) : base(message) { }
    }
    /// <summary>
    /// Exceção para escrita de operadores.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class EscritaFicheiroOperadoresException : Exception
    {
        public EscritaFicheiroOperadoresException() { }
    
        public EscritaFicheiroOperadoresException(string message) : base(message) { }
    }

    public class NaoExisteSolucaoException : Exception
    {
        public NaoExisteSolucaoException(string message) : base(message) { }
    }
    
    public class AssistException : Exception 
    { 
        public AssistException() { }

        public AssistException(string message) : base(message) { }
    }

    public class ClienteException : Exception
    {
        public ClienteException() { }

        public ClienteException(string message) : base(message)
        {

        }
    }
    public class OperadorException : Exception
    {
        public OperadorException() { }

        public OperadorException(string message) : base(message)
        {

        }
    }
    public class ProblemaException : Exception
    {
        public ProblemaException() { }

        public ProblemaException(string message) : base(message) { }
    }
}