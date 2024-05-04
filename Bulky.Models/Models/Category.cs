using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models.Models
{
    public class Category
    {
        [Key]
        
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }

        [Required]
        [Range(1,100,ErrorMessage ="It should not be more than 100")]
        public int? DisplayOrder {  get; set; }


    }
}
