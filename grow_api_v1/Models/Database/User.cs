using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using grow_api_v1.Models.Enums;

namespace grow_api_v1.Models
{
    public class User : BaseModel<Guid>
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

        public string FullName { get; set; }

        public string Email { get; set; }

        public bool Registered { get; set; }
        public Location Locations { get; set; }
        public Guid LocationId { get; set; }
        public List<UserRole> Roles { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}