using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.Models;
using PrimeiraApi.Services;
using System;
using System.Collections.Generic;

namespace PrimeiraApi.Controllers
{
    [ApiController, Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService; 
        }


        [HttpGet, Route("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_usuarioService.Get(id));

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_usuarioService.Get());

        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            _usuarioService.Add(usuario);
                
            return Created("",usuario);

        }

        [HttpPut, Route("{id}")]
        public IActionResult Update(Guid id, Usuario usuario)
        {
            try
            {
                _usuarioService.Update(id, usuario);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }

            return Created("Usuário alterado com sucesso!", usuario);

        }

        [HttpDelete, Route("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _usuarioService.Delete(id);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
                
            }

            return Ok("Registro deletado com sucesso.");

        }

    }
}
