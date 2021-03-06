﻿using Entidades;
using System.Data.Entity;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<ProductosDetalle> ProductosDetalle { get; set; }
       public DbSet<Ventas> Ventas { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
