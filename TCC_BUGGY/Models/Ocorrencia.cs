using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TCC_BUGGY.Models
{
    public class Ocorrencia
    {
        [Key]
        public int IdOcorrencia { get; set; }
        public string NomeOcorrencia { get; set; }
        public Boolean Comissionavel { get; set; }

        public ICollection<Atendimento> Atendimentos { get; set; } = new List<Atendimento>();

        //Construtor//
        public Ocorrencia()
        {
            
        }

        public Ocorrencia(int idOcorrencia, string nomeOcorrencia, bool comissionavel)
        {
            IdOcorrencia = idOcorrencia;
            NomeOcorrencia = nomeOcorrencia;
            Comissionavel = comissionavel;
        }
    }
}
