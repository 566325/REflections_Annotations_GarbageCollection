using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotations
{
    internal class Employee
    {
        [Required(ErrorMessage ="Employee Name is Required")]
        [StringLength(100,MinimumLength =3,ErrorMessage ="Name should have Minimum 3 characters and max 100")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Range(18,99,ErrorMessage ="Age should be 18 and 99")]
        public int Age { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
