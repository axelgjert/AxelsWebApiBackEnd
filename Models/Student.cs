namespace TE19DWEBAPIKURS.Models
{
    public class Student
    {
        public int Id {get; set;} = 1;
        public string Name {get; set;} = "Axel";
        public int Age { get; set; }  = 18;

        public StudentClass classStudent {get; set;} = StudentClass.TE19D; 

         
    }
}