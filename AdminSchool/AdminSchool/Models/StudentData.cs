using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdminSchool.Models
{
    public class StudentData
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please insert your first name again")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Please insert again")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Age must be a number between 1 and 18")]
        [StringLength(2)]
        public int Age { get; set; }
        [Required(ErrorMessage ="Please insert again")]
        public SchoolClass SchoolClass { get; set; }
        [Required(ErrorMessage ="Please insert again")]
        public FavouritTopic FavouritTopic { get; set; }
    }

    public enum SchoolClass 
        {
        ChooseFromTheList,
        First,
        Secondry,
        Third,
        Fourth,
        Fifth,
        Sexith,
        Seven,
        Eight,
        Nein,
        Ten,
        Eleven,
        Tolv
        }
    public enum FavouritTopic
    {
        ChooseFromTheList,
        Fysiks,
        Sport,
        Literatur,
        History,
        Geography,
        Mathematic
    }
}