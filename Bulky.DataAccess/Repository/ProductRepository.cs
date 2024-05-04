using Bulky.DataAccess.Data;
using Bulky.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        private readonly ApplicationDbContext _repository;
       public ProductRepository(ApplicationDbContext context):base(context) 
        {
            _repository = context;
        }

        public void Update(Product obj)
        {
            _repository.Update(obj);
            
        }
    }
}
