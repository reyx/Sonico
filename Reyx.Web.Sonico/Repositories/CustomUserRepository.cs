using Reyx.Web.Sonico.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Reyx.Web.Sonico.Repository
{
    public class CustomUserRepository : ICustomUserRepository
    {
        ReyxWebSonicoContext context = new ReyxWebSonicoContext();

        public IQueryable<CustomUser> All
        {
            get { return context.Users.Select(t => new CustomUser("", t)); }
        }

        public IQueryable<CustomUser> AllIncluding(params Expression<Func<User, object>>[] includeProperties)
        {
            IQueryable<User> query = context.Users;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.Select(t => new CustomUser("", t));
        }

        public CustomUser Find(int id)
        {
            return new CustomUser("", context.Users.Find(id));
        }

        public void InsertOrUpdate(CustomUser customUser)
        {
            if (customUser.UserAccount.Id == default(int))
            {
                // New entity
                context.Users.Add(customUser.UserAccount);
            }
            else
            {
                // Existing entity
                context.Entry(customUser.UserAccount).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var user = context.Users.Find(id);
            context.Users.Remove(user);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }

    public interface ICustomUserRepository : IDisposable
    {
        IQueryable<CustomUser> All { get; }
        IQueryable<CustomUser> AllIncluding(params Expression<Func<User, object>>[] includeProperties);
        CustomUser Find(int id);
        void InsertOrUpdate(CustomUser user);
        void Delete(int id);
        void Save();
    }
}