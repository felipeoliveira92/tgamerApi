using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tgamerApi.Data;
using tgamerApi.Dto;
using tgamerApi.Models;

namespace tgamerApi.Controllers
{
    [ApiController]
    [Route("api/v1/conquistas")]
    public class ConquistasController : Controller
    {
        private DataContext _context;

        public ConquistasController(DataContext context)
        {
            this._context = context;
        }

        [HttpPost("{id:int}")]
        public Conquistas Create(int id, Conquistas conquista)
        {
            conquista.UsuarioId = id;

            var newconquista = new Conquistas(conquista);

            _context.Conquistas.Add(newconquista);
            _context.SaveChanges();

            return newconquista;
        }

        [HttpGet]
        public List<Conquistas> GetConquistas()
        {
            return _context.Conquistas.ToList();
        }

        [HttpGet("{id:int}")]
        public Conquistas GetById(int id)
        {
            var result = _context.Conquistas.FirstOrDefault(u => u.Id == id);
            return result;
        }

        [HttpPut("{id:int}")]
        public Conquistas Put(int id, Conquistas conquista)
        {
            conquista.Id = id;
            _context.Update(conquista);
            _context.SaveChanges();
            return conquista;
        }

        [HttpDelete("{id:int}")]
        public Conquistas Delete(int id)
        {
            var result = _context.Conquistas.FirstOrDefault(c => c.Id == id);
            _context.Conquistas.Remove(result);
            _context.SaveChanges();

            return result;
        }
    }
}
