//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using TCC_BUGGY.Data;
//using TCC_BUGGY.Models;

//namespace TCC_BUGGY.Views.Atendimentos
//{
//    public class AtendimentosController : Controller
//    {
//        private readonly TCC_BUGGYContext _context;

//        public AtendimentosController(TCC_BUGGYContext context)
//        {
//            _context = context;
//        }

//        // GET: Atendimentos
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.Atendimento.ToListAsync());
//        }

//        // GET: Atendimentos/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var atendimento = await _context.Atendimento
//                .FirstOrDefaultAsync(m => m.IdAtendimento == id);
//            if (atendimento == null)
//            {
//                return NotFound();
//            }

//            return View(atendimento);
//        }

//        // GET: Atendimentos/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Atendimentos/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("IdAtendimento,IdCliente,IdOcorrencia,IdUsuario,NomeOcorrencia,Complemento,DataOcorrencia,Telefone")] Atendimento atendimento)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(atendimento);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(atendimento);
//        }

//        // GET: Atendimentos/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var atendimento = await _context.Atendimento.FindAsync(id);
//            if (atendimento == null)
//            {
//                return NotFound();
//            }
//            return View(atendimento);
//        }

//        // POST: Atendimentos/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("IdAtendimento,IdCliente,IdOcorrencia,IdUsuario,NomeOcorrencia,Complemento,DataOcorrencia,Telefone")] Atendimento atendimento)
//        {
//            if (id != atendimento.IdAtendimento)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(atendimento);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!AtendimentoExists(atendimento.IdAtendimento))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(atendimento);
//        }

//        // GET: Atendimentos/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var atendimento = await _context.Atendimento
//                .FirstOrDefaultAsync(m => m.IdAtendimento == id);
//            if (atendimento == null)
//            {
//                return NotFound();
//            }

//            return View(atendimento);
//        }

//        // POST: Atendimentos/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var atendimento = await _context.Atendimento.FindAsync(id);
//            _context.Atendimento.Remove(atendimento);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool AtendimentoExists(int id)
//        {
//            return _context.Atendimento.Any(e => e.IdAtendimento == id);
//        }
//    }
//}
