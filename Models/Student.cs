using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Student{
        public int Id {get; set;}
        public string Name {get; set;}
        public string Department {get; set;}
        public string Gender {get; set;}
        public string Email {get; set;}
    }
}