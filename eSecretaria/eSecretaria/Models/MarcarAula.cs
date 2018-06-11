using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSecretaria.Models
{
    public class MarcarAula
    {
        public DateTime data { get; set; }
        public string sala { get; set; }
        public string inicio { get; set; }
        public string fim { get; set; }
        public List<int> alunos { get; set; }
    }

    class JsonAula
    {
        public string title { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public bool allDay { get; set; }
        
    }
}