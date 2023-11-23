/*
*	<copyright file="IRegistoAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/21/2023 10:08:11 PM</date>
*	<description></description>
**/

using Pessoas;
using Assistencia;
using Outros;

namespace Interfaces
{
    public interface IRegistoAssist
    {
        bool InsereAssistArray(Assist a);
        bool InsereClienteAssist(Assist a, Cliente[] listaClientes);
        bool InsereOperadorAssist(Assist a, Operador[] listaOperadores);
        bool RemoverAssistencias();
        bool RemoverAssistenciaEspecifica(Assist a);
        void BubbleSortAssistencias();
        bool ConcluirAssistencia(Assist a);
        int MostrarAssistenciasRealizadas();
        bool RegistoAvaliacao(Assist a, Avaliacao cls);
    }
}