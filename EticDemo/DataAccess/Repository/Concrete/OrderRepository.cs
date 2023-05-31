using DataAccess.Context;
using DataAccess.Repository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Concrete
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(EticDbContext dbContext) : base(dbContext)
        {
        }
    }
}
