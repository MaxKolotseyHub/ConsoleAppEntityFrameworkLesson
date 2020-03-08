using AutoMapper;
using NTierApp.ASPMVC.Models;
using NTierApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTierApp.ASPMVC
{
    public class Automapper
    {
        private static Mapper mapper;
        public static Mapper GetMapper()
        {
            if (mapper == null)
            {

                var config = new MapperConfiguration(cfg =>
                {

                    cfg.CreateMap<CompanyBLL, CompaniesViewModel>()
                    .ForMember("EmployeesCount", opt=>opt.MapFrom(c=>c.Employees.Count))
                    .ForMember("Name", opt=>opt.MapFrom(c=>c.CompanyName))
                    .ForMember("Address", opt=>opt.MapFrom(c=>c.CompanyAddress));
                    cfg.CreateMap<CompaniesViewModel, CompanyBLL>();
                });

                mapper = new Mapper(config);
            }
            return mapper;
        }
    }
}