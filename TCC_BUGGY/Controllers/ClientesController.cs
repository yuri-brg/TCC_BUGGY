﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TCC_BUGGY.Data;
using TCC_BUGGY.Models;


namespace TCC_BUGGY.Controllers
{
    public class ClientesController : Controller
    {

        private readonly TCC_BUGGYContext _context;
       // private readonly 

        public ClientesController(TCC_BUGGYContext context)
        {
            _context = context;
        }

        



            // GET: Clientes
            // public async Task<IActionResult> Index()
            // {
            //     return View(await _context.Cliente.ToListAsync());
            // }

            public async Task<IActionResult> Index(string searchString)
       {
           var Cliente =  from m in _context.Cliente
                          select m;
    
           if (!String.IsNullOrEmpty(searchString))
           {
               Cliente = Cliente.Where(s => s.Cpf!.Contains(searchString));
           }
    
           return View(await Cliente.ToListAsync());
               
       }


        // GET: Clientes/Details/5


        

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente





                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);










        }




        // GET: Ocorrencias/Details/5
// public async Task<IActionResult> GetActionAsync(int? id)
// {
//     if (id == null)
//     {
//         return NotFound();
//     }
//
//     var ocorrencia = await _context.Ocorrencia
//         .FirstOrDefaultAsync(m => m.IdOcorrencia == id);
//     if (ocorrencia == null)
//     {
//         return NotFound();
//     }
//
//     return View(ocorrencia);
// }





        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCliente,Nome,Cpf,Genero,DataNascimento,Telefone,Email,Endereco,Cidade,UF,Cep")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCliente,Nome,Cpf,Genero,DataNascimento,Telefone,Email,Endereco,Cidade,UF,Cep")] Cliente cliente)
        {
            if (id != cliente.IdCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.IdCliente))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.IdCliente == id);
        }






    }
}
