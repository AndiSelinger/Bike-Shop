using BikeShop.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Logic.DataContext
{
    partial class ProjectDbContext
    {
        public DbSet<Entities.Bike> BikeSet { get; set; }
        public DbSet<Shop> ShopSet { get; set; }

        partial void GetDbSet<E>(ref DbSet<E>? dbSet, ref bool handled) where E : IdentityEntity
        {
            if (typeof(E) == typeof(Entities.Bike))
            {
                dbSet = BikeSet as DbSet<E>;
                handled = true;
            }
            if (typeof(E) == typeof(Entities.Shop))
            {
                dbSet = ShopSet as DbSet<E>;
                handled = true;
            }
        }
    }
}
