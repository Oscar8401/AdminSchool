using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdminSchool.Models
{
    public class Sport
    {
        public int Id { get; set; }
        [Required]
        public string Football { get; set; }
        [Required]
        public string Basketball { get; set; }
        [Required]
        public string Tennis { get; set; }
        [Required]
        public string Hoky { get; set; }
        [Required]
        public string Ragkpi { get; set; }
    }
}