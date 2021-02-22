using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SehirRehberi.API.Dtos;
using SehirRehberi.API.Models;

namespace SehirRehberi.API.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City, CityForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt =>
                {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                                //City de yer alan Photos alanını Photos modelindeki urlden alarak doldur ama first ordefault dedigimiz icin ilkini al cunku city Photos ta url tekil string ama city alanında bu bir list 
                });
            CreateMap<City, CityForDetailDto>();
        }
    }
}
