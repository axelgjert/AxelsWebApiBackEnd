using System.Collections.Generic;
using System.Linq;
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

        public  List<Student> DeleteStudent(int id) {

              var hittadStudent =  studentLista.FirstOrDefault(student => student.Id == id);
               studentLista.Remove(hittadStudent);
            
            return studentLista;
        }


        public List<Student> UpdateStudent(Student updateStudent) {

            var hittadStudent = studentLista.FirstOrDefault(student => student.Id == updateStudent.Id);

            if(hittadStudent != null) {
                hittadStudent.Name = updateStudent.Name;
                hittadStudent.Age = updateStudent.Age;
            }

            return studentLista;
        }

      
    }
}