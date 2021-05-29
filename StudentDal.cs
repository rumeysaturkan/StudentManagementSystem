using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Forms
{
    public class StudentDal : IDal<Student>
    {
        public List<Student> GetAll()
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Students.ToList();
            }
        }
        public List<Student> GetId(int key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Students.Where(p => p.Id >= key).ToList();

            }
        }
        public List<Student> GetName(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Students.Where(p => p.Name.Contains(key)).ToList();

            }
        }
        public List<Student> GetSurname(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Students.Where(p => p.Surname.Contains(key)).ToList();

            }
        }
        public List<Student> GetAge(int key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Students.Where(p => p.Age >= key).ToList();

            }
        }
        public List<Student> GetGender(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Students.Where(p => p.Gender.Contains(key)).ToList();

            }
        }
        public List<Student> GetDepartment(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Students.Where(p => p.Department.Contains(key)).ToList();

            }
        }
        public void Add(Student student)
        {
            using (SchoolContext context = new SchoolContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }


        }
        public void Uptade(Student student)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var entity = context.Entry(student);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        public void Delete(Student student)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var entity = context.Entry(student);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }



       
    }
}
