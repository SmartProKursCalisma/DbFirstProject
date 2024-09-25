using System.Collections.Generic;

namespace DbFirstProject.FormUI.Abstract
{
    public interface IStudentRepository
    {
         int Count { get; set; }
        List<Students> GetAllStudents();


    }
}
