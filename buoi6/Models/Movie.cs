using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace buoi6.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [Display(Name = "Tên phim")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Ngày phát hành")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Giá vé")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Display(Name = "Thể loại")]
        public int GenreId { get; set; }

        public Genre? Genre { get; set; }
    }
}
