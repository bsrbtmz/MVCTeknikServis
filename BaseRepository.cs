using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.DAL;

namespace TeknikServis.BLL.Repository
{
    public class BaseRepository<TEntity> where TEntity:class
    {
        private TekServisEntities db;
        protected DbSet<TEntity> table;

        public BaseRepository()
        {
            db = new TekServisEntities();
            table = db.Set<TEntity>();
        }

        public int Save()
        {
            return db.SaveChanges();
        }
        public int ExecuteSqlCommand(string query)
        {
            return db.Database.ExecuteSqlCommand(query);
        }

        #region Insert
        public virtual int Insert(TEntity entity)
        {
            table.Add(entity);

            return Save();
        }

    
        #endregion

        

        #region Select
        public List<TEntity> SelectAll()
        {
            return table.ToList();
        }

        public List<TEntity> SelectByState(bool activeState, bool? deleteState = false)
        {
            return table
                .ToList();
        }

        public List<TEntity> SelectByCondition(Expression<Func<TEntity, bool>> predicate)
        {
            return table
                .Where(predicate).ToList();
        }

        public List<TEntity> SelectByCondition(Expression<Func<TEntity, bool>> predicate, bool activeState, bool deleteState)
        {
            if (activeState && !deleteState)
                return SelectByCondition(predicate);

            return table
                .Where(predicate)
                .ToList();
        }

        public TEntity Find(int Id)
        {
            return table.Find(Id);
        }

        public TEntity SelectOne(Expression<Func<TEntity, bool>> predicate)
        {
            return table.FirstOrDefault(predicate);
        }
        #endregion
        

    }
}
