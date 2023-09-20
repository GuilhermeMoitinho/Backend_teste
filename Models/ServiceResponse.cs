using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseasy_API.Models
{
    public class ServiceResponse<T>
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; }
    }
}