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
            // for(int i = 0; i < studentLista.Count; i++) {
            //     if(studentLista[i].Id == id) {
            //         studentLista.Remove(studentLista[i]);
            //         return studentLista;
            //     }
            // }
              
              var hittadStudent =  studentLista.FirstOrDefault(s => s.Id == id);
               studentLista.Remove(hittadStudent);
            
            return studentLista;
        }

      
    }
}