﻿using AutoMapper;
using ChatMessenger.BusinessLogicLayer.BusinessLogics;
using ChatMessenger.Core.Interfaces.BusinessLogics;
using ChatMessenger.DataAccessLayer.Data;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatMessenger.BusinessLogicLayer.Factories
{
    public class BLFactory : AbstractFactory
    {
        public BLFactory(ChatMessengerDbContext dbContext,
                         IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public override MessageBL CreateMessageBL()
        {
            return new MessageBL(_repos, _mapper);
        }

        public override IAccountBL CreateAccountBL(IMemoryCache memoryCache, IConfiguration configuration)
        {
            return new AccountBL(_repos, _mapper, memoryCache, configuration);
        }
    }
}
