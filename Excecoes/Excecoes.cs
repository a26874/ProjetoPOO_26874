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
        public class ClienteNaoExisteException : Exception
        {
            public ClienteNaoExisteException() { }

            public ClienteNaoExisteException(string message) : base(message) { }
        }

        public class EscritaFicheiroAssistException : Exception
        {
            public EscritaFicheiroAssistException() { }

            public EscritaFicheiroAssistException(string message) : base(message) { }
        }
    }