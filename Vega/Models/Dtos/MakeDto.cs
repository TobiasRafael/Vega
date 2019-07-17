using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.Models.Dtos
{
    public class MakeDto
    {
        public int Id { get; set; }
               
        public string Name { get; set; }

        public Model Models { get; set; }
    }
}
