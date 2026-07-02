using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBankingApp.Application.Interfaces;
using CoreBankingApp.Domain.Entities;
using CoreBankingApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CoreBankingApp.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BankingDbContext _context;

        public CustomerRepository(IDbContextFactory<BankingDbContext> factory)
        {
            _context = factory.CreateDbContext();
        }
        public Task AddAsync(Customer Customer)
        {
            throw new NotImplementedException();
        }
    }

}
