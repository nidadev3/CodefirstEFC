 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CodefirstEFC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Column("StudentName", TypeName = "varchar(100)")]
        [Required] 
        public string StudentName { get; set; }


        [Column("StudentGender", TypeName = "varchar(20)")]
        public string Gender{ get; set; }
        [Column("StudentAge")]
        public int Age { get; set; }

    }
}
