using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBankingApp.Domain.Entities;

namespace CoreBankingApp.Application.Interfaces
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer);
    }
}
