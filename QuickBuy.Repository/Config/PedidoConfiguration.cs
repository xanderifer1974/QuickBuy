using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entidades;

namespace QuickBuy.Repository.Config
{
   public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(u => u.Id);

            //Builder utiliza o padrão Fluent
            builder
                .Property(p => p.DataPedido)
                .IsRequired();
            builder
               .Property(p => p.UsuarioId)
               .IsRequired();
            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired();               
            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(10);
            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(20);
            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(p => p.NumeroEndereco)
                .IsRequired();
            builder
                .Property(p => p.FormaPagamentoId)
                .IsRequired();
           

                

        }
    }
}
