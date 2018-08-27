using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStoreMvc.Models
{
    public class BookViewModel
    {
        public string BookNumber { get; set;}
        [Required]
        [Display(Name = "Book Name")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public double Reiting { get; set; }
    }
}