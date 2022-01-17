using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WKBackend.Model
{
    public class Child
    {
        public int ChildId { get; set; }
        public int ParentId { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]{0,50}$",ErrorMessage = "Please enter a valid first name")]
        public string FirstName { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]{0,50}$", ErrorMessage = "Please enter a valid last name")]
        public string LastName { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]{0,50}$", ErrorMessage = "Please enter a valid middle name")]
        public string MiddleName { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]{0,50}$", ErrorMessage = "Please enter a valid contact number")]
        public string ContactNumber { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]{0,50}$", ErrorMessage = "Please enter a valid city")]
        public string City { get; set; }
    }
}
