/*
*	<copyright file="IRegistoOperadores" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/21/2023 9:38:58 PM</date>
*	<description></description>
**/

using Pessoas;

namespace Interfaces
{
    public interface IRegistoOperadores
    {
        bool InsereOperador(Operador o);
        bool RemoverOperadores();
        bool RemoverOperadorEspecifico(Operador o);
        void BubbleSortOperadores();
        int NumeroOperadoresExistentes();
        bool ExisteOperador(int id, out Operador operadorInserir);
    }
}