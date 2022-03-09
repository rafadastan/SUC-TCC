using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Adapters.ValidationErrors
{
    public class ValidationErrorModel
    {
        public string Name { get; set; }
        public List<string> Errors { get; set; }
    }
}
