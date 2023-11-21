/*
*	<copyright file="IRegistoClientes" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/21/2023 7:01:31 PM</date>
*	<description></description>
**/

using Pessoas;

namespace Interfaces
{
    /// <summary>
    /// Classe de interfaces.
    /// </summary>
    public interface IRegistoClientes
    {
        void IniciarArrayClientes();
        bool InsereCliente(Cliente c);
        bool RemoverClientes();
        bool RemoverClienteEspecifico(Cliente c);
        void BubbleSortClientes();
        int NumeroClientesExistentes();
        bool ExisteCliente(int nif, out Cliente clienteInserir);
    }
}