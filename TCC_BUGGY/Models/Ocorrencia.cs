using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace TCC_BUGGY.Models
{
    public class Ocorrencia
    {
        [Key]
        public int IdOcorrencia { get; set; }
        public string NomeOcorrencia { get; set; }
        public Boolean Comissionavel { get; set; }

    }
}
