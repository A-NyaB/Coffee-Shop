﻿using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Coffee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        public int BeanVarietyId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        BeanVariety beanVariety{ get; set; }
    } 
}
