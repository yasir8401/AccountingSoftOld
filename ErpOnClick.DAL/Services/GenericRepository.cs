        
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private ERPonClickContext _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new ERPonClickContext();
            table = _context.Set<T>();
        }
        public GenericRepository(ERPonClickContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public DbSet<T> dbset()
        {
            return table;
        }




        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }


        public T GetById(object id)
        {
            return table.Find(id);
        }


        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return table.Where(expression).AsNoTracking();
        }

        public string Insert(T obj)
        {
            try
            {
                table.Add(obj);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "";

        }
        public string Update(T obj)
        {
            try
            {

                table.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                try
                {
                    _context.Entry(obj).Property("CreatedBy").IsModified = false;
                    _context.Entry(obj).Property("CreatedDate").IsModified = false;
                }
                catch { }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "";
        }


        public string Delete(object id)
        {
            try
            {
                T existing = table.Find(id);
                table.Remove(existing);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "";
        }

        public string SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                 return ex.ToString();
            }
            return "";
        }

    }
}