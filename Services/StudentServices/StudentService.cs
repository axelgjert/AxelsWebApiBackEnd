using System.Collections.Generic;
using TE19DWEBAPIKURS.Models;

namespace TE19DWEBAPIKURS.Services.StudentServices
{
    public class StudentService : IStudentService
    {
        private List<Student> studentLista = new List<Student>() {
            new Student(),
            new Student() {Id = 2, Name = "Albert", classStudent = StudentClass.TE19C}
        };

        public List<Student> GetStudentList()
        {
            return studentLista;
        }
    }
}