using Explorer.Tours.Core.Domain;

namespace Explorer.Tours.Infrastructure.Repositories
{
    public interface IPurchaseRepository : IGenericRepository<Purchase>
    {
    }

    public class PurchaseRepository : GenericRepository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(ToursContext context) : base(context)
        {
        }
    }
}
