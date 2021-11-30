using PrimeiraApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeiraApi.Services
{
    public class UsuarioService
    {
        private readonly List<Usuario> _usuarios = new();

        public UsuarioService()
        {

        }

        public Usuario Get(Guid id) => _usuarios.Where(u => u.Id == id).SingleOrDefault();
        public IEnumerable<Usuario> Get() => _usuarios;
        public void Add(Usuario usuario) => _usuarios.Add(usuario);
        public void Delete(Guid id)
        {
            var usuario = _usuarios.SingleOrDefault(u => u.Id == id);

            if (usuario is null)
                throw new Exception("Usuario não encontrado!");

            _usuarios.Remove(usuario);
        }

        public void Update(Guid id, Usuario usuario)
        {
            var user = _usuarios.SingleOrDefault(u => u.Id == id);

            if (user is null)
                throw new Exception("Usuario não encontrado!");

            user.Idade = usuario.Idade;
            user.Documento = usuario.Documento;
            user.Nome = usuario.Nome;
            user.Sobrenome = usuario.Sobrenome;    

        } 

    }
}
