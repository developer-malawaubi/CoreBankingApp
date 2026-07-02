using CoreBankingApp.Domain.Entities;

namespace CoreBankingApp.Application.Interfaces
{
    internal interface ITransactionRepository
    {
        Task AddAsync(Account Account);
    }
}
