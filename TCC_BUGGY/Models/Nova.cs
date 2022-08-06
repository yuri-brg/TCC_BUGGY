using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC_BUGGY.Models
{
    public class Nova
    {
        public  Cliente Cliente { get; set; }
        public IEnumerable<Atendimento> Atendimentos  { get; set; }
    }
}
