using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using XGame_Domain.Entities;

namespace XGame_Infra.Persistence.Map
{
    public class MapJogador : EntityTypeConfiguration<Jogador>
    {
        public MapJogador()
        {
            ToTable("TB_JOGADOR");

            Property(p => p.Email.EnderecoEmail).HasMaxLength(200).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_JOGADOR_EMAIL") { IsUnique = true})).HasColumnName("EMAIL");
            Property(p => p.Nome.PrimeiroNome).HasMaxLength(200).IsRequired().HasColumnName("PRIMEIRO_NOME");
            Property(p => p.Nome.UltimoNome).HasMaxLength(200).IsRequired().HasColumnName("SEGUNDO_NOME");
            Property(p => p.Senha).IsRequired();
            Property(p => p.Status).IsRequired();

        }
    }
}
