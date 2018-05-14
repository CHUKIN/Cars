using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Cars.Models
{
    public class Model
    {
        public int Id { get; set; }
        [DisplayName("Model name")]
        public string Name { get; set; }

        public List<Car> Cars { get; set; }

        public Model()
        {
            Cars = new List<Car>();
        }
    }
}