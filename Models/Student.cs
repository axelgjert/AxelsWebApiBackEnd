namespace TE19DWEBAPIKURS.Models
{
    public class Student
    {
        public int Id {get; set;} = 1;
        public string Name {get; set;} = "Jonas";
        public int Age { get; set; }  = 17;

        public StudentClass classStudent {get; set;} = StudentClass.TE19D; 

         
    }
}