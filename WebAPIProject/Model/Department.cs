using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIProject.Model
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int Deptid { get; set; }
        [Required]
        public string Deptname { get; set; }
    }
}
