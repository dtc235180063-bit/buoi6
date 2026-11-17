using System.ComponentModel.DataAnnotations;

namespace buoi6.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên thể loại không được để trống")]
        [Display(Name = "Thể loại")]
        public string Name { get; set; } = string.Empty;

        public List<Movie>? Movies { get; set; }
    }
}
