﻿namespace FastFood.Data.Models
{
    using FastFood.Data.Common.EntityConfiguration;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(EntitiesValidation.CategoryNameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Item> Items { get; set; }
    }
}
