using AutoMapper;
using ChatMessenger.Core.Interfaces.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatMessenger.BusinessLogicLayer.BusinessLogics
{
    class BaseBl : IDisposable
    {
        protected readonly IRepositoriesUnitOfWork _repos;
        protected readonly IMapper _mapper;

        public BaseBl(IRepositoriesUnitOfWork repos,IMapper mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }

        public virtual void Dispose()
        {
            _repos.Dispose();
        }
    }
}
