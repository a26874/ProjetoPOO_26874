/*
*	<copyright file="GereFicheiroAssistencias" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/23/2023 7:13:30 PM</date>
*	<description></description>
**/

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Assistencia;

namespace GereFicheiros
{
    /// <summary>
    /// Classe para escrita e leitura de assistencias.
    /// </summary>
    public class GereFicheiroAssistencias
    {
        #region ATRIBUTOS

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        public GereFicheiroAssistencias()
        {

        }
        #endregion

        #region PROPRIEDADES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        public static bool GravarFicheiroAssistencias (string nomeFicheiro, RegistoAssist listaAssist)
        {
            Stream ficheiro = null;
            if (!File.Exists(nomeFicheiro))
            {
                ficheiro = File.Open(nomeFicheiro, FileMode.Create);
            }
            else
            {
                ficheiro = File.Open(nomeFicheiro, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(ficheiro, listaAssist);
                ficheiro.Close();
                return true;
            }
            return false;
        }
        #endregion

        #endregion
    }
}