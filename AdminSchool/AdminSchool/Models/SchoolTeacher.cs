using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdminSchool.Models
{
    public class SchoolTeacher
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Age should be a number between 1 to 18")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Please insert again")]
        public int Salary { get; set; }
        [Required(ErrorMessage ="Please insert your first name again")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Please insert your last name again")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Please insert a valid position")]
        [StringLength(50)]
        public string Position { get; set; }
    }
}