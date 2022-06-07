﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Telefone
{
    public class Telefone
    {
        public Guid IdTelefone { get; set; }
        public string Numero { get; set; }
        public string DDDNumero { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid? CreatorUserId { get; set; }
        public DateTime? LastModificationDate { get; set; }
        public Guid? LastModifierUserId { get; set; }
    }
}