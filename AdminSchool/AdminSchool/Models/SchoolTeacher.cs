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
        [StringLength(2)]
        public int Age { get; set; }
        [Required(ErrorMessage ="Sallary should be a number with min 13000 and ma 50000")]
        [StringLength(6)]
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