using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Activity3a.Models
{
    public class CarModel
    {
        [DisplayName("Id Name")]
        public int Id { get; set; }
        [DisplayName("Car Name")]
        public string Name { get; set; }
        [DisplayName("Car Date")]
        public string Date { get; set; }
        [DisplayName("Car Fuel")]
        public string Fuel { get; set; }
    }
}
