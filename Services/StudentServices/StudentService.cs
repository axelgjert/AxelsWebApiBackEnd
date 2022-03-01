using System.Collections.Generic;
using TE19DWEBAPIKURS.Models;

namespace TE19DWEBAPIKURS.Services.StudentServices
{
    public  class  StudentService : IStudentService
    {
        private static List<Student> studentLista = new List<Student>() {
            new Student() {Id=1, Name="Tim", classStudent=StudentClass.TE19D},
            new Student() {Id = 2, Name = "Albert", classStudent = StudentClass.TE19C}
        };

        public List<Student> GetStudentList() 
        {
            return studentLista;
        }

        public List<Student> AddStudent(Student newStudent) {
            studentLista.Add(newStudent);
            return studentLista;
        }

      
    }
}