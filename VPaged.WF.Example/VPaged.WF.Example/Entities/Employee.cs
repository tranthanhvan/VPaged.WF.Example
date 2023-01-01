using System.ComponentModel.DataAnnotations;

namespace VPaged.WF.Example.Entities
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
