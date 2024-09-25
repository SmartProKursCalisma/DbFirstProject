using DbFirstProject.FormUI.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstProject.FormUI.Repository
{
    public class AdoStudents : IStudentRepository
    {
        string cs = "Server=202-00;Database=CourseProjectDb;User Id=sa;Password=1234;";

        public int Count { get ; set; }

        public List<Students> GetAllStudents()
        {
            List<Students> students = new List<Students>();
            using (SqlConnection baglanti = new SqlConnection(cs))
            {
                baglanti.Open();
                string sorgu = "select * from Students";
                using (SqlCommand komut = new SqlCommand(sorgu,baglanti))
                {
                    using (SqlDataReader okuyucu = komut.ExecuteReader())
                    {
                        while (okuyucu.Read())
                        {
                            Students student = new Students
                            {
                                Id = (int)okuyucu["Id"],
                                NameSurname = okuyucu["NameSurname"].ToString(),
                                PhoneNumber = okuyucu["PhoneNumber"].ToString(),
                                GradeId = (int)okuyucu["GradeId"]
                            };
                            students.Add(student);
                        }
                    }
                }
                baglanti.Close();
            }
            return students;
        }

       
    }
}
