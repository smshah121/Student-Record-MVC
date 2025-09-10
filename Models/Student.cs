using System.ComponentModel.DataAnnotations;

namespace StudentRecordsMVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        public int Age { get; set; }
        public string Class { get; set; } = "";
        public int Marks { get; set; }
    }
}
