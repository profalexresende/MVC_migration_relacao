﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using migration_relacao_atual.Data;

#nullable disable

namespace migration_relacao_atual.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("migration_relacao_atual.Models.CarteiraMotorista", b =>
                {
                    b.Property<int>("CarteiraMotoristaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarteiraMotoristaId"));

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("DATE");

                    b.HasKey("CarteiraMotoristaId");

                    b.ToTable("CarteirasMotorista");
                });

            modelBuilder.Entity("migration_relacao_atual.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<int>("CarteiraMotoristaId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("ClienteId");

                    b.HasIndex("CarteiraMotoristaId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("migration_relacao_atual.Models.Cliente", b =>
                {
                    b.HasOne("migration_relacao_atual.Models.CarteiraMotorista", "Cnh")
                        .WithMany()
                        .HasForeignKey("CarteiraMotoristaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cnh");
                });
#pragma warning restore 612, 618
        }
    }
}
