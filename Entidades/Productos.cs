﻿using System;
using System.ComponentModel.DataAnnotations;


namespace Entidades
{
    [Serializable]
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public string TipoProducto { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }


        public Productos()
        {
            ProductoId = 0;
            NombreProducto = string.Empty;
            TipoProducto = string.Empty;
            Precio = 0;
            Descripcion = string.Empty;
            Fecha = DateTime.Now;
        }
    }
}
