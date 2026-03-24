using System.ComponentModel.DataAnnotations;

namespace StudentRecordSystem.Models
{
    public class  Student
    {
        [Key]
        public int StudentId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
    }
}