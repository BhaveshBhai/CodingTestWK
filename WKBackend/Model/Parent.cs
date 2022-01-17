using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WKBackend.Model
{
    public class Parent
    {
        [Key]
        public int ParentId { get; set; }
        public string Name { get; set; }
        public int FormId { get; set; }
        public virtual Child Children { get; set; }
    }
}
