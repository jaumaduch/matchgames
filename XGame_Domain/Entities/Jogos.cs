using System;

namespace XGame_Domain.Entities
{
    public class Jogos
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Produtora { get; set; }

        public string Distribuidora { get; set; }

        public string Genero { get; set; }

        public string Site { get; set; }
    }
}
