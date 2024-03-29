﻿// <auto-generated />
using System;
using ApiProductos.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace keviiiiien.Migrations
{
    [DbContext(typeof(ProductosContext))]
    partial class ProductosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ApiProductos.Model.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ApiProductos.Model.Productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoriaId");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Precio");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("ApiProductos.Model.Productos", b =>
                {
                    b.HasOne("ApiProductos.Model.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");
                });
#pragma warning restore 612, 618
        }
    }
}
