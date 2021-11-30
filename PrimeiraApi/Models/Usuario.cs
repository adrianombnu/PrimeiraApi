using System;

namespace PrimeiraApi.Models
{
    public class Usuario
    {
        public Usuario(Guid id )
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Documento { get; set; }
        public int Idade { get; set; }


    }
}
