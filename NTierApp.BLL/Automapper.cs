using AutoMapper;
using NTierApp.BLL.Models;
using NTierApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL
{
    class Automapper
    {
        private static Mapper mapper;
        public static Mapper GetMapper()
        {
            if (mapper == null)
            {

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Employee, EmployeeBLL>()
                    .ForMember("FullName", opt=>opt.MapFrom(c=>c.FirstName + " " + c.LastName));
                    cfg.CreateMap<EmployeeBLL, Employee>()
                    .ForMember("FirstName", opt=>opt.MapFrom(c=>c.FullName.Split(' ')[0]))
                    .ForMember("LastName", opt=>opt.MapFrom(c=>c.FullName.Split(' ')[1]));

                    cfg.CreateMap<Company, CompanyBLL>()
                    .ForMember("CompanyAddress", opt=>opt.MapFrom(c=>c.Address))
                    .ForMember("CompanyName", opt=>opt.MapFrom(c=>c.Name));
                    cfg.CreateMap<CompanyBLL, Company>()
                    .ForMember("Address", opt=>opt.MapFrom(c=>c.CompanyAddress))
                    .ForMember("Name", opt=>opt.MapFrom(c=>c.CompanyName));
                });

                mapper = new Mapper(config);
            }
            return mapper;
        }
    }
}
