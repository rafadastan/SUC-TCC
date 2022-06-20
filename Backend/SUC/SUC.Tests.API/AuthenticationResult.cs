using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Tests.API
{
    public class AuthenticationResult
    {
        public string Message { get; set; }
        public AccessToken AccessToken { get; set; }
    }
    public class AccessToken
    {
        public string BearerToken { get; set; }
        public DateTime Expiration { get; set; }
    }
}
