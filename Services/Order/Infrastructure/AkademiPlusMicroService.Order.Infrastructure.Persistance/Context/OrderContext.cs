﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AkademiPlusMicroService.Order.Infrastructure.Persistance.Context
{
    public class OrderContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost,1433;database=AkademiPlusOrderDb;user=sa;password=123456Aa*;");
        }
        public DbSet<Ordering> Orderings { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
