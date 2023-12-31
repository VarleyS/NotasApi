﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotaAlunoApi.Data;

#nullable disable

namespace NotaAlunoApi.Migrations
{
    [DbContext(typeof(AlunoContext))]
    [Migration("20230910180720_alterando preferencias")]
    partial class alterandopreferencias
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NotaAlunoApi.Model.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("NotaAlunoApi.Model.Nota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("Ciencias")
                        .HasColumnType("int");

                    b.Property<int>("Geografia")
                        .HasColumnType("int");

                    b.Property<int>("Historia")
                        .HasColumnType("int");

                    b.Property<int>("Ingles")
                        .HasColumnType("int");

                    b.Property<int>("Matematica")
                        .HasColumnType("int");

                    b.Property<int>("Portugues")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId")
                        .IsUnique();

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("NotaAlunoApi.Model.Nota", b =>
                {
                    b.HasOne("NotaAlunoApi.Model.Aluno", "Aluno")
                        .WithOne("Nota")
                        .HasForeignKey("NotaAlunoApi.Model.Nota", "AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("NotaAlunoApi.Model.Aluno", b =>
                {
                    b.Navigation("Nota")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
