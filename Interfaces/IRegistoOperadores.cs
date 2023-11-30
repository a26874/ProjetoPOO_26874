/*
*	<copyright file="IRegistoOperadores" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/21/2023 9:38:58 PM</date>
*	<description></description>
**/

using ObjetosNegocio;

namespace Interfaces
{
    public interface IRegistoOperadores
    {
        bool InsereOperador(Operador o);
        bool RemoverOperadores();
        bool RemoverOperadorEspecifico(Operador o);
        int NumeroOperadoresExistentes();
    }
}