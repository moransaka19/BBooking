using AutoMapper;
using BBooking.Models;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBooking.Mapper
{
    public class AppMapperProfile : Profile
    {
        public AppMapperProfile()
        {
            CreateMap<Book, BookViewModel>()
                .ReverseMap();
        }
    }
}
