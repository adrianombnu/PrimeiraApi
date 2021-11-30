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
        public void Delete(Guid id) => _usuarios.RemoveAll(x => x.Id == id);
        public void Update(Guid id, Usuario usuario)
        {
            _usuarios.Where(w => w.Id == id).ToList().ForEach(f => f.Documento = usuario.Documento);
            _usuarios.Where(w => w.Id == id).ToList().ForEach(f => f.Idade = usuario.Idade);
            _usuarios.Where(w => w.Id == id).ToList().ForEach(f => f.Nome = usuario.Nome);
            _usuarios.Where(w => w.Id == id).ToList().ForEach(f => f.Sobrenome = usuario.Sobrenome);

        } 

    }
}
