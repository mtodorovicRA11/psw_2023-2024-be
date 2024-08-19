﻿using Explorer.Tours.Core.Domain;
using Explorer.Tours.Infrastructure.Database;

namespace Explorer.Tours.Infrastructure.Repositories
{
    public class TourRepository : GenericRepository<Tour>, ITourRepository
    {
        public TourRepository(ToursContext context) : base(context)
        {
        }
    }
}