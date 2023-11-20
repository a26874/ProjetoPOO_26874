/*
*	<copyright file="Assist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 5:16:25 PM</date>
*	<description></description>
**/
using System;
using Pessoas;
using Outros;

namespace Assistencia
{
    /// <summary>
    /// Classe para assistências.
    /// </summary>
    public class Assist
    {

        #region ATRIBUTOS
        private int idAssistencia;
        private DateTime dataAssistencia;
        private TipoAssist tipoAssistencia;
        private EstadoAssist estadoAssistencia;
        //Conforme cliente e operador ID, vai buscar à array de clientes o cliente com o ID pretendido e o operador com o ID pretendido.
        private int clienteNIF;
        private int operadorId;
        private Cliente cliente;
        private Operador operador;
        private Avaliacao classificacao;
        private static int contIdAssistencia;

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Inicializa o contador de assistencias.
        /// </summary>
        static Assist()
        {
            contIdAssistencia = 1;
        }
        /// <summary>
        /// Construtor default;
        /// </summary>
        public Assist()
        {
            idAssistencia = -1;
            dataAssistencia = DateTime.MinValue;
            tipoAssistencia = new TipoAssist();
            estadoAssistencia = new EstadoAssist();
            ClienteNIF = -1;
            operadorId = -1;
        }
        /// <summary>
        /// Construtor com 2 parametros para teste.
        /// </summary>
        /// <param name="idAssistencia"></param>
        /// <param name="dataAssistencia"></param>
        public Assist(int idAssistencia, DateTime dataAssistencia)
        {
            this.idAssistencia = idAssistencia;
            this.dataAssistencia = dataAssistencia;
        }
        /// <summary>
        /// Construtor com todos os parametros.
        /// </summary>
        /// <param name="dataAssistencia"></param>
        /// <param name="tipoA"></param>
        /// <param name="estadoA"></param>
        /// <param name="clienteNIF"></param>
        /// <param name="operadorId"></param>
        public Assist(DateTime dataAssistencia, TipoAssist tipoA, EstadoAssist estadoA, int clienteNIF, int operadorId)
        {
            idAssistencia = contIdAssistencia;
            if (idAssistencia >= 1)
                idAssistencia = contIdAssistencia++;
            this.dataAssistencia = dataAssistencia;
            tipoAssistencia = tipoA;
            estadoAssistencia = estadoA;
            this.clienteNIF = clienteNIF;
            this.operadorId = operadorId;
            classificacao = new Avaliacao();
        }

        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Manipulacao da variavel id.
        /// </summary>
        public int Id
        {
            set { idAssistencia = value; }
            get { return idAssistencia; }
        }
        /// <summary>
        /// Manipulacao da variavel data.
        /// </summary>
        public DateTime Data
        {
            set { dataAssistencia = value; }
            get { return dataAssistencia; }
        }
        /// <summary>
        /// Manipulacao da variavel tipoAssistencia.
        /// </summary>
        public TipoAssist tipoAssis
        {
            get { return tipoAssistencia; }
            set { tipoAssistencia = value; }
        }
        /// <summary>
        /// Manipulacao da variavel EstadoAssistencia.
        /// </summary>
        /// <value>
        /// The estado a.
        /// </value>
        public EstadoAssist estadoA
        {
            get { return estadoAssistencia; }
            set { estadoAssistencia = value; }
        }
        /// <summary>
        /// Manipulacao da variavel clienteID.
        /// </summary>
        /// <value>
        /// The cliente.
        /// </value>
        public int ClienteNIF
        {
            get { return clienteNIF; }
            set { clienteNIF = value; }
        }
        /// <summary>
        /// Manipulacao da variavel operadorID
        /// </summary>
        /// <value>
        /// The operador.
        /// </value>
        public int OperadorId
        {
            get { return operadorId; }
            set { operadorId = value; }
        }
        /// <summary>
        /// Manipulacao da variavel Cliente.
        /// </summary>
        /// <value>
        /// The cliente.
        /// </value>
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        /// <summary>
        /// Manipulacao da variavel Operador.
        /// </summary>
        public Operador Operador
        {
            get { return operador; }
            set { operador = value; }
        }
        /// <summary>
        /// Manipulacao da variavel Classificação.
        /// </summary>
        public Avaliacao Classificacao
        {
            get { return this.classificacao; }
            set { this.classificacao = value; }
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
            if ((a.idAssistencia == b.idAssistencia) && (a.dataAssistencia == b.dataAssistencia) && (a.tipoAssistencia.Id == b.tipoAssistencia.Id ))
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
            return !(a == b);
        }
        #endregion

        #region OVERRIDES        
        /// <summary>
        /// Reformulação do metodo ToString na classe Assist.
        /// </summary>
        public override string ToString()
        {
            return FichaAssistencia();
        }
        /// <summary>
        /// Determina se um determinado objeto do tipo Assist é igual a outro.
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
        //Ainda por fazer.
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Metodo para apresentação dos dados de uma assistencia.
        /// </summary>
        /// <returns></returns>
        public string FichaAssistencia()
        {
            if (classificacao.Pontuacao !=-1)
            {
                return string.Format("ID assistencia:{0}\nData:{1}\nPreco:{2}\nTipo:{3}\nDesc:{4}\nIDTipo:{5}\nEstado:{6}\nDescEstado:{7}\nCliente:\n{8}\nOperador:\n{9}\nAvaliacao:{10}",
                idAssistencia, dataAssistencia, tipoAssistencia.Preco, tipoAssistencia.NomeTipo, tipoAssistencia.Desc, tipoAssistencia.Id, estadoAssistencia.Ativo, estadoAssistencia.DescEstado,
                cliente.ToString(), operador.ToString(),classificacao.ToString());
            }
            return string.Format("ID assistencia:{0}\nData:{1}\nPreco:{2}\nTipo:{3}\nDesc:{4}\nIDTipo:{5}\nEstado:{6}\nDescEstado:{7}\nCliente:\n{8}\nOperador:\n{9}",
                idAssistencia, dataAssistencia, tipoAssistencia.Preco, tipoAssistencia.NomeTipo, tipoAssistencia.Desc, tipoAssistencia.Id, estadoAssistencia.Ativo, estadoAssistencia.DescEstado,
                cliente.ToString(), operador.ToString());
        }
        /// <summary>
        /// Verifica se ja existe uma solucao para o problema.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public bool ExisteSolucao(Assist a, ProblemasCon p)
        {
            if (p.Equals(a.tipoAssis))
                return true;
            return false;
        }
        #endregion

        #endregion
    }
}