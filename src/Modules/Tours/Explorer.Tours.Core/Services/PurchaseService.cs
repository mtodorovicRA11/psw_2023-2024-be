using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Explorer.Tours.Core.Domain;
using Explorer.Tours.Infrastructure.Repositories;

namespace Explorer.Tours.Core.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _purchaseRepository;

        public PurchaseService(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        public async Task<IEnumerable<Purchase>> GetAllPurchasesAsync()
        {
            return await _purchaseRepository.GetAllAsync();
        }

        public async Task<Purchase> GetPurchaseByIdAsync(int id)
        {
            return await _purchaseRepository.GetByIdAsync(id);
        }

        public async Task CreatePurchaseAsync(Purchase purchase)
        {
            await _purchaseRepository.AddAsync(purchase);
            await _purchaseRepository.SaveChangesAsync();
        }

        public async Task UpdatePurchaseAsync(Purchase purchase)
        {
            _purchaseRepository.Update(purchase);
            await _purchaseRepository.SaveChangesAsync();
        }

        public async Task DeletePurchaseAsync(int id)
        {
            var purchase = await _purchaseRepository.GetByIdAsync(id);
            if (purchase != null)
            {
                _purchaseRepository.Delete(purchase);
                await _purchaseRepository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Purchase>> GetPurchasesByUserIdAsync(int userId)
        {
            var allPurchases = await _purchaseRepository.GetAllAsync();
            return allPurchases.Where(p => p.UserId == userId);
        }
    }
}
