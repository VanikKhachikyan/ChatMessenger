using ChatMessenger.Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatMessenger.Core.Models.Db
{
    public class User : IdentityUser<int>,IEntity
    {
        public User()
        {
            Messages = new List<Message>();
        }

        public virtual ICollection<Message> Messages { get; set; }

        public bool Deleted { get; set; }
    }
}
