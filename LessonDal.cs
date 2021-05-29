using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Forms
{
    public class LessonDal : IDal<Lesson>
    {

        public void Add(Lesson lesson)
        {
            using (SchoolContext context = new SchoolContext())
            {
                context.Lessons.Add(lesson);
                context.SaveChanges();
            }
        }

        public void Delete(Lesson lesson)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var entity = context.Entry(lesson);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Lesson> GetAll()
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Lessons.ToList();
            }
        }
        public List<Lesson> GetId(int key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Lessons.Where(p => p.Id >= key).ToList();

            }
        }
        public List<Lesson> GetName(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Lessons.Where(p => p.Name.Contains(key)).ToList();

            }
        }
        public List<Lesson> GetDepartmant(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Lessons.Where(p => p.Department.Contains(key)).ToList();

            }
        }
       
      
        public void Uptade(Lesson lesson)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var entity = context.Entry(lesson);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

     
    }
}
