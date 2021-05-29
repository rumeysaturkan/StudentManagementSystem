using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Forms
{
    public class TeacherDal : IDal<Teacher>
    {
        public void Add(Teacher teacher)
        {
            using (SchoolContext context = new SchoolContext())
            {
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
        }

        public void Delete(Teacher teacher)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var entity = context.Entry(teacher);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Teacher> GetAll()
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Teachers.ToList();
            }
        }
        public List<Teacher> GetName(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Teachers.Where(p => p.Name.Contains(key)).ToList();

            }
        }
        public List<Teacher> GetSurname(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Teachers.Where(p => p.Surname.Contains(key)).ToList();

            }
        }
        public List<Teacher> GetGender(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Teachers.Where(p => p.Gender.Contains(key)).ToList();

            }
        }
        public List<Teacher> GetRoomNumber(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Teachers.Where(p => p.RoomNumber.Contains(key)).ToList();

            }
        }
        public List<Teacher> GetAcademicTitle(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Teachers.Where(p => p.AcademicTitle.Contains(key)).ToList();

            }
        }
        public List<Teacher> GetDepartment(string key)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Teachers.Where(p => p.Department.Contains(key)).ToList();

            }
        }

        public void Uptade(Teacher teacher)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var entity = context.Entry(teacher);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
