﻿using MediatR;
using SUC.Domain.Entities.Avaliacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class AvaliacaoNotification : INotification
    {
        public Avaliacao Avaliacao { get; set; }
        public ActionNotification Action { get; set; }
    }
}
