using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChatMessenger.Core.Interfaces
{
    interface IEntity
    {
        [Key]
        int Id { get; set; }

        [Required]
        bool Deleted { get; set; }
    }
}
