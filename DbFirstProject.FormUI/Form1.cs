using DbFirstProject.FormUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace DbFirstProject.FormUI
{
    public partial class Form1 : Form
    {
        CourseProjectDbEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new CourseProjectDbEntities();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = db.Students.Include("Grades").Select(x =>
                new StudentWithGradeModel
                {
                    Id = x.Id,
                    NameSurname = x.NameSurname,
                    PhoneNumber = x.PhoneNumber,
                    GradeName = x.Grades.GradeName
                }).ToList();



            dataGridView1.DataSource = list;


        }

        private void txtSeacrTerm_TextChanged(object sender, EventArgs e)
        {
            string txtSearch = txtSeacrTerm.Text;

            var list = db.Students
                .Include("Grades")
                .Where(x => x.NameSurname.Contains(txtSearch))
                .OrderBy(x => x.PhoneNumber)
                .ThenBy(x => x.NameSurname)
                .ThenByDescending(X => X.GradeId)
                .Select(x => new StudentWithGradeModel
                {
                    Id = x.Id,
                    NameSurname = x.NameSurname,
                    PhoneNumber = x.PhoneNumber,
                    GradeName = x.Grades.GradeName
                }).ToList();

            dataGridView1.DataSource = list;
        }
    }

}
