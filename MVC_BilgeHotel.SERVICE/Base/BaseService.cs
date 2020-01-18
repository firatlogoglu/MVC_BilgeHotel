using MVC_BilgeHotel.CORE.Entity;
using MVC_BilgeHotel.CORE.Services;
using MVC_BilgeHotel.MODEL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.SERVICE.Base
{
    public class BaseService<T> : ICoreService<T> where T : CoreEntity
    {

        private static ProjectContext _database;
        private static ProjectContext db
        {
            get
            {
                if (_database == null)
                {
                    _database = new ProjectContext();
                }
                return _database;
            }
        }

        public void Add(T itme)
        {
            db.Set<T>().Add(itme);
            Save();
        }

        public void AddList(List<T> item)
        {
            db.Set<T>().AddRange(item);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Any(expression);
        }

        public List<T> GetActive()
        {
            return db.Set<T>().Where(x => x.GeneralStatus == MVC_BilgeHotel.CORE.Enums.GeneralStatus.Active).ToList();

        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetByDefault(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Where(expression).FirstOrDefault();
        }

        public T GetByID(T ID)
        {
            return db.Set<T>().Find(ID);
        }

        public List<T> GetGeneralStatus(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Where(expression).ToList();
        }

        public void Remove(T item)
        {
            item.GeneralStatus = MVC_BilgeHotel.CORE.Enums.GeneralStatus.Deleted;
            Update(item);
        }

        public void RemoveAll(Expression<Func<T, bool>> expression)
        {
            foreach (var item in GetGeneralStatus(expression))
            {
                item.GeneralStatus = MVC_BilgeHotel.CORE.Enums.GeneralStatus.Deleted;
                Update(item);
            }
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public void Update(T item)
        {
            //TODO: T updated = GetByID(item); DÜZELTİLECEK
            T updated = db.Set<T>().Find(item.ID);
            DbEntityEntry entry = db.Entry(updated);
            entry.CurrentValues.SetValues(item);
            Save();
        }
    }
}
