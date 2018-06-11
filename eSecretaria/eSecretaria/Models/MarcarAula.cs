using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSecretaria.Models
{
    public class MarcarAula
    {
        public string sala { get; set; }
        public string inicio { get; set; }
        public string fim { get; set; }
        public List<int> alunos { get; set; }
    }
}