using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Activity3a.Models
{
    public class AirlineTicketModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Where From")]
        public string City1 { get; set; }
        [DisplayName("Where To")]
        public string City2 { get; set; }   
        [DisplayName("Department Date")]
        public string Date { get; set; }
    
    }
}
