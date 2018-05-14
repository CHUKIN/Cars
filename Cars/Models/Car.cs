using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cars.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public int ModelId { get; set; }
        public Model Model { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; }
    }
}