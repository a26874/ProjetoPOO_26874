/*
*	<copyright file="Assist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 5:16:25 PM</date>
*	<description></description>
**/
using TipoAssistencia;
using EstadoAssistencia;
using System;

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
        ///Conforme cliente e operador ID, vai buscar à array de clientes o cliente com o ID pretendido e o operador com o ID pretendido.
        private int clienteId;
        private int operadorId;
        private static int assistenciasRealizadas = 0;

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        
        static Assist()
        {
            assistenciasRealizadas = 0;
        }
        /// <summary>
        /// Construtor default;
        /// </summary>
        public Assist()
        {
            idAssistencia = -1;
            dataAssistencia = DateTime.MinValue;
            assistenciasRealizadas = 0;
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
        /// <param name="idAssistencia"></param>
        /// <param name="dataAssistencia"></param>
        /// <param name="tipoA"></param>
        /// <param name="estadoA"></param>
        /// <param name="clienteId"></param>
        /// <param name="operadorId"></param>
        public Assist(int idAssistencia, DateTime dataAssistencia, TipoAssist tipoA, EstadoAssist estadoA, int clienteId, int operadorId)
        {
            this.idAssistencia = idAssistencia;
            this.dataAssistencia= dataAssistencia;
            tipoAssistencia = new TipoAssist();
            estadoAssistencia = new EstadoAssist();
            this.clienteId = clienteId;
            this.operadorId = operadorId;
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
        public int ClienteId
        {
            get { return clienteId; }
            set {  clienteId = value; }
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
            return string.Format("ID assistencia:{0} - Data:{1} - Preco:{2} - Tipo:{3} - Desc:{4} - IDTipo:{5} - Estado:{6} - DescEstado:{7}",
                idAssistencia, dataAssistencia, tipoAssistencia.Preco, tipoAssistencia.NomeTipo, tipoAssistencia.Desc, tipoAssistencia.Id, estadoAssistencia.Ativo, estadoAssistencia.DescEstado);      
        }

        #endregion

        #endregion
    }
}