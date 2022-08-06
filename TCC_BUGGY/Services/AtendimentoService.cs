using System;
using System.Collections.Generic;
using System.Linq;
using TCC_BUGGY.Data;
using TCC_BUGGY.Models;
using TCC_BUGGY.Models.ViewModels;
using TCC_BUGGY.Services;


namespace TCC_BUGGY.Services
{
    public class AtendimentoService
    {
        private readonly TCC_BUGGYContext _context;

        


        public AtendimentoService(TCC_BUGGYContext context)
        {
            _context = context;
        }

        public List<Atendimento> FindAll()
        {
            return _context.Atendimento.ToList();
        }


        public OcorrenciaService OcorrenciaService { get; set; }

        public List<Ocorrencia> ListALL()
        {
            return _context.Ocorrencia.ToList();
        }



        public void Insert (Atendimento obj)
        {
            //Forçar id usuário (Corrigir depois para utilizar session id)
            obj.IdUsuario = 4;
            obj.DataOcorrencia = DateTime.Now;
            

         
               
            
          // if (obj.NomeOcorrencia = NomeOCorrencia )


            //

            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
