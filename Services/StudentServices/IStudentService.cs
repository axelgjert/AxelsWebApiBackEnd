using System.Collections.Generic;
using TE19DWEBAPIKURS.Models;

namespace TE19DWEBAPIKURS.Services.StudentServices
{
    public interface IStudentService
    {
        //1: Hämta alla studenter som finns i systemet.
        List<Student> GetStudentList();

        //2: Skapa en metod som lägger till en ny student
        List<Student> AddStudent(Student newStudent);
         
         //3: Skapa en metod som tar bort en student
        List<Student> DeleteStudent(int id);
        
        //4: Update student
         List<Student> UpdateStudent(Student updateStudent);
    }
}