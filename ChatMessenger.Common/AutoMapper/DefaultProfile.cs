using ChatMessenger.Core.Models;
using ChatMessenger.Core.Models.Cache;
using ChatMessenger.Core.Models.Cache.Presentation;
using ChatMessenger.Core.Models.Db;
using ChatMessenger.Core.Models.DTO;
using AutoMapper.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace ChatMessenger.Common.AutoMapper
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            CreateMap<UserTokenSession, UserTokenSessionDTO>().ReverseMap();
            CreateMap<Message, MessageDTO>().ReverseMap();

            CreateMap<UserDTO, UserModel>().ReverseMap();
            CreateMap<UserTokenSessionDTO, UserTokenSessionModel>().ReverseMap();
            CreateMap<MessageDTO, MessageModel>().ReverseMap();

            CreateMap<UserDTO, UserCacheModel>().ReverseMap();
            CreateMap<UserTokenSessionDTO, UserTokenSessionCacheModel>().ReverseMap();
        }
    }
}
