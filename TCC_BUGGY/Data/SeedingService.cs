using System.Linq;
using TCC_BUGGY.Data;
using TCC_BUGGY.Models;

namespace TCC_BUGGY.Data
{
    public class SeedingService
    {
        private TCC_BUGGYContext _context;

        public SeedingService(TCC_BUGGYContext context)
        {
            _context = context;
        }

        // public void Seed()
        //{
        //    if (_context.Ocorrencia.Any() ||
        //        _context.Atendimento.Any() ||
        //        _context.Cliente.Any() ||
        //        _context.Usuario.Any())

        //        {
        //            return; //banco de dados já foi preenchido
        //    }

  

        //}
    }
}
