using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using grow_api_v1.Constants.Enums;
using grow_api_v1.Models.Enums;

namespace grow_api_v1.Models
{
    public class Stock
    {
        /// <summary>
        ///     Gets or sets the unique identifier.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id
        {
            set => Guid.NewGuid();
            get => Id;
        }
        
        public string Season { get; set; }
        public double Amount { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
    }
}