﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlmeidaSebastian_ExamenProgreso1.Migrations
{
    [DbContext(typeof(SebastianAlmeidaContext))]
    partial class SebastianAlmeidaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlmeidaSebastian_ExamenProgreso1.Models.Almeida", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("DonanteOrganos")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCelular")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<int>("celularId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("celularId");

                    b.ToTable("Almeida");
                });

            modelBuilder.Entity("AlmeidaSebastian_ExamenProgreso1.Models.Celular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Celular");
                });

            modelBuilder.Entity("AlmeidaSebastian_ExamenProgreso1.Models.Almeida", b =>
                {
                    b.HasOne("AlmeidaSebastian_ExamenProgreso1.Models.Celular", "celular")
                        .WithMany()
                        .HasForeignKey("celularId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("celular");
                });
#pragma warning restore 612, 618
        }
    }
}
