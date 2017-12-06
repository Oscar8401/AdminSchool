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
        [Required(ErrorMessage ="Please insert again")]
        [StringLength(50)]
        public string Football { get; set; }
        [Required(ErrorMessage ="Please insert again")]
        [StringLength(50)]
        public string Basketball { get; set; }
        [Required(ErrorMessage ="Please insert again")]
        [StringLength(50)]
        public string Tennis { get; set; }
        [Required(ErrorMessage ="Please insert again")]
        [StringLength(50)]
        public string Hoky { get; set; }
        [Required(ErrorMessage ="Please insert again")]
        [StringLength(50)]
        public string Ragkpi { get; set; }
    }
}