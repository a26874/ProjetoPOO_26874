/*
*	<copyright file="IRegistoAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/21/2023 10:08:11 PM</date>
*	<description></description>
**/

using Outros;
using System.Collections.Generic;
using ObjetosNegocio;

namespace Interfaces
{
    /// <summary>
    /// Classe de interface Assist.
    /// </summary>
    public interface IRegistoAssist
    {
        bool InsereAssistLista(Assist a);
        bool InsereClienteAssist(Assist a, List<Cliente> listaClientes);
        bool InsereOperadorAssist(Assist a, List<Operador> listaOperadores);
        bool RemoverAssistencias();
        bool RemoverAssistenciaEspecifica(Assist a);
        void OrdenarAssistencias();
        bool ConcluirAssistencia(Assist a);
        int MostrarAssistenciasRealizadas();
        bool RegistoAvaliacao(Assist a, Avaliacao cls);
    }
}