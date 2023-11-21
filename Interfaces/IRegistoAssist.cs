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
        void IniciarArrayRegisto();
        bool InsereAssist(RegistoOperadores listaOperadores, RegistoClientes listaClientes, Assist a);
        bool InsereAssistArray(Assist a);
        bool RemoverAssistencias();
        bool RemoverAssistenciaEspecifica(Assist a);
        void BubbleSortAssistencias();
        bool ConcluirAssistencia(Assist a);
        int MostrarAssistenciasRealizadas();
        bool RegistoAvaliacao(Assist a, Avaliacao cls);
    }
}