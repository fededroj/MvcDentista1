﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcDentista1.Data;

namespace MvcDentista1.Migrations
{
    [DbContext(typeof(MvcDentista1Context))]
    partial class MvcDentista1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcDentista1.Models.Diente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Diente1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente17")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente18")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente19")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente20")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente21")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente22")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente23")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente24")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente25")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente26")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente27")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente28")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente29")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente31")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente32")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diente9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Diente");
                });

            modelBuilder.Entity("MvcDentista1.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domicilio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Localidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObraSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAsistencia")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("MvcDentista1.Models.Turno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaTurno")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Turno");
                });
#pragma warning restore 612, 618
        }
    }
}