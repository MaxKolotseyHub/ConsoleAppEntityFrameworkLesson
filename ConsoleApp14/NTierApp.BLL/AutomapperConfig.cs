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
        static Mapper mapper;
        public static Mapper GetMapper()
        {
            if (mapper == null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Employee, EmployeeModel>();
                    cfg.CreateMap<EmployeeModel, Employee>();
                });

                mapper = new Mapper(config);
            }

            return mapper;
        }
    }
}
