using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Forms
{
    public class UserDal : IDal<User>
    {

        public List<User> GetAll()
        {
            using (SchoolContext context = new SchoolContext())

            {
                return context.Users.ToList();
            }
        }

        public List<User> GetId(int key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Users.Where(p => p.Id >=key ).ToList();

            }
        }
        public List<User> GetUserName(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Users.Where(p => p.Name.Contains(key)).ToList();

            }
        }
        public List<User> GetUserPassword(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Users.Where(p => p.password.Contains(key)).ToList();

            }
        }
        public void Add(User user)
        {
            try
            {
                using (SchoolContext context = new SchoolContext())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }


        }
        public void Uptade(User user)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var entity = context.Entry(user);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        public void Delete(User user)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var entity = context.Entry(user);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
