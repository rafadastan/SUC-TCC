using Microsoft.AspNetCore.Http;
using SUC.Domain.Contracts.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Security.UserContext
{
    public class UserHttpContext : IUserContext
    {
        private readonly IHttpContextAccessor _accessor;

        public UserHttpContext(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string Name => _accessor.HttpContext.User.Identity.Name;

        public bool IsAuthenticated()
        {
            return _accessor.HttpContext.User.Identity.IsAuthenticated;
        }
    }
}
