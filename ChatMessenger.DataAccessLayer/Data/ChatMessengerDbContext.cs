using ChatMessenger.Core.Models;
using ChatMessenger.Core.Models.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatMessenger.DataAccessLayer.Data
{
    public class ChatMessengerDbContext : DbContext
    {
        public ChatMessengerDbContext(DbContextOptions<ChatMessengerDbContext> options)
            : base(options)
        {

        }

        internal virtual DbSet<User> Users { get; set; }
        internal virtual DbSet<Message> Messages { get; set; }

    }
}
