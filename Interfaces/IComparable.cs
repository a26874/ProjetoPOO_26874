/*
*	<copyright file="IComparableClientes" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/25/2023 7:59:43 PM</date>
*	<description></description>
**/
using Pessoas;

namespace Interfaces
{
    public interface IComparable
    {
        int CompareTo(Cliente a);
    }
}