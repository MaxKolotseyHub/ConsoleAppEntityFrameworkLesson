using AutoMapper;
using NTierApp.BLL.Interfaces;
using NTierApp.BLL.Models;
using NTierApp.DAL.Entities;
using NTierApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly Mapper mapper;
        public EmployeeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            mapper = Automapper.GetMapper();
        }

        public void AddCompany(long companyId, long employeeId)
        {
            unitOfWork.Employees.Add(employeeId,companyId);
            unitOfWork.Save();
        }

        public void AddEmployee(EmployeeBLL employee)
        {
            var empl = mapper.Map<Employee>(employee);
            unitOfWork.Employees.Create(empl);
            unitOfWork.Save();
        }

        public void DeleteCompany(long companyId, long employeeId)
        {
            unitOfWork.Employees.DeleteInner(employeeId, companyId);
            unitOfWork.Save();
        }

        public void DeleteEmployee(long id)
        {
            unitOfWork.Employees.Delete(id);
            unitOfWork.Save();
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }

        public EmployeeBLL GetEmployee(long id)
        {
            var empl = unitOfWork.Employees.Get(id);
            if (empl != null)
                return mapper.Map<EmployeeBLL>(empl);
            else return null;
        }

        public ICollection<EmployeeBLL> GetEmployees()
        {
            return mapper.Map<List<EmployeeBLL>>(unitOfWork.Employees.GetAll());
        }

        public void Save()
        {
            unitOfWork.Save();
        }

        public void UpdateEmployee(EmployeeBLL employee)
        {
            unitOfWork.Employees.Update(mapper.Map<Employee>(employee));
            unitOfWork.Save();
        }
    }
}
