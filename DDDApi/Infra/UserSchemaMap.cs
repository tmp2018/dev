using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DDDAPI.Infra.schemas;

public class UserSchemaMap : IEntityTypeConfiguration<UserSchema>
    {
        public void Configure(EntityTypeBuilder<UserSchema> builder)
        {
            builder.ToTable("User");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.NIF)
                .IsRequired()
                .HasColumnName("Nif")
                .HasColumnType("int");

            builder.Property(prop => prop.Name)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Email")
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Password)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Password")
                .HasColumnType("varchar(100)");
        }
    }