﻿// <auto-generated />
using FinalProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Migrations
{
    [DbContext(typeof(Conexion))]
    [Migration("20210416013923_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("FinalProject.Accidente", b =>
                {
                    b.Property<int>("AccidenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hora")
                        .HasColumnType("TEXT");

                    b.Property<string>("Latitud")
                        .HasColumnType("TEXT");

                    b.Property<string>("Longitud")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lugar")
                        .HasColumnType("TEXT");

                    b.HasKey("AccidenteId");

                    b.ToTable("Accidentes");
                });

            modelBuilder.Entity("FinalProject.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("FinalProject.Involucrado", b =>
                {
                    b.Property<int>("InvolucradoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccidenteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.HasKey("InvolucradoId");

                    b.HasIndex("AccidenteId");

                    b.ToTable("Involucrados");
                });

            modelBuilder.Entity("FinalProject.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("FinalProject.Involucrado", b =>
                {
                    b.HasOne("FinalProject.Accidente", "Accidente")
                        .WithMany("Involucrados")
                        .HasForeignKey("AccidenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accidente");
                });

            modelBuilder.Entity("FinalProject.Post", b =>
                {
                    b.HasOne("FinalProject.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("FinalProject.Accidente", b =>
                {
                    b.Navigation("Involucrados");
                });

            modelBuilder.Entity("FinalProject.Blog", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
