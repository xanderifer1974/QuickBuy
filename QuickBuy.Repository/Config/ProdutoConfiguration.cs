﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entidades;

namespace QuickBuy.Repository.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(u => u.Id);

            //Builder utiliza o padrão Fluent
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
               .Property(p => p.Descricao)
               .IsRequired()
               .HasMaxLength(200);
            builder
                .Property(p => p.Preco)
                .IsRequired();               
                     
        }
    }
}
