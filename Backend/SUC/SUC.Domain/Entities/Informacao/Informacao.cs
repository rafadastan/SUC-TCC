﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Informacoes
{
    public class Informacao
    {
        public Guid IdInformacao { get; set; }
        public string NomeSolicitacaoInformacao { get; set; }
        public string Descricao { get; set; }
    }
}
