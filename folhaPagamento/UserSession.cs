using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    public class UserSession
    {
        public string Username { get; set; }
        public bool IsAdmin { get; set; }
        public string CPF { get; set; }
    }
}
