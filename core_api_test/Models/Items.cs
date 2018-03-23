using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core_api_test.Models
{
    public class Items
    {
        [Key]
        public int itemId { get; set; }
        public int itemDesc { get; set; }
    }
}
