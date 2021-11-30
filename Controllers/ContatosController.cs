using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tgamerApi.Data;
using tgamerApi.Models;

namespace tgamerApi.Controllers
{
    [Route("api/v1/contatos")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private DataContext _context;

       public ContatosController(DataContext context)
       {
            this._context = context;
       }

        [HttpPost]
        public Contato Create(Contato contatos)
        {
            var newContato = new Contato();

            newContato.nome = contatos.nome;
            newContato.celular = contatos.celular;
            newContato.usuarioId = contatos.usuarioId;

            _context.Contatos.Add(newContato);
            _context.SaveChanges();

            return newContato;
        }

        [HttpGet]
        public List<Contato> Get()
        {
            return _context.Contatos.ToList();
        }

        [HttpGet("{id:int}")]
        public Contato GetById(int id)
        {
            var result = _context.Contatos.FirstOrDefault(c => c.Id == id);
            _context.SaveChanges();

            return result;
        }

        [HttpPut("{id:int}")]
        public Contato Put(int id, Contato contato)
        {
            contato.Id = id;

            _context.Contatos.Update(contato);
            _context.SaveChanges();

            return contato;
        }

        [HttpDelete("{id:int}")]
        public Contato DeleteById(int id)
        {
            var result = _context.Contatos.FirstOrDefault(c => c.Id == id);
            _context.Contatos.Remove(result);
            _context.SaveChanges();

            return result;
        }
    }
}
