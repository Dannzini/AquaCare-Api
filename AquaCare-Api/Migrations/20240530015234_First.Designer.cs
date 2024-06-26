﻿// <auto-generated />
using System;
using AquaCareAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace AquaCare_Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240530015234_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AquaCare_Api.Model.Cidade", b =>
                {
                    b.Property<int>("CodigoCidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoCidade"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("CodigoCidade");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("AquaCare_Api.Model.Indicador", b =>
                {
                    b.Property<int>("CodigoIndicador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoIndicador"));

                    b.Property<int>("CodigoLocal")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("DataHoraMedicao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("NivelColiformes")
                        .HasColumnType("NUMBER(10)");

                    b.Property<decimal>("NivelOxigenioDissolvido")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<decimal>("NivelPH")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<decimal>("NivelTemperatura")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<decimal>("NivelTurbidez")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.HasKey("CodigoIndicador");

                    b.HasIndex("CodigoLocal");

                    b.ToTable("Indicadores");
                });

            modelBuilder.Entity("AquaCare_Api.Model.Local", b =>
                {
                    b.Property<int>("CodigoLocal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoLocal"));

                    b.Property<int>("CodigoCidade")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("CodigoLocal");

                    b.HasIndex("CodigoCidade");

                    b.ToTable("Locais");
                });

            modelBuilder.Entity("AquaCare_Api.Model.Usuario", b =>
                {
                    b.Property<int>("CodigoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoUsuario"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("CodigoUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AquaCare_Api.Model.Indicador", b =>
                {
                    b.HasOne("AquaCare_Api.Model.Local", "Local")
                        .WithMany()
                        .HasForeignKey("CodigoLocal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Local");
                });

            modelBuilder.Entity("AquaCare_Api.Model.Local", b =>
                {
                    b.HasOne("AquaCare_Api.Model.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CodigoCidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });
#pragma warning restore 612, 618
        }
    }
}
