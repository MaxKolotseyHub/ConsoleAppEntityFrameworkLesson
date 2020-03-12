using AutoMapper;
using NTierApp.ASPMVC.Models;
using NTierApp.ASPMVC.Models.Company;
using NTierApp.ASPMVC.Models.Employee;
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
                    .ForMember("EmployeesCount", opt => opt.MapFrom(c => c.Employees.Count));
                    cfg.CreateMap<CompaniesViewModel, CompanyBLL>();

                    cfg.CreateMap<EditEmployeeViewModel, EmployeeBLL>()
                    .ForMember("FullName", opt => opt.MapFrom(c => c.FirstName + " " + c.LastName));

                    cfg.CreateMap<CompanyBLL, EditCompanyViewModel>();
                    cfg.CreateMap<EditCompanyViewModel, CompanyBLL>();

                    cfg.CreateMap<CreateCompanyViewModel, CompanyBLL>();
                    cfg.CreateMap<CompanyBLL, CreateCompanyViewModel>();

                    cfg.CreateMap<CreateEmployeeViewModel, EmployeeBLL>()
                    .ForMember("FullName", opt => opt.MapFrom(c => c.FirstName + " " + c.LastName));

                    cfg.CreateMap<EmployeeBLL, CreateEmployeeViewModel>()
                    .ForMember("FirstName", opt => opt.MapFrom(c => c.FullName.Split(' ')[0]))
                    .ForMember("LastName", opt => opt.MapFrom(c => c.FullName.Split(' ')[1]));


                    cfg.CreateMap<DetailsCompanyViewModel, CompanyBLL>();
                    cfg.CreateMap<CompanyBLL, DetailsCompanyViewModel>();

                    cfg.CreateMap<EmployeeBLL, EditEmployeeViewModel>()
                    .ForMember("FirstName", opt => opt.MapFrom(c => c.FullName.Split(' ')[0]))
                    .ForMember("LastName", opt => opt.MapFrom(c => c.FullName.Split(' ')[1]));
                    cfg.CreateMap<EmployeeBLL, EmployeesViewModel>()
                    .ForMember("CompaniesCount", opt=>opt.MapFrom(c=>c.Companies.Count));
                    cfg.CreateMap<EmployeesViewModel, EmployeeBLL>();

                    cfg.CreateMap<EmployeeBLL, DetailsEmployeeViewModel>();
                    cfg.CreateMap<DetailsEmployeeViewModel, EmployeeBLL>();

                });

                mapper = new Mapper(config);
            }
            return mapper;
        }
    }
}