using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Payment
    {
        [Key]
        public int pay_id  { get; set; }
    }
}
