/*
*	<copyright file="IRegistoClientes" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/21/2023 7:01:31 PM</date>
*	<description></description>
**/

using ObjetosNegocio;

namespace Interfaces
{
    /// <summary>
    /// Classe de Interfaces.
    /// </summary>
    public interface IRegistoClientes
    {
        bool InsereCliente(Cliente c);
        bool RemoverClientes();
        bool RemoverClienteEspecifico(Cliente c);
        void OrdenarClientes();
        int NumeroClientesExistentes();
    }
}