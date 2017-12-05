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
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public SchoolClass SchoolClass { get; set; }
        [Required]
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