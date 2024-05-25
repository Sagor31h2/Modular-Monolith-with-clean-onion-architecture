using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Core.Entity
{
    public class Locations
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
