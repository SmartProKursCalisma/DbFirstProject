using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstProject.FormUI.ViewModel
{
    public class StudentWithGradeModel
    {
       
        [DisplayName("Öğrenci No")]
        public int Id { get; set; }

        [DisplayName("Ad Soyad")]
        public string NameSurname { get; set; }

        [DisplayName("İletişim No")]
        public string PhoneNumber { get; set; }

        [DisplayName("Sınıfı")]
        public string GradeName { get; set; }

    }
}
