/*
*	<copyright file="RegistoAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/30/2023 1:26:01 PM</date>
*	<description></description>
**/
using Outros;
using Pessoas;

namespace Assistencia
{
    /// <summary>
    /// Classe para registar assistências.
    /// </summary>
    public class RegistoAssist
    {
        const int MAXASSISTENCIAS = 5;

        #region ATRIBUTOS
        private int numAssist;
        private Assist[] listaAssistencias;
        private static int assistenciasRealizadas;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Inicializa <see cref="RegistoAssist"/> classe.
        /// </summary>
        static RegistoAssist()
        {
            assistenciasRealizadas = 0;
        }
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoAssist()
        {
            listaAssistencias = new Assist[MAXASSISTENCIAS];
            IniciarArrayRegisto();
        }

        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Devolve a array de todas as assistências.
        /// </summary>
        /// <value>
        /// The todas assistencias.
        /// </value>
        public Assist[] ObterAssistencias
        {
            get { return (Assist[])listaAssistencias.Clone(); }
        }
        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Metodo para inicialização da array.
        /// </summary>
        /// <param name="a"></param>
        void IniciarArrayRegisto()
        {
            for (int i = 0; i < listaAssistencias.Length;i++)
            {
                listaAssistencias[i] = new Assist();
            }
        }
        /// <summary>
        /// Metodo para a inserção de uma nova assistência na array de registos.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool InsereAssist(RegistoOperadores listaOperadores, RegistoClientes listaClientes,Assist a)
        {
            bool existeCliente = listaClientes.ExisteCliente(a.ClienteNIF, out Cliente clienteInserir);
            bool existeOperador = listaOperadores.ExisteOperador(a.OperadorId, out Operador operadorInserir);
            //Verificar se a já existe!!! && se existe espaço
            if (existeCliente && existeOperador)
            {
                a.Cliente = clienteInserir;
                a.Operador = operadorInserir;
                bool inserirAssist =InsereAssistArray(a);
                if (inserirAssist)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        /// <summary>
        /// Insere uma assistencia na array.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public bool InsereAssistArray(Assist a)
        {
            foreach (Assist b in listaAssistencias)
            {
                if (b.Id == -1)
                    continue;
                if (b.Equals(a) || (numAssist>=MAXASSISTENCIAS))
                    return false;
            }
            listaAssistencias[numAssist] = a;
            numAssist++;
            return true;
        }
        /// <summary>
        /// Substitui as assistências existentes por novos objetos do tipo assist.
        /// </summary>
        /// <param name="r"></param>
        public bool RemoverAssistencias()
        {
            for (int i = 0; i < listaAssistencias.Length; i++)
            {
                if (listaAssistencias[i] is null)
                    continue;
                else
                    listaAssistencias[i] = null;
            }
            return true;
        }
        /// <summary>
        /// Dada uma certa assistencia essa mesma é removida da array de assitências.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public bool RemoverAssistenciaEspecifica(Assist a)
        {
            for (int i = 0; i < listaAssistencias.Length; i++)
            {
                if (listaAssistencias[i].Equals(a))
                {
                    for (int j = i; j < listaAssistencias.Length - 1; j++)
                        listaAssistencias[j] = listaAssistencias[j + 1];
                    listaAssistencias[listaAssistencias.Length - 1] = null;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Organiza a array de assistencias conforme o ID da assistência.
        /// </summary>
        public void BubbleSortAssistencias()
        {
            Assist aux;
            bool a = true;
            while (a)
            {
                a = false;
                for (int i = 0; i < listaAssistencias.Length - 1; i++)
                {
                    if (ReferenceEquals(listaAssistencias[i], null)||listaAssistencias[i].Id > listaAssistencias[i + 1].Id)
                    {
                        aux = listaAssistencias[i];
                        listaAssistencias[i] = listaAssistencias[i + 1];
                        listaAssistencias[i + 1] = aux;
                        a = true;
                    }
                }
            }
        }
        /// <summary>
        /// Conclui uma assistência.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public bool ConcluirAssistencia(Assist a)
        {
            foreach(Assist b in listaAssistencias)
            {
                if (b.Id == -1)
                    continue;
                if(b.Equals(a))
                {
                    if (a.estadoA.Ativo == false)
                        return false;
                    a.estadoA.Ativo = false;
                    a.estadoA.DescEstado = "Completado";
                    assistenciasRealizadas++;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Retorna o numero de assistencias realizadas.
        /// </summary>
        /// <returns></returns>
        public int MostrarAssistenciasRealizadas()
        {
            return assistenciasRealizadas;
        }
        /// <summary>
        /// Registar avaliacao de uma assistencia.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="cls">The CLS.</param>
        /// <returns></returns>
        public bool RegistoAvaliacao(Assist a, Avaliacao cls)
        {
            foreach (Assist b in listaAssistencias)
            {
                if (b.Id == -1)
                    continue;
                if (b.Equals(a))
                {
                    if (b.Classificacao.Pontuacao == -1)
                    {
                        b.Classificacao = cls;
                        return true;
                    }
                }
            }
            return false;
        }

        #endregion

        #endregion
    }
}