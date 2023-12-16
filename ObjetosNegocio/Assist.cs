/*
*	<copyright file="Assist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 5:16:25 PM</date>
*	<description></description>
**/
using System;
using Assistencia;
using Outros;

namespace ObjetosNegocio
{
    [Serializable]
    /// <summary>
    /// Classe para assistências.
    /// </summary>
    public class Assist : IComparable<Assist>
    {

        #region ATRIBUTOS
        private int idAssistencia;
        private DateTime dataAssistencia;
        private TipoAssist tipoAssistencia;
        private EstadoAssist estadoAssistencia;
        //Conforme cliente e operador ID, vai buscar à array de clientes o cliente com o ID pretendido e o operador com o ID pretendido.
        private int clienteNif;
        private int operadorId;
        private Cliente cliente;
        private Operador operador;
        private Avaliacao classificacao;
        private ProblemasCon solucao;
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
            this.clienteNif = clienteNIF;
            this.operadorId = operadorId;
            classificacao = new Avaliacao();
            solucao = new ProblemasCon();
        }
        protected Assist(int idAssistencia, DateTime dataAssistencia, TipoAssist tipoAssistencia, EstadoAssist estadoAssistencia, int clienteNif, int operadorId, Cliente cliente, Operador operador, Avaliacao classificacao, ProblemasCon solucao)
        {
            this.idAssistencia = idAssistencia;
            this.dataAssistencia = dataAssistencia;
            this.tipoAssistencia = tipoAssistencia;
            this.estadoAssistencia = estadoAssistencia;
            this.clienteNif = clienteNif;
            this.operadorId = operadorId;
            this.cliente = cliente;
            this.operador = operador;
            this.classificacao = classificacao;
            this.solucao = solucao;
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
            get { return clienteNif; }
            set { clienteNif = value; }
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
            get { return classificacao; }
            set { classificacao = value; }
        }
        /// <summary>
        /// Manipulacao da variavel Solucao.
        /// </summary>
        /// <value>
        /// The solucao.
        /// </value>
        public ProblemasCon Solucao
        {
            get { return solucao;}
            set { solucao = value; }
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
            if ((a.dataAssistencia == b.dataAssistencia) && (a.tipoAssistencia.Id == b.tipoAssistencia.Id ))
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
                return string.Format("ID assistencia:{0}\nData:{1}\nPreco:{2}\nTipo:{3}\nDesc:{4}\nIDTipo:{5}\nEstado:{6}\nDescEstado:{7}\nCliente:\n{8}\nOperador:\n{9}\nAvaliacao:\n{10}",
                idAssistencia, dataAssistencia, tipoAssistencia.Preco, tipoAssistencia.NomeTipo, tipoAssistencia.Desc, tipoAssistencia.Id, estadoAssistencia.Ativo, estadoAssistencia.DescEstado,
                cliente.ToString(), operador.ToString(),classificacao.ToString());
            }
            else if (solucao.Id !=-1)
            {
                return string.Format("ID assistencia:{0}\nData:{1}\nPreco:{2}\nTipo:{3}\nDesc:{4}\nIDTipo:{5}\nEstado:{6}\nDescEstado:{7}\nCliente:\n{8}\nOperador:\n{9}\nComo Resolver:\n{10}\n",
                idAssistencia, dataAssistencia, tipoAssistencia.Preco, tipoAssistencia.NomeTipo, tipoAssistencia.Desc, tipoAssistencia.Id, estadoAssistencia.Ativo, estadoAssistencia.DescEstado,
                cliente.ToString(), operador.ToString(),solucao.ToString());
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
        /// <summary>
        /// Compara dois objetos de assistencias a partir do seu ID.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public int CompareTo(Assist a)
        {
            if (a is null)
                return 1;
            if (dataAssistencia < a.dataAssistencia)
                return -1;
            else if (dataAssistencia > a.dataAssistencia)
                return 1;
            else
                return 0;
        }
        /// <summary>
        /// Metodo para dar deep clone de uma assistência, necessário para conseguir obter uma copia de raiz da lista de assistencias
        /// dentro da "base de dados"
        /// </summary>
        /// <returns></returns>
        public Assist Clone()
        {
            return new Assist(
                idAssistencia,
                dataAssistencia, 
                tipoAssistencia.Clone(), 
                estadoAssistencia.Clone(), 
                clienteNif, 
                operadorId, 
                cliente.Clone(), 
                operador.Clone(), 
                classificacao.Clone(), 
                solucao.Clone());
        }
        #endregion

        #endregion
    }
}