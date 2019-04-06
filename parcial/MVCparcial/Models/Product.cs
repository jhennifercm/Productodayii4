using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCparcial.Models


{
    public enum UniType
    {
        Botella,
        caja,
        litro
    }

    public enum StatusType
    {
        Activo, 
        Inactivo
    }
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public UniType Unit { get; set; }

        public StatusType Status { get; set; }
    }
}