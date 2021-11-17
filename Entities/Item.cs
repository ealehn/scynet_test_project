using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Entities
{
    public class Item
    {
        [Required]
        public Guid id {get;set;}
        [Required]
        public string name {get;set;}
        [Required]
        public double quantity {get;set;}
        [Required]
        public double net_amount {get;set;}
        [Required]
        public double gross_amount {get;set;}
        [Required]
        public string description {get;set;}
        [Required]
        public string item_category {get;set;}
        [Required]
        public string item_unit {get;set;}
        [Required]
        public double tax {get;set;}
        [Required]
        public double discount {get;set;}
    }
}