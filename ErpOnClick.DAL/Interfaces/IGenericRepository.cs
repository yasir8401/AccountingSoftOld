using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        DbSet<T> dbset();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetAll();
        T GetById(object id);
        string Insert(T obj);
        string Update(T obj);
        string Delete(object id);
        string SaveChanges();
    }
}