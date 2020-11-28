using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/Endereco")]
    [ApiController]
    public class EnderecoAPIController : ControllerBase
    {
        private List<Endereco> lista = new List<Endereco>
        {
            new Endereco { Id = 1, Cep = "68976-970", Logradouro = "Rua Laurita Almeida Barbosa 115", Localidade = "Itaubal"},
            new Endereco { Id = 2, Cep = "87580-970", Logradouro = "Avenida Brasil 1813", Localidade = "Alto Piquiri"},
            new Endereco { Id = 3, Cep = "78770-970", Logradouro = "Avenida Sete de Setembro 459", Localidade = "Alto Garças"}
        };
        //private List<Endereco> lista = new List<Endereco>();

        //GET: /api/Endereco/Listar
        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {
            if (lista.Count == 0)
            {
                return BadRequest(new { msg = "Lista vazia" });
            }
            return Ok(lista);
        }

        //GET: /api/Endereco/Buscar/1
        [HttpGet]
        [Route("Buscar/{id}")]
        public IActionResult Buscar(int id)
        {
            var endereco = lista.FirstOrDefault(x => x.Id == id);
            if (endereco != null)
            {
                return Ok(endereco);
            }
            return NotFound(new { msg = "Endereço não encontrado!" });
        }

        //POST: /api/Endereco/Cadastrar
        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Cadastrar(Endereco endereco)
        {
            endereco.CriadoEm = DateTime.Now;
            lista.Add(endereco);
            return Created("", lista);
        }
    }
}
