using Bulky.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ICategoryRepository category {  get;private set; }
        public IProductRepository product {  get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            this._db = db;
            category = new CategoryRepository(_db);
            product = new ProductRepository(_db);

        }
       

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
