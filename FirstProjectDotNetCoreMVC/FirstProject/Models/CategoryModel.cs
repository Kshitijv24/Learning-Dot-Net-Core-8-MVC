﻿using System.ComponentModel.DataAnnotations;

namespace FirstProject.Models
{
    public class CategoryModel
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
