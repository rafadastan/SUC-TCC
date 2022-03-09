using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Cryptography
{
    public interface IMD5Cryptoghaphy
    {
        string Encrypt(string value);
    }
}
