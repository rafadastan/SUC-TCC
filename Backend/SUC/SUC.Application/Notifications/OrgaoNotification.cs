﻿using MediatR;
using SUC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class OrgaoNotification : INotification
    {
        public Orgao Orgao { get; set; }
        public ActionNotification Action { get; set; }
    }
}
