using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Activity3a.Models
{
    public class MovieModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Movie Name")]
        public string Name { get; set; }

        [DisplayName("Movie Type")]
        public string MovieType { get; set; }
        [DisplayName("Movie Rating")]
        public string Rating { get; set; }
        [DisplayName("Movie Year")]
        public string Year { get; set; }
  
    }
}
