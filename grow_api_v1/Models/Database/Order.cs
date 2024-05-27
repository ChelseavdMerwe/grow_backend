using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grow_api_v1.Models
{
    public class Order
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
       
        public List<Stock> Stock { get; set; }
        public string? ReferenceNumber { get; set; }
        public User User { get; set; }
    }
}