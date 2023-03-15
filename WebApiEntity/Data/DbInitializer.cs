using Microsoft.EntityFrameworkCore;
using WebApiEntity.Models;

namespace WebApiEntity.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _builder;

        public DbInitializer(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void Seed()
        {
            _builder.Entity<Cliente>(a =>
            {
                a.HasData(new Cliente
                {
                    cliente  = "1",
                    Nome = "J.K. Rowling",
                    NomeFiscal = "J.K. Rowling",
                    DataCriacao = new DateTime(2015, 12, 31),
                    TotalDeb = 323232,

                });
                a.HasData(new Cliente
                {
                    cliente = "02555",
                    Nome = "Aaaa J.K. Rowling",
                    NomeFiscal = "F.K. Nothing",
                    DataCriacao = new DateTime(2015, 12, 31),
                    TotalDeb = 2.5,
                });
            });


        }
    }
}
