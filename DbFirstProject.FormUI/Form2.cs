using DbFirstProject.FormUI.Abstract;
using DbFirstProject.FormUI.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFirstProject.FormUI
{
    public partial class Form2 : Form
    {
        IStudentRepository _repo;
        public Form2()
        {
            InitializeComponent();
            _repo = new EfStudents();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //_repo.test();
            dataGridView1.DataSource = _repo.GetAllStudents();
        }
    }
}
//SOLID
//INTERFACE
//Abstraction
//Contract