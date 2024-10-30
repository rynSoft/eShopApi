using Microsoft.AspNetCore.Identity;
using eShop.Domain.Enum;
using System.Collections.Generic;
using eShop.Domain.Entities;

namespace eShop.Persistence.Seeds
{

    public static class SeedWorkCentre
    {
        public static List<WorkCentre> WorkCentreList()
        {
            return new List<WorkCentre>()
            {
                new WorkCentre
                {
                    Id = 1,
                    Name = "DEPO",
                },
                new WorkCentre
                {
                    Id = 2,
                    Name = "SMT DZG",
                },
                new WorkCentre
                {
                    Id = 3,
                    Name = "THT DZG",
                },
                new WorkCentre
                {
                    Id = 4,
                    Name = "KLT",
                },
                new WorkCentre
                {
                    Id = 5,
                    Name = "KMYSL",
                },
            
            };
        }
    }
}
