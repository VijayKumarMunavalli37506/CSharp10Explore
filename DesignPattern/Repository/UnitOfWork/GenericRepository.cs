using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryUsingEFinMVC.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public EmployeeDBContext _context = null;
        //public DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new EmployeeDBContext();
           // table = _context.Set<T>();
        }
        public GenericRepository(EmployeeDBContext _context)
        {
            this._context = _context;
            //table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
            //return table.ToList();
        }
        public T GetById(object id)
        {
            throw new NotImplementedException();
            //return table.Find(id);
        }
        public void Insert(T obj)
        {
            throw new NotImplementedException();
            //table.Add(obj);
        }
        public void Update(T obj)
        {
            throw new NotImplementedException();
            // table.Attach(obj);
            //_context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            throw new NotImplementedException();
            // T existing = table.Find(id);
            //  table.Remove(existing);
        }
        public void Save()
        {
            throw new NotImplementedException();
            // _context.SaveChanges();
        }

        public void Delete(T obj)
        {
            throw new NotImplementedException();
        }
    }
}