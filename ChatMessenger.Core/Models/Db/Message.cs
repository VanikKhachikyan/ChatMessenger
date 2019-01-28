using ChatMessenger.Core.Interfaces;
using ChatMessenger.Core.Models.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ChatMessenger.Core.Models
{
    public class Message: IEntity
    {
        public int Id { get; set; }

        [Required]
        public int ToId { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public bool Deleted { get; set; }
    }
}
