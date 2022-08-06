using System.Collections.Generic;

namespace TCC_BUGGY.Models.ViewModels
{
    public class AtendimentoFormViewModel
    {
        public Atendimento Atendimento{ get; set; }
        public ICollection<Ocorrencia> Ocorrencias { get; set; }
    }



}
