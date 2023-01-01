using System.ComponentModel.DataAnnotations;

namespace VPaged.Example.Entities
{
    public class Employee
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
