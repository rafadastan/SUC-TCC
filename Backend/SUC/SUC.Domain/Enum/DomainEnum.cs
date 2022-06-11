using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Enum
{
    public struct DomainEnum
    {
        public enum PerfilEnum
        {
            Administrador = 1,
            Operador = 2,
            Municipe = 3,
            OperadorCampo = 4
        }

        public enum Solicitacao
        {
            Aberto,
            Aguardando,
            Andamento,
            Finalizado
        }

        public enum Atendimento
        {
            Aberto,
            Aguardando,
            Andamento,
            Finalizado
        }

        public enum Chamado
        {
            Aberto,
            Aguardando,
            Andamento,
            Finalizado
        }
    }
}
