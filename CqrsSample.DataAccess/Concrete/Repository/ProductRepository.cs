using CqrsSample.DataAccess.Abstract;
using CqrsSample.DataAccess.Concrete.EntityFramework.Contexts;
using CqrsSample.DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CqrsSample.DataAccess.Concrete.Repository
{
    public class ProductRepository : EfEntityRepositoryBase<Product, NorthwindContext>, IProductRepository
    {
        public ProductRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
