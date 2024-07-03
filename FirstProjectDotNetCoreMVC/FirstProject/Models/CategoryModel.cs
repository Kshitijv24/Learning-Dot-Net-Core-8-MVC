﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FirstProject.Models
{
    public class CategoryModel
    {
        [Key] 
        public int Id { get; set; }
        
        [Required] 
        [MaxLength(40)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        
        [DisplayName("Display Order")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}
