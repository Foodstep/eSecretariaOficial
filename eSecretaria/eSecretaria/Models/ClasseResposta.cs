using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSecretaria.Models
{
    public class ClasseRespostaCreate
    {
        public bool success { get; set; }
        public string message { get; set; }
    }

    public class JsonRetorno
    {
        public Object data { get; set; }
    }
}