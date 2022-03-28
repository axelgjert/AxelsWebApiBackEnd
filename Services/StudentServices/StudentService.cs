using System.Collections.Generic;
using System.Linq;
using TE19DWEBAPIKURS.Models;

namespace TE19DWEBAPIKURS.Services.StudentServices
{
    public  class  StudentService : IStudentService
    {
        private static List<Student> studentLista = new List<Student>() {
            new Student() {Id=1, Name="Axel", classStudent=StudentClass.TE19D},
            new Student() {Id = 2, Name = "Gustav", classStudent = StudentClass.TE19C}
        };

        public DataContext Context { get; }

        private readonly DataContext _context;
        public StudentService(DataContext context)
        {
            _context = context;
        }

        public List<Student> GetStudentList() 
        {
            return _context.students.ToList();
        }

        public List<Student> AddStudent(Student newStudent) {
              _context.students.Add(newStudent);
             _context.SaveChanges();
            return _context.students.ToList();
        }

        public  List<Student> DeleteStudent(int id) {

              var hittadStudent =  _context.students.FirstOrDefault(student => student.Id == id);
               _context.students.Remove(hittadStudent);
               _context.SaveChanges();
            
            return _context.students.ToList();
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

      