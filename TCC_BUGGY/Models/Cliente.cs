
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using TCC_BUGGY.Data;
using TCC_BUGGY.Models;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Rendering;




namespace TCC_BUGGY.Models
{
    public class Cliente
    {

        [Key]
        public int IdCliente{ get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string UF  { get; set; }
        public string Cep { get; set; }
      //  public ICollection<Ocorrencia> Ocorrencias { get; set; }

        //Construtor//
        public Cliente ()
        {


        }

        //Metodos


        //  public void Pesquisa()

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

            //Construtor//
            public Atendimento()
            {



            }
        }



    }
}


