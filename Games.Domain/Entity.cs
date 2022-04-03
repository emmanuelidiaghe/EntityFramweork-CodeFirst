using System;
using System.ComponentModel.DataAnnotations;

namespace Games.Domain
{
    public abstract class Entity
    {
        [Key]
        public Guid id { get; set; }
    }
}