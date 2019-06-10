using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Data
{
    public class Reposity<T> where T : BaseEntity
    {
        private readonly EmlakSDBEntities Context;
        public string ErrorMsg;
        private DbSet<T> entities;
        private IDbSet<T> Entities
        {
            get
            {
                if (entities == null)
                {
                    entities = Context.Set<T>();
                }
                return entities;
            }
        }
        public Reposity(EmlakSDBEntities context)
        {
            this.Context = context;
        }

        public T GetById(object id)
        {
            try
            {
                ErrorMsg = string.Empty;

                if (id != null)
                    return this.Entities.Find(id);
                else
                {
                    ErrorMsg = "entity is null";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
            return null;
        }
        public List<T> List()
        {
            try
            {
                return Entities.ToList();
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
            return null;
        }

        public T Insert(T entity)
        {
            try
            {
                ErrorMsg = string.Empty;
                if (entity != null)
                {
                    entity.CreateDate = DateTime.Now;
                    entity.DeleteDate = DateTime.MaxValue;
                    entity.UpdateDate = DateTime.Now;
                    entity.isDeleted = false;
                    this.Entities.Add(entity);
                    this.Context.SaveChanges();
                }
                else
                {
                    ErrorMsg = "entity is null";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
            return entity;

        }
        public void Update(T entity)
        {
            try
            {
                ErrorMsg = string.Empty;
                if (entity != null)
                {
                    entity.UpdateDate = DateTime.Now;
                    entity.isDeleted = false;

                    Entities.Attach(entity);
                    Context.Entry(entity).State = EntityState.Modified;
                    
                    Context.SaveChanges();
                }

                else   
                {
                    ErrorMsg = "entity is null";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
        }

        public void Delete(T entity)
        {
            try
            {
                ErrorMsg = string.Empty;
                if (entity != null)
                {
                    entity.DeleteDate = DateTime.Now;
                    entity.isDeleted = true;
     
                    Entities.Attach(entity);
                    Context.Entry(entity).State = EntityState.Modified;

                    this.Context.SaveChanges();
                }
                else
                {
                    ErrorMsg = "entity is null";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
        }

    }
}
