/*
*	<copyright file="Assist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 5:16:25 PM</date>
*	<description></description>
**/
using TipoAssistencia;
using Clientes;
using Operadores;
using EstadoAssistencia;
using System;

namespace Assistencia
{
    public class Assist
    {
        const int MAXASSISTENCIAS = 10;

        #region ATRIBUTOS
        private int idAssistencia;
        private DateTime dataAssistencia;
        private int precoAssistencia;
        TipoAssist[] tipoAssistencia;
        EstadoAssist[] estadoAssistencia;
        Cliente[] clienteAssistir;
        Operador[] operadorExecutar;
        private static Assist[] assistencias;
        private static int assistenciasRealizadas;

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor default;
        /// </summary>
        public Assist()
        {
            idAssistencia = -1;
            dataAssistencia = DateTime.MinValue;
            precoAssistencia = 0;
            assistenciasRealizadas = 0;
            assistencias = new Assist[MAXASSISTENCIAS];
        }
        /// <summary>
        /// Construtor para assistencia, com todos os parametros.
        /// </summary>
        /// <param name="id">O identificador da assistencia.</param>
        /// <param name="data">A data da assistencia.</param>
        /// <param name="preco">O preco da assistencia.</param>
        public Assist(int id, DateTime data, int preco)
        {
            this.idAssistencia = id;
            this.dataAssistencia = data;
            this.precoAssistencia = preco;
        }
        /// <summary>
        /// Construtor para assistencia, com apenas dois parametros.
        /// </summary>
        /// <param name="id">O identificador da assistencia.</param>
        /// <param name="preco">O preco da assistencia.</param>
        public Assist(int id, int preco)
        {
            this.idAssistencia = id;
            this.precoAssistencia = preco;
        }
        public static Assist[] Assistencias
        {
            get
            {
                Assist[] copy = new Assist[assistencias.Length];
                Array.Copy(assistencias,copy, assistencias.Length);
                return copy;
            }
        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Manipulacao da variavel id.
        /// </summary>
        public int Id
        {
            set
            {
                foreach(Assist a in assistencias)
                {
                    if (a.Id == value)
                        value++;
                }
                idAssistencia = value;
            }
            get { return Id; }
        }
        /// <summary>
        /// Manipulacao da variavel preco.
        /// </summary>
        public int Preco
        {
            set
            {
                if (value > 0)
                {
                    Preco = value;
                }
            }
            get { return precoAssistencia; }
        }
        /// <summary>
        /// Manipulacao da variavel data.
        /// </summary>
        public DateTime Data
        {
            set { Data = value; }
            get { return dataAssistencia; }
        }
        #endregion

        #region OPERADORES        
        /// <summary>
        /// Redefinição do operador ==.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static bool operator == (Assist a, Assist b)
        {
            if ((a.idAssistencia == b.idAssistencia) && (a.dataAssistencia == b.dataAssistencia))
                return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static bool operator != (Assist a, Assist b)
        {
            return (!(a == b));
        }
        #endregion

        #region OVERRIDES        
        /// <summary>
        /// Reformulação do metodo ToString na classe Assist.
        /// </summary>
        public override string ToString()
        {
            return string.Format("ID:{0}|Data:{1}|Preco:{2}", idAssistencia.ToString(), dataAssistencia.ToString(), precoAssistencia.ToString());
        }
        /// <summary>
        /// Determina se um determinado objeto é igual a outro.
        /// </summary>
        public override bool Equals(object obj)
        {
            if(obj is Assist)
            {
                Assist a = (Assist)obj;
                if (this == a)
                    return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region OUTROS METODOS

        #endregion

        #endregion
    }
}