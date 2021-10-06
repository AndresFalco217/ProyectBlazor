using Microsoft.EntityFrameworkCore;
using MITIENDA.Blazor.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MITIENDA.Blazor.Data
{
    public class MiTiendaDbContext : DbContext
    {
        public MiTiendaDbContext(DbContextOptions<MiTiendaDbContext> options) : base(options)
        {
                
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetallesFactura> DetallesFacturas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        //Sobre escribir metodos.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Categorias
            var categorias = modelBuilder.Entity<Categoria>();
            categorias.HasKey(x => x.Id); //Representa clave primaria de la db.
            categorias.Property(x =>x.Id).ValueGeneratedOnAdd(); //Representa Autoincrementable.

            categorias.HasMany(x => x.Productos) //Representa que tiene varios productos.
            .WithOne(x => x.Categoria) //Representa que esta linea producto tiene una categoria.
            .HasForeignKey(x => x.IdCategoria); //Llave Foranea.

            //Clientes
            var clientes = modelBuilder.Entity<Cliente>();
            clientes.HasKey(x => x.Id); //Representa clave primaria de la db.
            clientes.Property(x => x.Id).ValueGeneratedOnAdd(); //Representa Autoincrementable.

            clientes.HasMany(x => x.Facturas) //Representa que tiene varias Facturas.
            .WithOne(x => x.Cliente) //Representa que esta linea producto tiene una categoria.
            .HasForeignKey(x => x.IdCliente); //Llave Foranea.

            //Roles
            var roles = modelBuilder.Entity<Rol>();
            roles.HasKey(x => x.Id); //Representa clave primaria de la db.
            roles.Property(x => x.Id).ValueGeneratedOnAdd(); //Representa Autoincrementable.

            roles.HasMany(x => x.Usuarios) //Representa que tiene varios Usuarios.
            .WithOne(x => x.Rol) //Representa que esta linea producto tiene una categoria.
            .HasForeignKey(x => x.IdRol); //Llave Foranea.

            //Productos
            var productos = modelBuilder.Entity<Producto>();
            productos.HasKey(x => x.Id); //Representa clave primaria de la db.
            productos.Property(x => x.Id).ValueGeneratedOnAdd(); //Representa Autoincrementable.

            productos.HasMany(x => x.DetallesFacturas) //Representa que tiene varios DetallesFacturas.
            .WithOne(x => x.Producto) //Representa que esta linea producto tiene una categoria.
            .HasForeignKey(x => x.IdProducto); //Llave Foranea.

            //Facturas
            var facturas = modelBuilder.Entity<Factura>();
            facturas.HasKey(x => x.Id); //Representa clave primaria de la db.
            facturas.Property(x => x.Id).ValueGeneratedOnAdd(); //Representa Autoincrementable.

            facturas.HasMany(x => x.DetallesFacturas) //Representa que tiene varios DetallesFacturas.
            .WithOne(x => x.Factura) //Representa que esta linea producto tiene una categoria.
            .HasForeignKey(x => x.IdFactura); //Llave Foranea.

            //Detalles Facturas
            var detalles = modelBuilder.Entity<DetallesFactura>();
            detalles.HasKey(x => x.Id); //Representa clave primaria de la db.
            detalles.Property(x => x.Id).ValueGeneratedOnAdd(); //Representa Autoincrementable.

            //Usuarios
            var usuarios = modelBuilder.Entity<Usuario>();
            usuarios.HasKey(x => x.Id); //Representa clave primaria de la db.
            usuarios.Property(x => x.Id).ValueGeneratedOnAdd(); //Representa Autoincrementable.
        }
    }
}
