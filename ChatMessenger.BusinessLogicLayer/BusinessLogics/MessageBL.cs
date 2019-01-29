using AutoMapper;
using ChatMessenger.Core.Interfaces.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatMessenger.BusinessLogicLayer.BusinessLogics
{
    class MessageBL : BaseBl
    {
        public MessageBL(IRepositoriesUnitOfWork repos, IMapper mapper)
          : base(repos, mapper)
        {
        }
    }
}
