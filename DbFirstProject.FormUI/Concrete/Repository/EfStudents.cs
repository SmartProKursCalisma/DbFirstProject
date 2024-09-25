using DbFirstProject.FormUI.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DbFirstProject.FormUI.Repository
{
    public class EfStudents : IStudentRepository
    {
        CourseProjectDbEntities db;

        public EfStudents()
        {
            db = new CourseProjectDbEntities();
        }

        public int Count { get; set; }

        public List<Students> GetAllStudents()
        {
            return db.Students.ToList();
        }
    }
}
