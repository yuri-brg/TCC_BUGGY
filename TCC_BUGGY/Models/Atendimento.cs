using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace TCC_BUGGY.Models
{
    public class Atendimento
    {
        [Key]
        public int IdAtendimento { get; set; }
        public int IdCliente { get; set; }
        public int IdOcorrencia { get; set; }
        public int IdUsuario { get; set; }
        public string NomeOcorrencia { get; set; }
        public string Complemento { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public string Telefone { get; set; }
    }
}
