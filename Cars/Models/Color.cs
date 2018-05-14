using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Cars.Models
{
    public class Color
    {
        public int Id { get; set; }
        [DisplayName("Color name")]
        public string Name { get; set; }

        public List<Car> Cars { get; set; }

        public Color()
        {
            Cars = new List<Car>();
        }
    }
}