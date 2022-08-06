using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

using System.Linq;


namespace TCC_BUGGY.Models
{
    public class Atendimento
    {
        [Key]
        public int IdAtendimento { get; set; }
        public int IdCliente { get; set; }

        public ICollection<Ocorrencia> Ocorrencias { get; set; } = new List<Ocorrencia>();

        public int IdOcorrencia { get; set; }

        public int IdUsuario { get; set; }
        public string NomeOcorrencia { get; set; }
        public string Complemento { get; set; }
        public DateTime DataOcorrencia { get; set; }

        public string Telefone { get; set; }


        //Construtor//
        public Atendimento()
        {

        }

        public Atendimento(int idAtendimento, int idCliente, int idOcorrencia, int idUsuario, string nomeOcorrencia, string complemento, DateTime dataOcorrencia, string telefone)
        {
            IdAtendimento = idAtendimento;
            IdCliente = idCliente;
            IdOcorrencia = idOcorrencia;
            IdUsuario = idUsuario;
            NomeOcorrencia = nomeOcorrencia;
            Complemento = complemento;
            DataOcorrencia = dataOcorrencia;
            Telefone = telefone;
        }


    }
}
