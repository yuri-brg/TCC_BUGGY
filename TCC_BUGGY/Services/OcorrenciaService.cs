using TCC_BUGGY.Data;
using TCC_BUGGY.Models;
using System.Collections.Generic;
using System.Linq;

namespace TCC_BUGGY.Services
{
    public class OcorrenciaService
    {
        private readonly TCC_BUGGYContext _context;

        public OcorrenciaService(TCC_BUGGYContext context)
        {
            _context = context;
        }
        public List<Ocorrencia> FindAll()
        {
            return _context.Ocorrencia.ToList();
        }
    }
}
