using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WKBackend.Model
{
    public class Form
    {
        [Key]
        public int FormId { get; set; }
        public string Name { get; set; }
    }
}
