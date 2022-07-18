using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;



namespace TCC_BUGGY.Models
{
  
    public class Usuario

    {
        [Key]
        public int IdUsuario { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int Matricula { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }


    }
}
