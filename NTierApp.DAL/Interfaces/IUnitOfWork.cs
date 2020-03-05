﻿using NTierApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable //unit of work предоставляет общий контекст для всех репозиториев
    {
        IRepository<Employee>Employees { get; }
        IRepository<Company>Companies { get; }
        void Save();
    }
}
